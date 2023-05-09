using ECOLAB.IOT.Common.Utilities;
using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using ECOLAB.IOT.Transmit;
using ECOLAB.IOT.Transmit.FileTransmit;
using ECOLAB.IOT.Transmit.SNAndPSKSend;
using System.ComponentModel;
using System.IO.Ports;
using System.Windows.Forms;
using static ECOLAB.IOT.Transmit.ITransmitUart;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class Burn : Form
    {
        private COMSetting setting = CallerContext.ECOLABIOTBurnSNAndPSKService.GetDefaultCOMSetting();
        ComponentResourceManager res = new ComponentResourceManager(typeof(Burn));
        private CustomMessageBoxDialogResult customMessageBoxDialogResult;
        public Burn(CustomMessageBoxDialogResult customMessageBoxDialogResult)
        {
            InitializeComponent();
            this.customMessageBoxDialogResult = customMessageBoxDialogResult;
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
                EnableOrDisableSetting();

            }
            catch (Exception errror)
            {
                MessageBox.Show(errror.Message);
            }
        }

        private void Close()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }

                EnableOrDisableSetting(true);
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

        private void formFileSend_textBox_SerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ((TextBox)sender).SelectionLength = 0;
            if (e.KeyChar == 8 && formFileSend.textBox_SerialNumber.Text == "DGW" && (formFileSend.textBox_SerialNumber.Text.Length <= 3 || formFileSend.textBox_SerialNumber.Text.Length - formFileSend.textBox_SerialNumber.SelectedText.Length <= 3))
            {
                e.Handled = true;
                return;
            }

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {

                e.Handled = true;
                return;
            }

            var keyChar = e.KeyChar.ToString();
            if (e.KeyChar != 8)
            {
                Form_ValidateSN(formFileSend.textBox_SerialNumber.Text + keyChar);
            }
        }

        private void formFileSend_textBox_SerialNumber_TextChanged(object sender, EventArgs e)
        {
            Form_ValidateSN(formFileSend.textBox_SerialNumber.Text);
        }

        private void formFileSend_checkBox_ValidateSN_CheckedChanged(object sender, EventArgs e)
        {
            Form_ValidateSN(formFileSend.textBox_SerialNumber.Text);
        }

        private void formFileSend_checkBox_EnableMappingPrefix_Click(object sender, EventArgs e)
        {
            Form_ValidateSN(formFileSend.textBox_SerialNumber.Text);
        }

        private void textBox_SerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            var keyChar = e.KeyChar.ToString();
            Form_ValidateSN(formNormal.textBox_SerialNumber.Text + keyChar);
        }
        private void textBox_SerialNumber_TextChanged(object sender, EventArgs e)
        {
            Form_ValidateSN(formNormal.textBox_SerialNumber.Text);
        }

        private void checkBox_ValidateSN_CheckedChanged(object sender, EventArgs e)
        {
            Form_ValidateSN(formNormal.textBox_SerialNumber.Text);
        }

        private void checkBox_EnableMappingPrefix_Click(object sender, EventArgs e)
        {
            Form_ValidateSN(formNormal.textBox_SerialNumber.Text);
        }

        private async void button_BurnDown_Click(object sender, EventArgs e)
        {
            await Travel();
        }

        #region Burn Down sn and psk to IOTHub
        private async Task Travel()
        {
            Open();
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
                catch (Exception ex)
                {
                    richTextBox_Output.AppendText($"\n{res.GetString("message_Travel_failed")}\r");
                }
            }
            else if (CurrentContext.SendModeType == SendModeType.File)
            {
                try
                {
                    SendFilePattern();
                }
                catch (Exception ex)
                {
                    richTextBox_Output.AppendText($"\n{res.GetString("message_Travel_failed1")}\r");
                }
            }

            Close();
        }


        #endregion

        #region Send Pattern

        private async Task CommonSendPattern()
        {
            var sn = formNormal.textBox_SerialNumber.Text;
            var snAndspk = new SNAndPSK(serialPort, sn, formNormal.label_SNPrefix.Text, TransForm);
            snAndspk.OutPutEvent += new OutPutEventHandler(snAndspkSend_OutPutEvent);
            snAndspk.SendResultEvent += new EventHandler(snAndspkSend_SendCompletedEvent);
            snAndspk.MessageBoxEvent += new MessageBoxEventHandler(snAndspkSend_MessageBoxEvent);
            snAndspk.Send(true);
        }

        public string TransForm(string errormessageId)
        {
            return res.GetString(errormessageId);
        }

        private void snAndspkSend_OutPutEvent(object sender, TrackerReceiveData e)
        {
            var message = e.ReceiveMessage;
            if (!CallerContext.ECOLABIOTLogSettingService.GetLogSetting().Debug && !string.IsNullOrEmpty(e.ReceiveMessageRelease))
            {
                message = e.ReceiveMessageRelease;
            }

            if (e.TransForm)
            {
                message = res.GetString(message);
            }

            if (e.IsWriteLine)
            {
                message = $"\n\r {message}";
            }

            richTextBox_Output.AppendText($"{message}");
            if (CallerContext.ECOLABIOTLogSettingService.GetLogSetting().Debug)
            {
                Utility.Track($"{message}", true);
            }
            else
            {
                message = e.ReceiveMessage;
                if (e.TransForm)
                {
                    message = res.GetString(message);
                }

                if (e.IsWriteLine)
                {
                    message = $"\n\r {message}";
                }


                Utility.Track($"{message}", true);
            }
               
        }

        private void snAndspkSend_MessageBoxEvent(object sender, TrackerMessageBox e)
        {
            var text = e.Text;
            var caption = e.Caption;
            var boxIcon = MessageBoxIcon.Information;

            if (e.MessageBoxIcon == ReceviedMessageBoxIcon.Error)
            {
                boxIcon = MessageBoxIcon.Error;
            }


            if (e.MessageBoxButtons == ReceviedMessageBoxButtons.OK)
            {
                MessageBoxButtons _btn = MessageBoxButtons.OK;
                MessageBox.Show(text, caption, _btn, boxIcon);
            }
            else if (e.MessageBoxButtons == ReceviedMessageBoxButtons.OKCancel)
            {
                MessageBox.Show(text, caption, MessageBoxButtons.OKCancel, boxIcon);
            }
            else
            {
                MessageBox.Show(text, caption);
            }
        }
        private void snAndspkSend_SendCompletedEvent(object sender, EventArgs e)
        {
            var keyValuePair = (KeyValuePair<bool, bool>)sender;
            if (keyValuePair.Key)
            {
                ChangeSendStatusToDisable(keyValuePair);
            }
            else
            {
                ChangeSendStatusToEnable(keyValuePair);
            }
        }


        private void SendFilePattern()
        {
            var sn = formFileSend.textBox_SerialNumber.Text;
            var snAndspk = new SNAndPSK(serialPort, sn, formNormal.label_SNPrefix.Text, TransForm);
            snAndspk.OutPutEvent += new OutPutEventHandler(snAndspkSend_OutPutEvent);
            snAndspk.SendResultEvent += new EventHandler(snAndspkSend_SendCompletedEvent);
            snAndspk.MessageBoxEvent += new MessageBoxEventHandler(snAndspkSend_MessageBoxEvent);
            var result = snAndspk.Send(false);
            if (!result)
            {
                return;
            }

            Thread.Sleep(1000);


            if (customMessageBoxDialogResult.TransportProtocol == Enum.GetName(TransportProtocol.Xmodem))
            {
                var xmodem = new XModem(serialPort, customMessageBoxDialogResult.DGWModeConfig.FilePath, customMessageBoxDialogResult.IsCRC);
                xmodem.OutPutEvent += new IFileTransmit.OutPutEventHandler(fileSend_OutPutEvent);
                xmodem.SendResultEvent += new EventHandler(fileSend_SendCompletedEvent);
                xmodem.MessageBoxEvent += new IFileTransmit.MessageBoxEventHandler(snAndspkSend_MessageBoxEvent);
                xmodem.OutTransforer += new IFileTransmit.Transforer(Transfor);
                xmodem.Send();
            }
            else if (customMessageBoxDialogResult.TransportProtocol == Enum.GetName(TransportProtocol.Xmodem1k))
            {
                var xmodem1k = new Xmodem1k(serialPort, customMessageBoxDialogResult.DGWModeConfig.FilePath, customMessageBoxDialogResult.IsCRC);
                xmodem1k.OutPutEvent += new IFileTransmit.OutPutEventHandler(fileSend_OutPutEvent);
                xmodem1k.SendResultEvent += new EventHandler(fileSend_SendCompletedEvent);
                xmodem1k.MessageBoxEvent += new IFileTransmit.MessageBoxEventHandler(snAndspkSend_MessageBoxEvent);
                xmodem1k.OutTransforer += new IFileTransmit.Transforer(Transfor);
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

        private string Transfor(string strkey)
        {
            if (string.IsNullOrEmpty(strkey))
            {
                return strkey;
            }

            return res?.GetString(strkey);
        }

        private void fileSend_OutPutEvent(object sender, TrackerReceiveData e)
        {
            var message = e.ReceiveMessage;
            if (!CallerContext.ECOLABIOTLogSettingService.GetLogSetting().Debug)
            {
                message = string.IsNullOrEmpty(e.ReceiveMessageRelease)? message : e.ReceiveMessageRelease;
            }
            
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
            var keyValue = (KeyValuePair<bool, bool>)sender;
            if (keyValue.Key)
            {
                ChangeSendStatusToDisable(keyValue);
            }
            else
            {
                ChangeSendStatusToEnable(keyValue);
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

        private void checkBox_Modify_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_Modify_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBoxModifyCheckedChanged();
        }

        private void CheckBoxModifyCheckedChanged()
        {
            if (!CallerContext.SysAdmin.IsSuper)
            {
                comboBox_BaudRate.Enabled = false;
                comboBox_ParityBit.Enabled = false;
                comboBox_DataBit.Enabled = false;
                comboBox_StopBit.Enabled = false;
                button_Reset.Enabled = false;
                button_Memory.Enabled = false;
                button_Reset.Visible = false;
                button_Memory.Visible = false;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            BandDingSerialPort();
        }
    }
}
