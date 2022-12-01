using ECOLAB.IOT.Common.Utilities;
using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using ECOLAB.IOT.Transmit;
using ECOLAB.IOT.Transmit.FileTransmit;
using ECOLAB.IOT.Transmit.SNAndPSKSend;
using System.ComponentModel;
using System.IO.Ports;
using System.Text;
using System.Xml.Linq;
using static ECOLAB.IOT.Transmit.ITransmitUart;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class Burn : Form
    {
        private COMSetting setting = CallerContext.ECOLABIOTBurnSNAndPSKService.GetDefaultCOMSetting();
        ComponentResourceManager res = new ComponentResourceManager(typeof(Burn));
        public Burn()
        {
            InitializeComponent();
        }
        TextWriter _writer = null;
        private void Burn_Load(object sender, EventArgs e)
        {
            Init();
            _writer = new TextBoxStreamWriter(richTextBox_Output);
            Console.SetOut(_writer);
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
                if (CurrentContext.PortalState == PortalState.Close)
                {
                    string portName = comboBox_SerialPort.Text;
                    var buadRate = comboBox_BaudRate.Text.GetEnumValue<BaudRates>();
                    Parity parity = comboBox_ParityBit.Text.ToEnum<Parity>();
                    int dataBit = int.Parse(comboBox_DataBit.Text);
                    StopBits stopBit = Utilities.MappingStopBit(comboBox_StopBit.Text);

                    serialPort = new SerialPort(portName, buadRate, parity, dataBit, stopBit);
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close();
                    }
                    serialPort.Open();
                    //serialPort.DataReceived += onDataReceived;
                    EnableOrDisableSetting();
                    pictureBox_Connection.Image = Properties.Resources.connection_BurnSN3;
                    button_Connection.BackColor = Color.DarkRed;
                    button_Connection.Text = res.GetString("button_Connection_Disable");
                }
                else if (CurrentContext.PortalState == PortalState.Open)
                {
                    serialPort.Close();
                    EnableOrDisableSetting(true);
                    pictureBox_Connection.Image = Properties.Resources.breakoff_BurnSN;
                    button_Connection.BackColor = SystemColors.Highlight;
                    button_Connection.Text = res.GetString("button_Connection_Enable");
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

        private void checkBox_EnableMappingPrefix_Click(object sender, EventArgs e)
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
            //FormFileSend_ValidateFile(formFileSend.textBox_ChooseFile.Text + keyChar);
        }

        private void textBox_ChooseFile_TextChanged(object sender, EventArgs e)
        {
            //FormFileSend_ValidateFile(formFileSend.textBox_ChooseFile.Text);
        }

        private void textBox_ChooseVersion_TextChanged(object sender, EventArgs e)
        {
            dynamic version = formFileSend.comboBox_Version.SelectedItem;
            if (version != null)
            {
               var filePath = version.FilePath;
               FormFileSend_ValidateChooseFile(filePath);
            }
            
        }

        private async void button_BurnDown_Click(object sender, EventArgs e)
        {
            await Travel();
        }

        #region Burn Down sn and psk to IOTHub
        private async Task Travel()
        {
            if (!CallerContext.ECOLABIOTLogSettingService.GetLogSetting().DeviceLogContinuity)
            {
                richTextBox_Output.Clear();
            }

            if (CurrentContext.SendModeType == SendModeType.Normal)
            {
                try
                {
                    await CommonSendPattern();
                }
                catch(Exception ex)
                {
                    richTextBox_Output.AppendText($"\n\r {res.GetString("message_Travel_failed")}");
                }
            }
            else if (CurrentContext.SendModeType == SendModeType.File)
            {
                try
                {
                    SendFilePattern();
                }
                catch(Exception ex)
                {
                    richTextBox_Output.AppendText($"\n\r {res.GetString("message_Travel_failed1")}");
                }
            }
        }

        
        #endregion

        #region Send Pattern

        private async Task CommonSendPattern()
        {
            var sn = formNormal.textBox_SerialNumber.Text;
            var snAndspk = new SNAndPSK(serialPort, sn,formNormal.label_SNPrefix.Text, TransForm);
            snAndspk.OutPutEvent += new OutPutEventHandler(snAndspkSend_OutPutEvent);
            snAndspk.SendResultEvent += new EventHandler(snAndspkSend_SendCompletedEvent);
            snAndspk.MessageBoxEvent += new MessageBoxEventHandler(snAndspkSend_MessageBoxEvent);
            snAndspk.Send();
        }

        public string TransForm(string errormessageId)
        {
            return res.GetString(errormessageId);
        }

        private void snAndspkSend_OutPutEvent(object sender, TrackerReceiveData e)
        {
            var message = e.ReceiveMessage;
            if (e.TransForm)
            {
                message = res.GetString(message);
            }

            if (e.IsWriteLine)
            {
                message = $"\n\r {message}";
            }
            
            richTextBox_Output.AppendText($"{message}");
            Utility.Track($"{message}", true);
        }

        private void snAndspkSend_MessageBoxEvent(object sender, TrackerMessageBox e)
        {
            var text = e.Text;
            var caption = e.Caption;
            if (e.MessageBoxButtons == ReceviedMessageBoxButtons.OK)
            {
                MessageBoxButtons _btn = MessageBoxButtons.OK;
                MessageBox.Show(this, text, caption, _btn);
            }
            else if (e.MessageBoxButtons == ReceviedMessageBoxButtons.OKCancel)
            {
                MessageBox.Show(text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(text, caption);
            }
        }
        private void snAndspkSend_SendCompletedEvent(object sender, EventArgs e)
        {
            var bl = (bool)sender;
            if (bl)
            {
                ChangeSendStatusToDisable();
            }
            else
            {
                ChangeSendStatusToEnable();
            }
        }


        private void SendFilePattern()
        {
            if (formFileSend.comboBox_TransportProtocol.Text == Enum.GetName(TransportProtocol.Xmodem))
            {
                var version = formFileSend.comboBox_Version.SelectedItem as DGWModeConfig;
                var xmodem = new XModem(serialPort, version?.FilePath, formFileSend.checkBox_isCRC.Checked);
                xmodem.OutPutEvent += new OutPutEventHandler(fileSend_OutPutEvent);
                xmodem.SendResultEvent += new EventHandler(fileSend_SendCompletedEvent);
                xmodem.MessageBoxEvent += new MessageBoxEventHandler(snAndspkSend_MessageBoxEvent);
                xmodem.Send();
            }
            else if (formFileSend.comboBox_TransportProtocol.Text == Enum.GetName(TransportProtocol.Xmodem1k))
            {
                var version = formFileSend.comboBox_Version.SelectedItem as DGWModeConfig;
                var xmodem1k = new Xmodem1k(serialPort, version?.FilePath, formFileSend.checkBox_isCRC.Checked);
                xmodem1k.OutPutEvent += new OutPutEventHandler(fileSend_OutPutEvent);
                xmodem1k.SendResultEvent += new EventHandler(fileSend_SendCompletedEvent);
                xmodem1k.MessageBoxEvent += new MessageBoxEventHandler(snAndspkSend_MessageBoxEvent);
                xmodem1k.Send();
            }
            //else if (formFileSend.comboBox_TransportProtocol.Text == Enum.GetName(TransportProtocol.Ymodem))
            //{
            //    var ymodem = new YModem(serialPort, formFileSend.comboBox_ModeName.DisplayMember);
            //    ymodem.OutPutEvent += new OutPutEventHandler(fileSend_OutPutEvent);
            //    ymodem.SendResultEvent += new EventHandler(fileSend_SendCompletedEvent);
            //    ymodem.Send();
            //}
        }
        

        private void fileSend_OutPutEvent(object sender, TrackerReceiveData e)
        {
            var message = e.ReceiveMessage;
            if (e.TransForm)
            {
                message = res.GetString(message);
            }

            if (e.IsWriteLine)
            {
                message = $"\n\r {message}";
            }

            richTextBox_Output.AppendText($"{message}");
            Utility.Track($"{message}", true);
        }
        private void fileSend_SendCompletedEvent(object sender, EventArgs e)
        {
            var bl = (bool)sender;
            if (bl)
            {
                ChangeSendStatusToDisable();
            }
            else
            {
                ChangeSendStatusToEnable();
            }
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

        private void button_Memory_Click(object sender, EventArgs e)
        {
            button_Memory.Enabled = false;
            var setting = new COMSetting();
            setting.PortName = comboBox_SerialPort.Text;
            setting.BaudRate = (BaudRates)Enum.Parse(typeof(BaudRates), comboBox_BaudRate.Text);
            setting.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_ParityBit.Text);
            setting.DataBit = (DataBits)(int.Parse(comboBox_DataBit.Text));
            setting.StopBit = Utilities.MappingStopBit(comboBox_StopBit.Text);
            CallerContext.ECOLABIOTBurnSNAndPSKService.MemorySetting(setting);
            button_Memory.Enabled = true;
        }
    }
}
