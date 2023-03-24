namespace ECOLAB.IOT.WinFormApp
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.lblTitleContent = new System.Windows.Forms.Label();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.panel_Submit = new System.Windows.Forms.Panel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.panel_ChooseFile = new System.Windows.Forms.Panel();
            this.checkBox_isCRC = new System.Windows.Forms.CheckBox();
            this.label_TransportProtocol = new System.Windows.Forms.Label();
            this.comboBox_TransportProtocol = new System.Windows.Forms.ComboBox();
            this.label_Version = new System.Windows.Forms.Label();
            this.label_ModeName = new System.Windows.Forms.Label();
            this.comboBox_Version = new System.Windows.Forms.ComboBox();
            this.comboBox_ModeName = new System.Windows.Forms.ComboBox();
            this.panel_Mode = new System.Windows.Forms.Panel();
            this.dgwMode = new System.Windows.Forms.RadioButton();
            this.normalMode = new System.Windows.Forms.RadioButton();
            this.panel_Container.SuspendLayout();
            this.panel_Submit.SuspendLayout();
            this.panel_ChooseFile.SuspendLayout();
            this.panel_Mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleContent
            // 
            this.lblTitleContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(117)))), ((int)(((byte)(151)))));
            this.lblTitleContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblTitleContent, "lblTitleContent");
            this.lblTitleContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleContent.ForeColor = System.Drawing.Color.Black;
            this.lblTitleContent.Name = "lblTitleContent";
            this.lblTitleContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.lblTitleContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // panel_Container
            // 
            this.panel_Container.Controls.Add(this.panel_Submit);
            this.panel_Container.Controls.Add(this.panel_ChooseFile);
            this.panel_Container.Controls.Add(this.panel_Mode);
            resources.ApplyResources(this.panel_Container, "panel_Container");
            this.panel_Container.Name = "panel_Container";
            // 
            // panel_Submit
            // 
            this.panel_Submit.Controls.Add(this.button_Cancel);
            this.panel_Submit.Controls.Add(this.button_Confirm);
            resources.ApplyResources(this.panel_Submit, "panel_Submit");
            this.panel_Submit.Name = "panel_Submit";
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(117)))), ((int)(((byte)(151)))));
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(117)))), ((int)(((byte)(151)))));
            this.button_Confirm.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Confirm, "button_Confirm");
            this.button_Confirm.ForeColor = System.Drawing.Color.Black;
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.UseVisualStyleBackColor = false;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // panel_ChooseFile
            // 
            this.panel_ChooseFile.Controls.Add(this.checkBox_isCRC);
            this.panel_ChooseFile.Controls.Add(this.label_TransportProtocol);
            this.panel_ChooseFile.Controls.Add(this.comboBox_TransportProtocol);
            this.panel_ChooseFile.Controls.Add(this.label_Version);
            this.panel_ChooseFile.Controls.Add(this.label_ModeName);
            this.panel_ChooseFile.Controls.Add(this.comboBox_Version);
            this.panel_ChooseFile.Controls.Add(this.comboBox_ModeName);
            resources.ApplyResources(this.panel_ChooseFile, "panel_ChooseFile");
            this.panel_ChooseFile.ForeColor = System.Drawing.Color.Black;
            this.panel_ChooseFile.Name = "panel_ChooseFile";
            // 
            // checkBox_isCRC
            // 
            resources.ApplyResources(this.checkBox_isCRC, "checkBox_isCRC");
            this.checkBox_isCRC.Checked = true;
            this.checkBox_isCRC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_isCRC.ForeColor = System.Drawing.Color.Black;
            this.checkBox_isCRC.Name = "checkBox_isCRC";
            this.checkBox_isCRC.UseVisualStyleBackColor = true;
            // 
            // label_TransportProtocol
            // 
            this.label_TransportProtocol.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.label_TransportProtocol, "label_TransportProtocol");
            this.label_TransportProtocol.Name = "label_TransportProtocol";
            // 
            // comboBox_TransportProtocol
            // 
            resources.ApplyResources(this.comboBox_TransportProtocol, "comboBox_TransportProtocol");
            this.comboBox_TransportProtocol.FormattingEnabled = true;
            this.comboBox_TransportProtocol.Name = "comboBox_TransportProtocol";
            // 
            // label_Version
            // 
            this.label_Version.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.label_Version, "label_Version");
            this.label_Version.Name = "label_Version";
            // 
            // label_ModeName
            // 
            this.label_ModeName.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.label_ModeName, "label_ModeName");
            this.label_ModeName.Name = "label_ModeName";
            // 
            // comboBox_Version
            // 
            resources.ApplyResources(this.comboBox_Version, "comboBox_Version");
            this.comboBox_Version.FormattingEnabled = true;
            this.comboBox_Version.Name = "comboBox_Version";
            // 
            // comboBox_ModeName
            // 
            resources.ApplyResources(this.comboBox_ModeName, "comboBox_ModeName");
            this.comboBox_ModeName.FormattingEnabled = true;
            this.comboBox_ModeName.Name = "comboBox_ModeName";
            // 
            // panel_Mode
            // 
            this.panel_Mode.Controls.Add(this.dgwMode);
            this.panel_Mode.Controls.Add(this.normalMode);
            resources.ApplyResources(this.panel_Mode, "panel_Mode");
            this.panel_Mode.Name = "panel_Mode";
            // 
            // dgwMode
            // 
            resources.ApplyResources(this.dgwMode, "dgwMode");
            this.dgwMode.ForeColor = System.Drawing.Color.Black;
            this.dgwMode.Name = "dgwMode";
            this.dgwMode.TabStop = true;
            this.dgwMode.UseVisualStyleBackColor = true;
            this.dgwMode.Click += new System.EventHandler(this.dgwMode_Click);
            // 
            // normalMode
            // 
            resources.ApplyResources(this.normalMode, "normalMode");
            this.normalMode.Checked = true;
            this.normalMode.ForeColor = System.Drawing.Color.Black;
            this.normalMode.Name = "normalMode";
            this.normalMode.TabStop = true;
            this.normalMode.UseVisualStyleBackColor = true;
            this.normalMode.Click += new System.EventHandler(this.normalMode_Click);
            // 
            // CustomMessageBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.lblTitleContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.panel_Container.ResumeLayout(false);
            this.panel_Submit.ResumeLayout(false);
            this.panel_ChooseFile.ResumeLayout(false);
            this.panel_ChooseFile.PerformLayout();
            this.panel_Mode.ResumeLayout(false);
            this.panel_Mode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitleContent;
        private Panel panel_Container;
        private Panel panel_ChooseFile;
        public Label label_Version;
        public Label label_ModeName;
        public ComboBox comboBox_Version;
        public ComboBox comboBox_ModeName;
        private Panel panel_Mode;
        private RadioButton dgwMode;
        private RadioButton normalMode;
        private Panel panel_Submit;
        private Button button_Cancel;
        private Button button_Confirm;
        public CheckBox checkBox_isCRC;
        public Label label_TransportProtocol;
        public ComboBox comboBox_TransportProtocol;
    }
}