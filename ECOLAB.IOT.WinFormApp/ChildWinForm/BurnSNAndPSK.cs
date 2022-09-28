using ECOLAB.IOT.Common.Utilities;
using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using System.ComponentModel;
using System.IO.Ports;
using System.Text;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class BurnSNAndPSK : Form
    {
        SynchronizationContext m_SyncContext = null;
        SerialPort serialPort = null;
        private COMSetting setting = CallerContext.ECOLABIOTBurnSNAndPSKService.GetDefaultCOMSetting();
        enum SendModeType : int { 
           Normal=0,
           File,
           Queue
        }

        enum SendState : int
        { 
            Unemit=0,
            Emit=1 
        }

        SendModeType sendModeType= SendModeType.Normal;
        SendState sendState = SendState.Unemit;
        public BurnSNAndPSK()
        {
            InitializeComponent();
            m_SyncContext = SynchronizationContext.Current;
        }
        private FormNormal formNormal = new FormNormal();
        private FormFileSend formFileSend = new FormFileSend();
        private void BurnSNAndPSK_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void textBox_SerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            var keyChar = e.KeyChar.ToString();
            ValidateSN(formNormal.textBox_SerialNumber.Text + keyChar);
        }

        private void textBox_ChooseFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            var keyChar = e.KeyChar.ToString();
            ValidateFile(formFileSend.textBox_ChooseFile.Text + keyChar);
        }

        private void checkBox_ValidateSN_CheckedChanged(object sender, EventArgs e)
        {
            ValidateSN(formNormal.textBox_SerialNumber.Text);
        }

        private async void button_GeneratePSK_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                return;
            }

            await Travel();

        }

        private void button_Connection_Click(object sender, EventArgs e)
        {
            Open();
            DisableOrEnableGeneratePSKButton();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            SetDefault();
        }

        private void BurnSNAndPSK_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                serialPort = null;
            }
        }

        private void textBox_SerialNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateSN(formNormal.textBox_SerialNumber.Text);
        }

        private void textBox_SerialNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateSN(formNormal.textBox_SerialNumber.Text);
        }
        private void textBox_ChooseFile_TextChanged(object sender, EventArgs e)
        {
            ValidateFile(formFileSend.textBox_ChooseFile.Text);
        }

        #region init
        private void Init()
        {

            BandDingSerialPort();
            BandDingBaudRate();
            BandDingParityBit();
            BandDingDataBit();
            BandDingStopBit();
            SetDefault();
            BandDindChildFormEvent();
            serialPort = new SerialPort();
        }
        private void BandDindChildFormEvent()
        {
            formNormal.textBox_SerialNumber.KeyPress += new KeyPressEventHandler(this.textBox_SerialNumber_KeyPress);
            formNormal.textBox_SerialNumber.TextChanged += new EventHandler(this.textBox_SerialNumber_TextChanged);
            formNormal.checkBox_ValidateSN.CheckedChanged += new EventHandler(this.checkBox_ValidateSN_CheckedChanged);
            formNormal.textBox_SerialNumber.TextChanged += new EventHandler(this.textBox_SerialNumber_TextChanged);
            formFileSend.textBox_ChooseFile.KeyPress += new KeyPressEventHandler(this.textBox_ChooseFile_KeyPress);
            formFileSend.textBox_ChooseFile.TextChanged += new EventHandler(this.textBox_ChooseFile_TextChanged);
            AddChildForm(formNormal);
        }
        private void BandDingSerialPort()
        {
            var ports = CallerContext.ECOLABIOTBurnSNAndPSKService.GetPortNames();
            this.comboBox_SerialPort.Items.AddRange(ports);
        }

        private void BandDingBaudRate()
        {
            var array = CallerContext.ECOLABIOTBurnSNAndPSKService.GetBaudRate();
            this.comboBox_BaudRate.Items.AddRange(array);
        }

        private void BandDingParityBit()
        {
            var array = CallerContext.ECOLABIOTBurnSNAndPSKService.GetParityBit();
            this.comboBox_ParityBit.Items.AddRange(array);
        }
        private void BandDingDataBit()
        {
            var array = CallerContext.ECOLABIOTBurnSNAndPSKService.GetDataBit();
            this.comboBox_DataBit.Items.AddRange(array);
        }
        private void BandDingStopBit()
        {
            var array = CallerContext.ECOLABIOTBurnSNAndPSKService.GetStopBit();
            this.comboBox_StopBit.Items.AddRange(array);
        }

        private void SetDefault()
        {
            comboBox_SerialPort.SelectedItem = setting.PortName;
            comboBox_BaudRate.SelectedItem = Enum.GetName(setting.BaudRate);
            comboBox_ParityBit.SelectedItem = Enum.GetName(setting.Parity);
            comboBox_DataBit.SelectedItem = Enum.GetName(setting.DataBit);
            comboBox_StopBit.SelectedItem = Enum.GetName(setting.StopBit);
        }
        #endregion
        #region Validate And DisableOrEnable Button 
        private new bool Validate()
        {
            if (ValidateSN(formNormal.textBox_SerialNumber.Text))
            {
                return false;
            }
            if (this.comboBox_SerialPort.SelectedItem.ToString() == null)
            {
                return false;
            }
            if (this.comboBox_BaudRate.SelectedItem.ToString() == null)
            {
                return false;
            }

            return true;
        }
        private bool ValidateSN(string sn)
        {
            var bl = true;
            if (!formNormal.checkBox_ValidateSN.Checked)
            {
                formNormal.label_SerualNubmer_Validate.Text = "";
                bl = true;
            }
            else if (string.IsNullOrEmpty(sn))
            {
                formNormal.label_SerualNubmer_Validate.Text = "SN is Empty, pls input SN";
                bl = false;
            }
            else if (!Utilities.ValidateSN(sn, out string message))
            {
                formNormal.label_SerualNubmer_Validate.Text = $"SN format is incorrect.\r\n{message}";
                bl = false;
            }
            else
            {
                formNormal.label_SerualNubmer_Validate.Text = "";
            }

            DisableOrEnableGeneratePSKButton();
            return bl;
        }
        private bool ValidateFile(string filePath)
        {
            var bl = true;
            
            if (string.IsNullOrEmpty(filePath))
            {
                formFileSend.label_ChooseFile_Validate.Text = "FilePath is Empty, pls input or choose file";
                bl = false;
            }
            else if (!File.Exists(Path.GetFullPath(filePath)))
            {
                formFileSend.label_ChooseFile_Validate.Text = $"FilePath format is incorrect, or the related file doesn't exist.";
                bl = false;
            }
            else
            {
                formFileSend.label_ChooseFile_Validate.Text = "";
            }

            DisableOrEnableGeneratePSKButton();
            return bl;
        }
        private void DisableOrEnableGeneratePSKButton()
        {
            if (button_Connection.Text == "Disconnection"  
                && sendState==SendState.Unemit
                && (
                    (sendModeType == SendModeType.Normal
                    && string.IsNullOrEmpty(formNormal.label_SerualNubmer_Validate.Text)
                    && !string.IsNullOrEmpty(formNormal.textBox_SerialNumber.Text)) 
                    ||
                    (sendModeType == SendModeType.File
                    && string.IsNullOrEmpty(formFileSend.label_ChooseFile_Validate.Text)
                    && !string.IsNullOrEmpty(formFileSend.textBox_ChooseFile.Text)
                    )
                   )
               )
            {
                button_GeneratePSK.BackColor = Color.FromArgb(0, 192, 0);
                button_GeneratePSK.Enabled = true;
                radioButton_CommonSendPattern.Enabled = true;
                radioButton_FileSendPattern.Enabled = true;
            }
            else
            {
                button_GeneratePSK.BackColor = SystemColors.AppWorkspace;
                button_GeneratePSK.Enabled = false;
                radioButton_CommonSendPattern.Enabled = false;
                radioButton_FileSendPattern.Enabled = false;
            }
        }
        private void EnableOrDisableSetting(bool bl = false)
        {
            comboBox_SerialPort.Enabled = bl;
            comboBox_BaudRate.Enabled = bl;
            comboBox_ParityBit.Enabled = bl;
            comboBox_DataBit.Enabled = bl;
            comboBox_StopBit.Enabled = bl;
            button_Reset.Enabled = bl;
        }
        #endregion
        #region Open Or Close serialPort
        private void Open()
        {
            try
            {
                if (button_Connection.Text == "Connection")
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
                else if (button_Connection.Text == "Disconnection")
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
        #region Burn Down sn and psk to IOTHub
        private async Task Travel()
        {
            sendState = SendState.Emit;
            DisableOrEnableGeneratePSKButton();
            try
            {
                if (sendModeType ==SendModeType.Normal)
                {
                   await CommonSendPattern();
                }
                else if (sendModeType == SendModeType.File)
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
                sendState = SendState.Unemit;
                DisableOrEnableGeneratePSKButton();
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

            SetupToIoTHub(sn, psk);
            if (!CheckDeviceConfig(sn, psk))
            {
                richTextBox_Output.AppendText("\n\r Control board configuration failed...");
                return;
            }

            var result = await RegisterDevice(sn);
            if (result.Status==Status.OK)
            {
                MessageBox.Show("The dashboard has successfully registered to the cloud. Congratulations!", "Message");
            }
            else {
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
                    //return false;
                    CallerContext.ECOLABIOTSecretService.DeleteSecret(key);
                }

                if (CallerContext.ECOLABIOTSecretService.ExistSecret(key))
                {
                    MessageBox.Show($"Existing PSK for this serial number, PSK ={key}");
                    return false;
                   // CallerContext.ECOLABIOTSecretService.DeleteSecret(key);
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
        private void SetupToIoTHub(string sn, string psk)
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
                Thread.Sleep(2000);
                serialPort.WriteLine("PSK=");
                Thread.Sleep(2000);
                //string cache = serialPort.ReadExisting();
                //Console.Write(cache);
                serialPort.WriteLine("SN=" + sn);
                Thread.Sleep(2000);
                serialPort.WriteLine("PSK=" + psk);
                Thread.Sleep(4000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Receive Data from IoTHub
        private StringBuilder builder = new StringBuilder();
        private void onDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                serialPort.ReadTimeout = 9000;
                var sn = formNormal.textBox_SerialNumber.Text;
                Thread.Sleep(2000);
                builder.Clear();//清除字符串构造器的内容
                int n = serialPort.BytesToRead;//先记录下来，避免丢失
                Byte[] bytes = new byte[n];
                serialPort.Read(bytes, 0, n);
                m_SyncContext.Post(new SendOrPostCallback((obj) =>
                {
                    try
                    {
                        builder.Append(Encoding.ASCII.GetString(bytes));
                        var log = builder.ToString();
                        richTextBox_Output.AppendText(builder.ToString());
                        richTextBox_Output.AppendText($"\r\n ==================================================================== \r\n");
                        if (string.IsNullOrEmpty(sn) && !log.Contains(formNormal.textBox_SerialNumber.Text))
                        {
                            richTextBox_Output.Text = $"Control board configuration failed...";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }), bytes);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        #endregion
        #region Check that IoTHub is set successfully
        private bool CheckDeviceConfig(string sn, string psk)
        {
            serialPort.ReadTimeout = 18000;

            try
            {
                Thread.Sleep(9000);
                string cache = serialPort.ReadExisting();
                richTextBox_Output.AppendText("===================================================================================\r\n" +
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
        #region BingChildForm
        private Form activeForm = null;
        private void AddChildForm(Form childForm)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            groupBox_Send.Controls.Add(childForm);
            groupBox_Send.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        private void linkLabel_ClearSerialNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formNormal.textBox_SerialNumber.Text = "";
        }

        private void radioButton_CommonSendPattern_CheckedChanged(object sender, EventArgs e)
        {
            sendModeType = SendModeType.Normal;
            DisableOrEnableGeneratePSKButton();
            AddChildForm(formNormal);
        }

        private void radioButton_FileSendPattern_CheckedChanged(object sender, EventArgs e)
        {
            sendModeType = SendModeType.File;
            DisableOrEnableGeneratePSKButton();
            AddChildForm(formFileSend);
        }
    }
}
