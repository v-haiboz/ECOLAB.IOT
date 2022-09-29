using ECOLAB.IOT.Common.Utilities;
using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using System.ComponentModel;
using System.IO.Ports;
using System.Text;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class Burn : Form
    {
        private COMSetting setting = CallerContext.ECOLABIOTBurnSNAndPSKService.GetDefaultCOMSetting();
        public Burn()
        {
            InitializeComponent();
        }

        private void Burn_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            SetDefault();
        }

        private void button_Connection_Click(object sender, EventArgs e)
        {
            Open();
            DisableOrEnableBurnDownButton();
        }

        #region Open Or Close serialPort
        private void Open()
        {
            try
            {
                if (CurrentContext.PortalState== PortalState.Close)
                {
                    string portName = comboBox_SerialPort.Text;
                    var buadRate = comboBox_BaudRate.Text.GetEnumValue<BaudRates>();
                    Parity parity = comboBox_ParityBit.Text.ToEnum<Parity>();
                    int dataBit = comboBox_DataBit.Text.GetEnumValue<DataBits>();
                    StopBits stopBits = comboBox_StopBit.Text.ToEnum<StopBits>();

                    serialPort = new SerialPort(portName, buadRate, parity, dataBit, stopBits);
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close();
                    }
                    serialPort.Open();
                    //serialPort.DataReceived += onDataReceived;
                    EnableOrDisableSetting();
                    pictureBox_Connection.Image = Properties.Resources.connection_BurnSN;
                    button_Connection.BackColor = Color.DarkRed;
                    button_Connection.Text = "Disconnection";
                }
                else if (CurrentContext.PortalState == PortalState.Open)
                {
                    serialPort.Close();
                    EnableOrDisableSetting(true);
                    pictureBox_Connection.Image = Properties.Resources.breakoff_BurnSN;
                    button_Connection.BackColor = SystemColors.Highlight;
                    button_Connection.Text = "Connection";
                }
            }
            catch (Exception errror)
            {
                MessageBox.Show(errror.Message);
            }
        }
        #endregion

        private void radioButton_CommonSendPattern_CheckedChanged(object sender, EventArgs e)
        {
            AddChildForm(formNormal);
            DisableOrEnableBurnDownButton();
        }

        private void radioButton_FileSendPattern_CheckedChanged(object sender, EventArgs e)
        {
            AddChildForm(formFileSend);
            DisableOrEnableBurnDownButton();
        }

        private void textBox_SerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            var keyChar = e.KeyChar.ToString();
            FormNormal_ValidateSN(formNormal.textBox_SerialNumber.Text + keyChar);
        }
        private void textBox_SerialNumber_TextChanged(object sender, EventArgs e)
        {
            FormNormal_ValidateSN(formNormal.textBox_SerialNumber.Text);
        }

        private void checkBox_ValidateSN_CheckedChanged(object sender, EventArgs e)
        {
            FormNormal_ValidateSN(formNormal.textBox_SerialNumber.Text);
        }

        private void textBox_ChooseFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            var keyChar = e.KeyChar.ToString();
            FormFileSend_ValidateFile(formFileSend.textBox_ChooseFile.Text + keyChar);
        }

        private void textBox_ChooseFile_TextChanged(object sender, EventArgs e)
        {
            FormFileSend_ValidateFile(formFileSend.textBox_ChooseFile.Text);
        }

        private async void button_BurnDown_Click(object sender, EventArgs e)
        {
            if (BurnDown_Validate())
            {
                return;
            }

            await Travel();
        }

        #region Burn Down sn and psk to IOTHub
        private async Task Travel()
        {
            try
            {
                ChangeSendStatusToDisable();
                if (CurrentContext.SendModeType == SendModeType.Normal)
                {
                    await CommonSendPattern();
                }
                else if (CurrentContext.SendModeType == SendModeType.File)
                {
                    SendFilePattern();
                }
            }
            catch (Exception ex)
            {
                richTextBox_Output.AppendText("\n\r Control board configuration succeed...");
            }
            finally
            {
                ChangeSendStatusToEnable();
            }

        }
        #endregion

        #region Send Pattern
        private async Task CommonSendPattern()
        {
            var sn = formNormal.textBox_SerialNumber.Text;
            if (!SetSecret($"{sn}PSK", Utilities.RandomGenerateString(), out string psk))
            {
                return;
            }

            if (!SetupToIoTHub(sn, psk))
            {
                return;
            }

            if (!CheckDeviceConfig(sn, psk))
            {
                richTextBox_Output.AppendText("\n\r Control board configuration failed...");
                return;
            }

            var result = await RegisterDevice(sn);
            if (result.Status == Status.OK)
            {
                MessageBox.Show("The dashboard has successfully registered to the cloud. Congratulations!", "Message");
            }
            else
            {
                MessageBox.Show(result.Message, "Message");
            }

            richTextBox_Output.AppendText("\n\r Control board configuration succeed...");
        }

        private void SendFilePattern()
        {


        }
        #endregion

        #region Register Device
        private async Task<TData<string>> RegisterDevice(string sn)
        {
            var model = new DeviceRegister()
            {
                IsEnabled = "true",
                DeviceType = CallerContext.AppServiceOptions.DeviceType,
                PlatformName = CallerContext.AppServiceOptions.PlatformName,
                SerialNumber = sn
            };

            var result = await CallerContext.ECOLABIOTRegisterDeviceService.RegisterDevice(model);
            return result;
        }
        #endregion
        #region genereate psk, and then send to keyvalut.
        private bool SetSecret(string key, string value, out string psk)
        {
            psk = "";
            try
            {

                if (CallerContext.ECOLABIOTSecretService.ExistSecret(key))
                {
                    MessageBox.Show($"Existing PSK for this serial number, PSK ={key}");
                    return false;
                    //CallerContext.ECOLABIOTSecretService.DeleteSecret(key);
                }

                psk = CallerContext.ECOLABIOTSecretService.SetSecret(key, value);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Shared secret key generation exception. {ex}");
                return false;
            }
        }
        #endregion
        #region setup To IoTHub
        private bool SetupToIoTHub(string sn, string psk)
        {
            try
            {
                MessageBoxButtons _btn = MessageBoxButtons.OK;
                MessageBox.Show(this, "Please press the 'reset' key on the control board, and then click 'OK' immediately",
                                "Please note that!", _btn);
                Thread.Sleep(3000);
                if (serialPort.IsOpen == false)
                {
                    serialPort.Open();
                }

                serialPort.WriteLine("SN=");
                Thread.Sleep(500);
                serialPort.WriteLine("PSK=");
                Thread.Sleep(500);
                //string cache = serialPort.ReadExisting();
                //Console.Write(cache);
                serialPort.WriteLine("SN=" + sn);
                Thread.Sleep(2000);
                serialPort.WriteLine("PSK=" + psk);
                Thread.Sleep(4000);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region Check that IoTHub is set successfully
        private bool CheckDeviceConfig(string sn, string psk)
        {
            serialPort.ReadTimeout = 9000;

            try
            {
                Thread.Sleep(2000);
                string cache = serialPort.ReadExisting();
                richTextBox_Output.AppendText("======================================================================\r\n" +
                    $"{cache}\r\n\r\n {richTextBox_Output.Text}");

                if (!cache.Contains(sn) || !cache.Contains(psk))
                {

                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion

        private void BurnSNAndPSK_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                serialPort = null;
            }
        }
    }
}
