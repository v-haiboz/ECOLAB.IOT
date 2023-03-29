using ECOLAB.IOT.Common.Utilities;
using ECOLAB.IOT.Service;
using System.IO.Ports;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    partial class Burn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Burn));
            System.Text.DecoderReplacementFallback decoderReplacementFallback1 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback1 = new System.Text.EncoderReplacementFallback();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_DeviceLog = new System.Windows.Forms.GroupBox();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.groupBox_Send = new System.Windows.Forms.GroupBox();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.groupBox_SendSetting = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_BurnDown = new System.Windows.Forms.Button();
            this.radioButton_FileSendPattern = new System.Windows.Forms.RadioButton();
            this.radioButton_QueueSendPattern = new System.Windows.Forms.RadioButton();
            this.radioButton_CommonSendPattern = new System.Windows.Forms.RadioButton();
            this.groupBox_Configuration = new System.Windows.Forms.GroupBox();
            this.button_Memory = new System.Windows.Forms.Button();
            this.pictureBox_Connection = new System.Windows.Forms.PictureBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.comboBox_StopBit = new System.Windows.Forms.ComboBox();
            this.label_StopBit = new System.Windows.Forms.Label();
            this.comboBox_DataBit = new System.Windows.Forms.ComboBox();
            this.label_DataBit = new System.Windows.Forms.Label();
            this.comboBox_ParityBit = new System.Windows.Forms.ComboBox();
            this.label_ParityBit = new System.Windows.Forms.Label();
            this.button_Connection = new System.Windows.Forms.Button();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label_BaudRate = new System.Windows.Forms.Label();
            this.comboBox_SerialPort = new System.Windows.Forms.ComboBox();
            this.label_SerialPort = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_DeviceLog.SuspendLayout();
            this.panel_Setting.SuspendLayout();
            this.groupBox_SendSetting.SuspendLayout();
            this.groupBox_Configuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Connection)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_DeviceLog);
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_Send);
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            // 
            // groupBox_DeviceLog
            // 
            this.groupBox_DeviceLog.Controls.Add(this.richTextBox_Output);
            resources.ApplyResources(this.groupBox_DeviceLog, "groupBox_DeviceLog");
            this.groupBox_DeviceLog.Name = "groupBox_DeviceLog";
            this.groupBox_DeviceLog.TabStop = false;
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.BackColor = System.Drawing.Color.Black;
            this.richTextBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox_Output, "richTextBox_Output");
            this.richTextBox_Output.ForeColor = System.Drawing.Color.White;
            this.richTextBox_Output.Name = "richTextBox_Output";
            // 
            // groupBox_Send
            // 
            this.groupBox_Send.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.groupBox_Send, "groupBox_Send");
            this.groupBox_Send.Name = "groupBox_Send";
            this.groupBox_Send.TabStop = false;
            // 
            // panel_Setting
            // 
            this.panel_Setting.Controls.Add(this.groupBox_SendSetting);
            this.panel_Setting.Controls.Add(this.groupBox_Configuration);
            resources.ApplyResources(this.panel_Setting, "panel_Setting");
            this.panel_Setting.Name = "panel_Setting";
            // 
            // groupBox_SendSetting
            // 
            this.groupBox_SendSetting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_SendSetting.Controls.Add(this.label1);
            this.groupBox_SendSetting.Controls.Add(this.button_BurnDown);
            this.groupBox_SendSetting.Controls.Add(this.radioButton_FileSendPattern);
            this.groupBox_SendSetting.Controls.Add(this.radioButton_QueueSendPattern);
            this.groupBox_SendSetting.Controls.Add(this.radioButton_CommonSendPattern);
            resources.ApplyResources(this.groupBox_SendSetting, "groupBox_SendSetting");
            this.groupBox_SendSetting.Name = "groupBox_SendSetting";
            this.groupBox_SendSetting.TabStop = false;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Name = "label1";
            // 
            // button_BurnDown
            // 
            this.button_BurnDown.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.button_BurnDown, "button_BurnDown");
            this.button_BurnDown.FlatAppearance.BorderSize = 0;
            this.button_BurnDown.ForeColor = System.Drawing.Color.White;
            this.button_BurnDown.Name = "button_BurnDown";
            this.button_BurnDown.UseVisualStyleBackColor = false;
            this.button_BurnDown.Click += new System.EventHandler(this.button_BurnDown_Click);
            // 
            // radioButton_FileSendPattern
            // 
            resources.ApplyResources(this.radioButton_FileSendPattern, "radioButton_FileSendPattern");
            this.radioButton_FileSendPattern.FlatAppearance.BorderSize = 0;
            this.radioButton_FileSendPattern.Name = "radioButton_FileSendPattern";
            this.radioButton_FileSendPattern.TabStop = true;
            this.radioButton_FileSendPattern.UseVisualStyleBackColor = true;
            this.radioButton_FileSendPattern.CheckedChanged += new System.EventHandler(this.radioButton_FileSendPattern_CheckedChanged);
            // 
            // radioButton_QueueSendPattern
            // 
            resources.ApplyResources(this.radioButton_QueueSendPattern, "radioButton_QueueSendPattern");
            this.radioButton_QueueSendPattern.FlatAppearance.BorderSize = 0;
            this.radioButton_QueueSendPattern.Name = "radioButton_QueueSendPattern";
            this.radioButton_QueueSendPattern.TabStop = true;
            this.radioButton_QueueSendPattern.UseVisualStyleBackColor = true;
            // 
            // radioButton_CommonSendPattern
            // 
            resources.ApplyResources(this.radioButton_CommonSendPattern, "radioButton_CommonSendPattern");
            this.radioButton_CommonSendPattern.Checked = true;
            this.radioButton_CommonSendPattern.FlatAppearance.BorderSize = 0;
            this.radioButton_CommonSendPattern.Name = "radioButton_CommonSendPattern";
            this.radioButton_CommonSendPattern.TabStop = true;
            this.radioButton_CommonSendPattern.UseVisualStyleBackColor = true;
            this.radioButton_CommonSendPattern.CheckedChanged += new System.EventHandler(this.radioButton_CommonSendPattern_CheckedChanged);
            // 
            // groupBox_Configuration
            // 
            this.groupBox_Configuration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_Configuration.Controls.Add(this.button_Memory);
            this.groupBox_Configuration.Controls.Add(this.pictureBox_Connection);
            this.groupBox_Configuration.Controls.Add(this.button_Reset);
            this.groupBox_Configuration.Controls.Add(this.comboBox_StopBit);
            this.groupBox_Configuration.Controls.Add(this.label_StopBit);
            this.groupBox_Configuration.Controls.Add(this.comboBox_DataBit);
            this.groupBox_Configuration.Controls.Add(this.label_DataBit);
            this.groupBox_Configuration.Controls.Add(this.comboBox_ParityBit);
            this.groupBox_Configuration.Controls.Add(this.label_ParityBit);
            this.groupBox_Configuration.Controls.Add(this.button_Connection);
            this.groupBox_Configuration.Controls.Add(this.comboBox_BaudRate);
            this.groupBox_Configuration.Controls.Add(this.label_BaudRate);
            this.groupBox_Configuration.Controls.Add(this.comboBox_SerialPort);
            this.groupBox_Configuration.Controls.Add(this.label_SerialPort);
            resources.ApplyResources(this.groupBox_Configuration, "groupBox_Configuration");
            this.groupBox_Configuration.Name = "groupBox_Configuration";
            this.groupBox_Configuration.TabStop = false;
            // 
            // button_Memory
            // 
            resources.ApplyResources(this.button_Memory, "button_Memory");
            this.button_Memory.Name = "button_Memory";
            this.button_Memory.UseVisualStyleBackColor = true;
            this.button_Memory.Click += new System.EventHandler(this.button_Memory_Click);
            // 
            // pictureBox_Connection
            // 
            this.pictureBox_Connection.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.breakoff_BurnSN;
            resources.ApplyResources(this.pictureBox_Connection, "pictureBox_Connection");
            this.pictureBox_Connection.Name = "pictureBox_Connection";
            this.pictureBox_Connection.TabStop = false;
            // 
            // button_Reset
            // 
            resources.ApplyResources(this.button_Reset, "button_Reset");
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // comboBox_StopBit
            // 
            this.comboBox_StopBit.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_StopBit, "comboBox_StopBit");
            this.comboBox_StopBit.Name = "comboBox_StopBit";
            // 
            // label_StopBit
            // 
            resources.ApplyResources(this.label_StopBit, "label_StopBit");
            this.label_StopBit.Name = "label_StopBit";
            // 
            // comboBox_DataBit
            // 
            this.comboBox_DataBit.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_DataBit, "comboBox_DataBit");
            this.comboBox_DataBit.Name = "comboBox_DataBit";
            // 
            // label_DataBit
            // 
            resources.ApplyResources(this.label_DataBit, "label_DataBit");
            this.label_DataBit.Name = "label_DataBit";
            // 
            // comboBox_ParityBit
            // 
            this.comboBox_ParityBit.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_ParityBit, "comboBox_ParityBit");
            this.comboBox_ParityBit.Name = "comboBox_ParityBit";
            // 
            // label_ParityBit
            // 
            resources.ApplyResources(this.label_ParityBit, "label_ParityBit");
            this.label_ParityBit.Name = "label_ParityBit";
            // 
            // button_Connection
            // 
            this.button_Connection.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.button_Connection, "button_Connection");
            this.button_Connection.FlatAppearance.BorderSize = 0;
            this.button_Connection.ForeColor = System.Drawing.Color.White;
            this.button_Connection.Name = "button_Connection";
            this.button_Connection.UseVisualStyleBackColor = false;
            this.button_Connection.Click += new System.EventHandler(this.button_Connection_Click);
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_BaudRate, "comboBox_BaudRate");
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            // 
            // label_BaudRate
            // 
            resources.ApplyResources(this.label_BaudRate, "label_BaudRate");
            this.label_BaudRate.Name = "label_BaudRate";
            // 
            // comboBox_SerialPort
            // 
            this.comboBox_SerialPort.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_SerialPort, "comboBox_SerialPort");
            this.comboBox_SerialPort.Name = "comboBox_SerialPort";
            // 
            // label_SerialPort
            // 
            resources.ApplyResources(this.label_SerialPort, "label_SerialPort");
            this.label_SerialPort.Name = "label_SerialPort";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 9600;
            this.serialPort.DataBits = 8;
            this.serialPort.DiscardNull = false;
            this.serialPort.DtrEnable = false;
            this.serialPort.Handshake = System.IO.Ports.Handshake.None;
            this.serialPort.NewLine = "\n";
            this.serialPort.Parity = System.IO.Ports.Parity.None;
            this.serialPort.ParityReplace = ((byte)(63));
            this.serialPort.PortName = "COM1";
            this.serialPort.ReadBufferSize = 4096;
            this.serialPort.ReadTimeout = -1;
            this.serialPort.ReceivedBytesThreshold = 1;
            this.serialPort.RtsEnable = false;
            this.serialPort.StopBits = System.IO.Ports.StopBits.One;
            this.serialPort.WriteBufferSize = 2048;
            this.serialPort.WriteTimeout = -1;
            // 
            // Burn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_Setting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Burn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BurnSNAndPSK_FormClosed);
            this.Load += new System.EventHandler(this.Burn_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_DeviceLog.ResumeLayout(false);
            this.panel_Setting.ResumeLayout(false);
            this.groupBox_SendSetting.ResumeLayout(false);
            this.groupBox_SendSetting.PerformLayout();
            this.groupBox_Configuration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Connection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region  Custom
        public enum SendModeType : int
        {
            Normal = 0,
            File,
            Queue
        }

        public enum BurnState : int
        {
            Disable = 0,
            Enable = 1,
        }

        public enum PortalState : int
        {
            Close = 0,
            Open = 1
        }

        private Context currentContext = new Context();
        public Context CurrentContext
        {
            get
            {
                if (serialPort.IsOpen)
                {
                    currentContext.PortalState = PortalState.Open;
                }
                else
                {
                    currentContext.PortalState = PortalState.Close;
                }

                if (radioButton_CommonSendPattern.Checked)
                {
                    currentContext.SendModeType = SendModeType.Normal;
                }
                else if (radioButton_FileSendPattern.Checked)
                {
                    currentContext.SendModeType = SendModeType.File;
                }

                if (button_BurnDown.Enabled)
                {
                    currentContext.BurnState = BurnState.Enable;
                }
                else
                {
                    currentContext.BurnState = BurnState.Disable;
                }

                return currentContext;
            }
            set
            {
                currentContext = value;
            }
        }

        public class Context
        {
            public SendModeType SendModeType { get; set; }
            public BurnState BurnState { get; set; }
            public PortalState PortalState { get; set; }
        }
        #endregion

        #region init
        private void Init()
        {

            BandDingSerialPort();
            BandDingBaudRate();
            BandDingParityBit();
            BandDingDataBit();
            BandDingStopBit();
            SetDefault();
            BuildChildFrom();
            SetSendAreaTitle();

            if (customMessageBoxDialogResult.ModeEnum == ModeEnum.NormalMode)
            {
                radioButton_CommonSendPattern.Checked = true;
                radioButton_FileSendPattern.Checked = false;
                this.label1.Text = radioButton_CommonSendPattern.Text;
                AddChildForm(formNormal);
            }
            else if (customMessageBoxDialogResult.ModeEnum == ModeEnum.DGWMode)
            {
                radioButton_CommonSendPattern.Checked = false;
                radioButton_FileSendPattern.Checked = true;
                this.label1.Text = radioButton_FileSendPattern.Text;
                AddChildForm(formFileSend);
            }

            radioButton_FileSendPattern.Enabled = false;
            radioButton_CommonSendPattern.Enabled = false;
        }

        private void BuildChildFrom()
        {
            this.formNormal = new FormNormal();
            this.formNormal.textBox_SerialNumber.KeyPress += new KeyPressEventHandler(this.textBox_SerialNumber_KeyPress);
            this.formNormal.textBox_SerialNumber.TextChanged += new EventHandler(this.textBox_SerialNumber_TextChanged);
            this.formNormal.checkBox_ValidateSN.CheckedChanged += new EventHandler(this.checkBox_ValidateSN_CheckedChanged);
            this.formNormal.checkBox_EnableMappingPrefix.CheckedChanged += new EventHandler(this.checkBox_EnableMappingPrefix_Click);
            this.formNormal.Hide();

            this.formFileSend = new FormFileSend(customMessageBoxDialogResult);
            this.formFileSend.textBox_SerialNumber.KeyPress += new KeyPressEventHandler(this.formFileSend_textBox_SerialNumber_KeyPress);
            this.formFileSend.textBox_SerialNumber.TextChanged += new EventHandler(this.formFileSend_textBox_SerialNumber_TextChanged);
            this.formFileSend.checkBox_ValidateSN.CheckedChanged += new EventHandler(this.formFileSend_checkBox_ValidateSN_CheckedChanged);
            this.formFileSend.checkBox_EnableMappingPrefix.CheckedChanged += new EventHandler(this.formFileSend_checkBox_EnableMappingPrefix_Click);
            this.formFileSend.Hide();
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
            comboBox_DataBit.SelectedItem = ((int)setting.DataBit).ToString();
            comboBox_StopBit.SelectedItem = setting.StopBit.ToStopBitName();
        }

        private void SetSendAreaTitle()
        {
            var groupBoxSendText = res.GetString("groupBox_Send.Text");
            var modeType = res.GetString("radioButton_CommonSendPattern.Text");
            this.groupBox_Send.Text = $"{groupBoxSendText}   {modeType}";
            if (customMessageBoxDialogResult.ModeEnum == ModeEnum.DGWMode)
            {
                var transportProtocol = res.GetString("label_TransportProtocol");
                var modeName = res.GetString("label_ModeName");
                var version = res.GetString("label_Version");
                modeType = res.GetString("radioButton_FileSendPattern.Text");
                this.groupBox_Send.Text = $"{groupBoxSendText}   {modeType}    {transportProtocol} : {customMessageBoxDialogResult?.TransportProtocol}  |  CRC : {customMessageBoxDialogResult?.IsCRC}  |  {modeName} : {customMessageBoxDialogResult?.DGWModeConfig?.ModeName}  |  {version} : {customMessageBoxDialogResult?.DGWModeConfig?.Version}";
            }
        }
        #endregion

        #region FormNormal_Validate
        private bool Form_ValidateSN(string sn)
        {
            var bl = true;
            if (CurrentContext.SendModeType == SendModeType.Normal)
            {
                bl= FormNormal_ValidateSN(sn);
                GeneratePrefix();
            }
            else if (CurrentContext.SendModeType == SendModeType.File)
            {
                bl= FormSendFile_ValidateSN(sn);
            }
           
            DisableOrEnableBurnDownButton();
            return bl;
        }

        private bool FormNormal_ValidateSN(string sn)
        {
            var bl = true;
            if (!formNormal.checkBox_ValidateSN.Checked)
            {
                formNormal.label_SerualNubmer_Validate.Text = "";
                bl = true;

            }
            else if ( string.IsNullOrEmpty(sn))
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

            return bl;
        }

        private bool FormSendFile_ValidateSN(string sn)
        {
            var bl = true;
            if (!formFileSend.checkBox_ValidateSN.Checked)
            {
                formFileSend.label_SerualNubmer_Validate.Text = "";
                bl = true;

            }
            else if (string.IsNullOrEmpty(sn))
            {
                formFileSend.label_SerualNubmer_Validate.Text = "SN is Empty, pls input SN";
                bl = false;
            }
            else if (!Utilities.ValidateSN(sn, out string message))
            {
                formFileSend.label_SerualNubmer_Validate.Text = $"SN format is incorrect.\r\n{message}";
                bl = false;
            }
            else
            {
                formFileSend.label_SerualNubmer_Validate.Text = "";
            }

            return bl;
        }

        private void GeneratePrefix()
        {
            var sn = formNormal.textBox_SerialNumber.Text;
            if (string.IsNullOrEmpty(sn))
            {
                formNormal.label_SNPrefix.Text = "";
                return;
            }
            if (sn.Length >= 3)
            {
                var prefix = sn.Substring(0, 3);
                prefix = CallerContext.ECOLABIOTDeviceTypeService.GetDeviceTypeMapping().GetDeviceTypePrefix(prefix, formNormal.checkBox_EnableMappingPrefix.Checked);
                formNormal.label_SNPrefix.Text = prefix;
            }
        }
        #endregion
        #region FormFileSend_ValidateFile

        private bool FormFileSend_ValidateFile(string filePath)
        {
            var bl = true;

            //if (string.IsNullOrEmpty(filePath))
            //{
            //    formFileSend.label_ChooseFile_Validate.Text = "FilePath is Empty, pls input or choose file";
            //    bl = false;
            //}
            //else if (!File.Exists(Path.GetFullPath(filePath)))
            //{
            //    formFileSend.label_ChooseFile_Validate.Text = $"FilePath format is incorrect, or the related file doesn't exist.";
            //    bl = false;
            //}
            //else
            //{
            //    formFileSend.label_ChooseFile_Validate.Text = "";
            //}

            DisableOrEnableBurnDownButton();
            return bl;
        }

        private bool FormFileSend_ValidateChooseFile(string filePath)
        {
            var bl = true;

            //if (string.IsNullOrEmpty(filePath))
            //{
            //    formFileSend.label_ChooseFile_Validate.Text = "FilePath is Empty, pls input or choose file";
            //    bl = false;
            //}
            //else if (!File.Exists(Path.GetFullPath(filePath)))
            //{
            //    formFileSend.label_ChooseFile_Validate.Text = $"FilePath format is incorrect, or the related file doesn't exist.";
            //    bl = false;
            //}
            //else
            //{
            //    formFileSend.label_ChooseFile_Validate.Text = "";
            //}
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                return false;
            }

            DisableOrEnableBurnDownButton();
            return bl;
        }

        #endregion

        #region Burn Validate
        private bool BurnDown_Validate()
        {
            if (Form_ValidateSN(formNormal.textBox_SerialNumber.Text))
            {
                return false;
            }
            return true;
        }

        private void EnableOrDisableSetting(bool bl = false)
        {
            comboBox_SerialPort.Enabled = bl;
            comboBox_BaudRate.Enabled = bl;
            comboBox_ParityBit.Enabled = bl;
            comboBox_DataBit.Enabled = bl;
            comboBox_StopBit.Enabled = bl;
            button_Reset.Enabled = bl;
            button_Memory.Enabled = bl;
        }
        private void DisableOrEnableBurnDownButton()
        {
            if (CurrentContext.PortalState == PortalState.Open
                && (
                    (CurrentContext.SendModeType == SendModeType.Normal
                    && string.IsNullOrEmpty(formNormal.label_SerualNubmer_Validate.Text)
                    && !string.IsNullOrEmpty(formNormal.textBox_SerialNumber.Text))
                    ||
                    (CurrentContext.SendModeType == SendModeType.File
                    && string.IsNullOrEmpty(formFileSend.label_SerualNubmer_Validate.Text)
                    && !string.IsNullOrEmpty(formFileSend.textBox_SerialNumber.Text)
                    && (formFileSend.textBox_SerialNumber.Text.Length==12|| !formFileSend.checkBox_ValidateSN.Checked)
                    && !string.IsNullOrEmpty(customMessageBoxDialogResult.DGWModeConfig.ModeName)
                    && !string.IsNullOrEmpty(customMessageBoxDialogResult.DGWModeConfig.Version)
                    )
                   )
               )
            {
                button_BurnDown.BackColor = Color.FromArgb(0, 192, 0);
                button_BurnDown.Enabled = true;
            }
            else
            {
                button_BurnDown.BackColor = SystemColors.AppWorkspace;
                button_BurnDown.Enabled = false;
            }

        }

        private void ChangeSendStatusToDisable(KeyValuePair<bool, bool> keyValuePair)
        {
            if (keyValuePair.Value)
            {
                formNormal.textBox_SerialNumber.Enabled = false;
            }
            else
            {
                formFileSend.textBox_SerialNumber.Enabled = false;
            }
        
            button_BurnDown.BackColor = SystemColors.AppWorkspace;
            button_BurnDown.Enabled = false;
        }

        private void ChangeSendStatusToEnable(KeyValuePair<bool, bool> keyValuePair)
        {
            if (keyValuePair.Value)
            {
                formNormal.textBox_SerialNumber.Enabled = true;
            }
            else {
                formFileSend.textBox_SerialNumber.Enabled = true;
            }
            
            button_BurnDown.BackColor = Color.FromArgb(0, 192, 0);
            button_BurnDown.Enabled = true;
        }
        #endregion

        #region BingChildForm
        private Form activeForm = null;
        private Form unActionedForm = null;
        private void AddChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                unActionedForm = activeForm;
                unActionedForm.Hide();
            }
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

        private GroupBox groupBox_DeviceLog;
        private RichTextBox richTextBox_Output;
        private SplitContainer splitContainer1;
        private Panel panel_Setting;
        private GroupBox groupBox_Configuration;
        private PictureBox pictureBox_Connection;
        private Button button_Reset;
        private ComboBox comboBox_StopBit;
        private Label label_StopBit;
        private ComboBox comboBox_DataBit;
        private Label label_DataBit;
        private ComboBox comboBox_ParityBit;
        private Label label_ParityBit;
        private Button button_Connection;
        private ComboBox comboBox_BaudRate;
        private Label label_BaudRate;
        private ComboBox comboBox_SerialPort;
        private Label label_SerialPort;
        private GroupBox groupBox_SendSetting;
        private RadioButton radioButton_FileSendPattern;
        private RadioButton radioButton_QueueSendPattern;
        private RadioButton radioButton_CommonSendPattern;
        private Button button_BurnDown;
        private GroupBox groupBox_Send;
        private FormNormal formNormal;
        private FormFileSend formFileSend;
        private SerialPort serialPort = null;
        private Button button_Memory;
        private Label label1;
    }
}