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
            this.groupBox_DeviceLog = new System.Windows.Forms.GroupBox();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_Send = new System.Windows.Forms.GroupBox();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.groupBox_SendSetting = new System.Windows.Forms.GroupBox();
            this.button_BurnDown = new System.Windows.Forms.Button();
            this.radioButton_FileSendPattern = new System.Windows.Forms.RadioButton();
            this.radioButton_QueueSendPattern = new System.Windows.Forms.RadioButton();
            this.radioButton_CommonSendPattern = new System.Windows.Forms.RadioButton();
            this.groupBox_Configuration = new System.Windows.Forms.GroupBox();
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
            this.groupBox_DeviceLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_Setting.SuspendLayout();
            this.groupBox_SendSetting.SuspendLayout();
            this.groupBox_Configuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Connection)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_DeviceLog
            // 
            this.groupBox_DeviceLog.Controls.Add(this.richTextBox_Output);
            this.groupBox_DeviceLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_DeviceLog.Location = new System.Drawing.Point(0, 0);
            this.groupBox_DeviceLog.Name = "groupBox_DeviceLog";
            this.groupBox_DeviceLog.Size = new System.Drawing.Size(972, 531);
            this.groupBox_DeviceLog.TabIndex = 0;
            this.groupBox_DeviceLog.TabStop = false;
            this.groupBox_DeviceLog.Text = "Device Log";
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Output.Location = new System.Drawing.Point(3, 26);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.Size = new System.Drawing.Size(966, 502);
            this.richTextBox_Output.TabIndex = 14;
            this.richTextBox_Output.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(417, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_DeviceLog);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_Send);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(972, 726);
            this.splitContainer1.SplitterDistance = 531;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox_Send
            // 
            this.groupBox_Send.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Send.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Send.Name = "groupBox_Send";
            this.groupBox_Send.Size = new System.Drawing.Size(972, 191);
            this.groupBox_Send.TabIndex = 0;
            this.groupBox_Send.TabStop = false;
            this.groupBox_Send.Text = "Send Area";
            // 
            // panel_Setting
            // 
            this.panel_Setting.Controls.Add(this.groupBox_SendSetting);
            this.panel_Setting.Controls.Add(this.groupBox_Configuration);
            this.panel_Setting.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Setting.Location = new System.Drawing.Point(0, 0);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Size = new System.Drawing.Size(417, 726);
            this.panel_Setting.TabIndex = 2;
            // 
            // groupBox_SendSetting
            // 
            this.groupBox_SendSetting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_SendSetting.Controls.Add(this.button_BurnDown);
            this.groupBox_SendSetting.Controls.Add(this.radioButton_FileSendPattern);
            this.groupBox_SendSetting.Controls.Add(this.radioButton_QueueSendPattern);
            this.groupBox_SendSetting.Controls.Add(this.radioButton_CommonSendPattern);
            this.groupBox_SendSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_SendSetting.Location = new System.Drawing.Point(0, 430);
            this.groupBox_SendSetting.Name = "groupBox_SendSetting";
            this.groupBox_SendSetting.Size = new System.Drawing.Size(417, 296);
            this.groupBox_SendSetting.TabIndex = 2;
            this.groupBox_SendSetting.TabStop = false;
            this.groupBox_SendSetting.Text = "SendSetting";
            // 
            // button_GeneratePSK
            // 
            this.button_BurnDown.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_BurnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_BurnDown.Enabled = false;
            this.button_BurnDown.FlatAppearance.BorderSize = 0;
            this.button_BurnDown.ForeColor = System.Drawing.Color.White;
            this.button_BurnDown.Location = new System.Drawing.Point(55, 202);
            this.button_BurnDown.Name = "button_GeneratePSK";
            this.button_BurnDown.Size = new System.Drawing.Size(297, 51);
            this.button_BurnDown.TabIndex = 12;
            this.button_BurnDown.Text = "BurnDown";
            this.button_BurnDown.UseVisualStyleBackColor = false;
            this.button_BurnDown.Click += new System.EventHandler(this.button_BurnDown_Click);
            // 
            // radioButton_FileSendPattern
            // 
            this.radioButton_FileSendPattern.AutoSize = true;
            this.radioButton_FileSendPattern.FlatAppearance.BorderSize = 0;
            this.radioButton_FileSendPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_FileSendPattern.Location = new System.Drawing.Point(103, 93);
            this.radioButton_FileSendPattern.Name = "radioButton_FileSendPattern";
            this.radioButton_FileSendPattern.Size = new System.Drawing.Size(169, 28);
            this.radioButton_FileSendPattern.TabIndex = 2;
            this.radioButton_FileSendPattern.TabStop = true;
            this.radioButton_FileSendPattern.Text = "FileSendPattern";
            this.radioButton_FileSendPattern.UseVisualStyleBackColor = true;
            this.radioButton_FileSendPattern.CheckedChanged += new System.EventHandler(this.radioButton_FileSendPattern_CheckedChanged);
            // 
            // radioButton_QueueSendPattern
            // 
            this.radioButton_QueueSendPattern.AutoSize = true;
            this.radioButton_QueueSendPattern.FlatAppearance.BorderSize = 0;
            this.radioButton_QueueSendPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_QueueSendPattern.Location = new System.Drawing.Point(103, 139);
            this.radioButton_QueueSendPattern.Name = "radioButton_QueueSendPattern";
            this.radioButton_QueueSendPattern.Size = new System.Drawing.Size(196, 28);
            this.radioButton_QueueSendPattern.TabIndex = 1;
            this.radioButton_QueueSendPattern.TabStop = true;
            this.radioButton_QueueSendPattern.Text = "QueueSendPattern";
            this.radioButton_QueueSendPattern.UseVisualStyleBackColor = true;
            this.radioButton_QueueSendPattern.Visible = false;
            // 
            // radioButton_CommonSendPattern
            // 
            this.radioButton_CommonSendPattern.AutoSize = true;
            this.radioButton_CommonSendPattern.Checked = true;
            this.radioButton_CommonSendPattern.FlatAppearance.BorderSize = 0;
            this.radioButton_CommonSendPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_CommonSendPattern.Location = new System.Drawing.Point(103, 48);
            this.radioButton_CommonSendPattern.Name = "radioButton_CommonSendPattern";
            this.radioButton_CommonSendPattern.Size = new System.Drawing.Size(218, 28);
            this.radioButton_CommonSendPattern.TabIndex = 0;
            this.radioButton_CommonSendPattern.TabStop = true;
            this.radioButton_CommonSendPattern.Text = "CommonSendPattern";
            this.radioButton_CommonSendPattern.UseVisualStyleBackColor = true;
            this.radioButton_CommonSendPattern.CheckedChanged += new System.EventHandler(this.radioButton_CommonSendPattern_CheckedChanged);
            // 
            // groupBox_Configuration
            // 
            this.groupBox_Configuration.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.groupBox_Configuration.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Configuration.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Configuration.Name = "groupBox_Configuration";
            this.groupBox_Configuration.Size = new System.Drawing.Size(417, 430);
            this.groupBox_Configuration.TabIndex = 1;
            this.groupBox_Configuration.TabStop = false;
            this.groupBox_Configuration.Text = "COMSettings";
            // 
            // pictureBox_Connection
            // 
            this.pictureBox_Connection.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.breakoff_BurnSN;
            this.pictureBox_Connection.Location = new System.Drawing.Point(73, 342);
            this.pictureBox_Connection.Name = "pictureBox_Connection";
            this.pictureBox_Connection.Size = new System.Drawing.Size(65, 49);
            this.pictureBox_Connection.TabIndex = 20;
            this.pictureBox_Connection.TabStop = false;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(77, 278);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(281, 34);
            this.button_Reset.TabIndex = 19;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // comboBox_StopBit
            // 
            this.comboBox_StopBit.FormattingEnabled = true;
            this.comboBox_StopBit.Location = new System.Drawing.Point(176, 225);
            this.comboBox_StopBit.Name = "comboBox_StopBit";
            this.comboBox_StopBit.Size = new System.Drawing.Size(182, 32);
            this.comboBox_StopBit.TabIndex = 18;
            // 
            // label_StopBit
            // 
            this.label_StopBit.AutoSize = true;
            this.label_StopBit.Location = new System.Drawing.Point(77, 228);
            this.label_StopBit.Name = "label_StopBit";
            this.label_StopBit.Size = new System.Drawing.Size(82, 24);
            this.label_StopBit.TabIndex = 17;
            this.label_StopBit.Text = "Stop Bit:";
            // 
            // comboBox_DataBit
            // 
            this.comboBox_DataBit.FormattingEnabled = true;
            this.comboBox_DataBit.Location = new System.Drawing.Point(176, 181);
            this.comboBox_DataBit.Name = "comboBox_DataBit";
            this.comboBox_DataBit.Size = new System.Drawing.Size(182, 32);
            this.comboBox_DataBit.TabIndex = 16;
            // 
            // label_DataBit
            // 
            this.label_DataBit.AutoSize = true;
            this.label_DataBit.Location = new System.Drawing.Point(75, 184);
            this.label_DataBit.Name = "label_DataBit";
            this.label_DataBit.Size = new System.Drawing.Size(83, 24);
            this.label_DataBit.TabIndex = 15;
            this.label_DataBit.Text = "Data Bit:";
            // 
            // comboBox_ParityBit
            // 
            this.comboBox_ParityBit.FormattingEnabled = true;
            this.comboBox_ParityBit.Location = new System.Drawing.Point(176, 139);
            this.comboBox_ParityBit.Name = "comboBox_ParityBit";
            this.comboBox_ParityBit.Size = new System.Drawing.Size(182, 32);
            this.comboBox_ParityBit.TabIndex = 14;
            // 
            // label_ParityBit
            // 
            this.label_ParityBit.AutoSize = true;
            this.label_ParityBit.Location = new System.Drawing.Point(66, 142);
            this.label_ParityBit.Name = "label_ParityBit";
            this.label_ParityBit.Size = new System.Drawing.Size(92, 24);
            this.label_ParityBit.TabIndex = 13;
            this.label_ParityBit.Text = "Parity Bit:";
            // 
            // button_Connection
            // 
            this.button_Connection.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Connection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Connection.FlatAppearance.BorderSize = 0;
            this.button_Connection.ForeColor = System.Drawing.Color.White;
            this.button_Connection.Location = new System.Drawing.Point(176, 342);
            this.button_Connection.Name = "button_Connection";
            this.button_Connection.Size = new System.Drawing.Size(182, 49);
            this.button_Connection.TabIndex = 12;
            this.button_Connection.Text = "Connection";
            this.button_Connection.UseVisualStyleBackColor = false;
            this.button_Connection.Click += new System.EventHandler(this.button_Connection_Click);
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Location = new System.Drawing.Point(176, 98);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(182, 32);
            this.comboBox_BaudRate.TabIndex = 5;
            // 
            // label_BaudRate
            // 
            this.label_BaudRate.AutoSize = true;
            this.label_BaudRate.Location = new System.Drawing.Point(56, 101);
            this.label_BaudRate.Name = "label_BaudRate";
            this.label_BaudRate.Size = new System.Drawing.Size(102, 24);
            this.label_BaudRate.TabIndex = 4;
            this.label_BaudRate.Text = "Baud Rate:";
            // 
            // comboBox_SerialPort
            // 
            this.comboBox_SerialPort.FormattingEnabled = true;
            this.comboBox_SerialPort.Location = new System.Drawing.Point(176, 51);
            this.comboBox_SerialPort.Name = "comboBox_SerialPort";
            this.comboBox_SerialPort.Size = new System.Drawing.Size(182, 32);
            this.comboBox_SerialPort.TabIndex = 3;
            // 
            // label_SerialPort
            // 
            this.label_SerialPort.AutoSize = true;
            this.label_SerialPort.Location = new System.Drawing.Point(55, 54);
            this.label_SerialPort.Name = "label_SerialPort";
            this.label_SerialPort.Size = new System.Drawing.Size(102, 24);
            this.label_SerialPort.TabIndex = 0;
            this.label_SerialPort.Text = "Serial Port:";
            // 
            // BurnSNAndPSK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 726);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_Setting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BurnSNAndPSK";
            this.Text = "BurnSNAndPSK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BurnSNAndPSK_FormClosed);
            this.Load += new System.EventHandler(this.Burn_Load);
            this.groupBox_DeviceLog.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_Setting.ResumeLayout(false);
            this.groupBox_SendSetting.ResumeLayout(false);
            this.groupBox_SendSetting.PerformLayout();
            this.groupBox_Configuration.ResumeLayout(false);
            this.groupBox_Configuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Connection)).EndInit();
            this.ResumeLayout(false);



            serialPort = new SerialPort();

            currentContext = new Context()
            {
                SendModeType = SendModeType.Normal,
                BurnState = BurnState.Disable,
                PortalState = PortalState.Close
            };

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

        private Context currentContext;
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
            set {
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
            AddChildForm(formNormal);
        }

        private void BuildChildFrom()
        {
            this.formNormal = new FormNormal();
            this.formNormal.textBox_SerialNumber.KeyPress += new KeyPressEventHandler(this.textBox_SerialNumber_KeyPress);
            this.formNormal.textBox_SerialNumber.TextChanged += new EventHandler(this.textBox_SerialNumber_TextChanged);
            this.formNormal.checkBox_ValidateSN.CheckedChanged += new EventHandler(this.checkBox_ValidateSN_CheckedChanged);
            this.formNormal.Hide();

            this.formFileSend = new FormFileSend();
            this.formFileSend.textBox_ChooseFile.KeyPress += new KeyPressEventHandler(this.textBox_ChooseFile_KeyPress);
            this.formFileSend.textBox_ChooseFile.TextChanged += new EventHandler(this.textBox_ChooseFile_TextChanged);
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
            comboBox_DataBit.SelectedItem = Enum.GetName(setting.DataBit);
            comboBox_StopBit.SelectedItem = Enum.GetName(setting.StopBit);
        }
        #endregion

        #region FormNormal_Validate
        private bool FormNormal_ValidateSN(string sn)
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

            DisableOrEnableBurnDownButton();
            return bl;
        }
        #endregion
        #region FormFileSend_ValidateFile

        private bool FormFileSend_ValidateFile(string filePath)
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

            DisableOrEnableBurnDownButton();
            return bl;
        }

        #endregion

        #region Burn Validate
        private bool BurnDown_Validate()
        {
            if (FormNormal_ValidateSN(formNormal.textBox_SerialNumber.Text))
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
        }
        private void DisableOrEnableBurnDownButton()
        {
            if (CurrentContext.PortalState==PortalState.Open
                && (
                    (CurrentContext.SendModeType == SendModeType.Normal
                    && string.IsNullOrEmpty(formNormal.label_SerualNubmer_Validate.Text)
                    && !string.IsNullOrEmpty(formNormal.textBox_SerialNumber.Text))
                    ||
                    (CurrentContext.SendModeType == SendModeType.File
                    && string.IsNullOrEmpty(formFileSend.label_ChooseFile_Validate.Text)
                    && !string.IsNullOrEmpty(formFileSend.textBox_ChooseFile.Text)
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

            //DisableOrEnableSendPattern();
        }

        private void ChangeSendStatusToDisable()
        {
            radioButton_CommonSendPattern.Enabled = false;
            radioButton_FileSendPattern.Enabled = false;
            formNormal.textBox_SerialNumber.Enabled = false;
            formFileSend.textBox_ChooseFile.Enabled = false;
            formFileSend.comboBox_TransportProtocol.Enabled = false;
            button_BurnDown.BackColor = SystemColors.AppWorkspace;
            button_BurnDown.Enabled = false;
        }
        private void ChangeSendStatusToEnable()
        {
            radioButton_CommonSendPattern.Enabled = true;
            radioButton_FileSendPattern.Enabled = true;
            formNormal.textBox_SerialNumber.Enabled = true;
            formFileSend.textBox_ChooseFile.Enabled = true;
            formFileSend.comboBox_TransportProtocol.Enabled = true;
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
    }
}