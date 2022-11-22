namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    partial class FormFileSend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileSend));
            this.comboBox_TransportProtocol = new System.Windows.Forms.ComboBox();
            this.label_TransportProtocol = new System.Windows.Forms.Label();
            this.checkBox_isCRC = new System.Windows.Forms.CheckBox();
            this.label_ModeName = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.comboBox_ModeName = new System.Windows.Forms.ComboBox();
            this.comboBox_Version = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_TransportProtocol
            // 
            resources.ApplyResources(this.comboBox_TransportProtocol, "comboBox_TransportProtocol");
            this.comboBox_TransportProtocol.FormattingEnabled = true;
            this.comboBox_TransportProtocol.Name = "comboBox_TransportProtocol";
            // 
            // label_TransportProtocol
            // 
            resources.ApplyResources(this.label_TransportProtocol, "label_TransportProtocol");
            this.label_TransportProtocol.Name = "label_TransportProtocol";
            // 
            // checkBox_isCRC
            // 
            resources.ApplyResources(this.checkBox_isCRC, "checkBox_isCRC");
            this.checkBox_isCRC.Name = "checkBox_isCRC";
            this.checkBox_isCRC.UseVisualStyleBackColor = true;
            // 
            // label_ModeName
            // 
            resources.ApplyResources(this.label_ModeName, "label_ModeName");
            this.label_ModeName.Name = "label_ModeName";
            // 
            // label_Version
            // 
            resources.ApplyResources(this.label_Version, "label_Version");
            this.label_Version.Name = "label_Version";
            // 
            // comboBox_ModeName
            // 
            resources.ApplyResources(this.comboBox_ModeName, "comboBox_ModeName");
            this.comboBox_ModeName.FormattingEnabled = true;
            this.comboBox_ModeName.Name = "comboBox_ModeName";
            this.comboBox_ModeName.SelectedIndexChanged += new System.EventHandler(this.comboBox_ModeName_SelectedIndexChanged);
            // 
            // comboBox_Version
            // 
            resources.ApplyResources(this.comboBox_Version, "comboBox_Version");
            this.comboBox_Version.FormattingEnabled = true;
            this.comboBox_Version.Name = "comboBox_Version";
            // 
            // FormFileSend
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.checkBox_isCRC);
            this.Controls.Add(this.label_Version);
            this.Controls.Add(this.label_ModeName);
            this.Controls.Add(this.comboBox_Version);
            this.Controls.Add(this.comboBox_ModeName);
            this.Controls.Add(this.label_TransportProtocol);
            this.Controls.Add(this.comboBox_TransportProtocol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFileSend";
            this.Load += new System.EventHandler(this.FormFileSend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ComboBox comboBox_TransportProtocol;
        public Label label_TransportProtocol;
        public CheckBox checkBox_isCRC;
        public Label label_ModeName;
        public Label label_Version;
        public ComboBox comboBox_ModeName;
        public ComboBox comboBox_Version;
    }
}