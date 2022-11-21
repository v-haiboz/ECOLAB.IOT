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
            this.label_ChooseFile = new System.Windows.Forms.Label();
            this.textBox_ChooseFile = new System.Windows.Forms.TextBox();
            this.button_ChooseFile = new System.Windows.Forms.Button();
            this.comboBox_TransportProtocol = new System.Windows.Forms.ComboBox();
            this.label_TransportProtocol = new System.Windows.Forms.Label();
            this.label_ChooseFile_Validate = new System.Windows.Forms.Label();
            this.checkBox_isCRC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_ChooseFile
            // 
            resources.ApplyResources(this.label_ChooseFile, "label_ChooseFile");
            this.label_ChooseFile.Name = "label_ChooseFile";
            // 
            // textBox_ChooseFile
            // 
            this.textBox_ChooseFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_ChooseFile, "textBox_ChooseFile");
            this.textBox_ChooseFile.Name = "textBox_ChooseFile";
            // 
            // button_ChooseFile
            // 
            this.button_ChooseFile.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_ChooseFile.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_ChooseFile, "button_ChooseFile");
            this.button_ChooseFile.ForeColor = System.Drawing.Color.White;
            this.button_ChooseFile.Name = "button_ChooseFile";
            this.button_ChooseFile.UseVisualStyleBackColor = false;
            this.button_ChooseFile.Click += new System.EventHandler(this.button_ChooseFile_Click);
            // 
            // comboBox_TransportProtocol
            // 
            this.comboBox_TransportProtocol.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_TransportProtocol, "comboBox_TransportProtocol");
            this.comboBox_TransportProtocol.Name = "comboBox_TransportProtocol";
            // 
            // label_TransportProtocol
            // 
            resources.ApplyResources(this.label_TransportProtocol, "label_TransportProtocol");
            this.label_TransportProtocol.Name = "label_TransportProtocol";
            // 
            // label_ChooseFile_Validate
            // 
            resources.ApplyResources(this.label_ChooseFile_Validate, "label_ChooseFile_Validate");
            this.label_ChooseFile_Validate.ForeColor = System.Drawing.Color.Red;
            this.label_ChooseFile_Validate.Name = "label_ChooseFile_Validate";
            // 
            // checkBox_isCRC
            // 
            resources.ApplyResources(this.checkBox_isCRC, "checkBox_isCRC");
            this.checkBox_isCRC.Name = "checkBox_isCRC";
            this.checkBox_isCRC.UseVisualStyleBackColor = true;
            // 
            // FormFileSend
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.checkBox_isCRC);
            this.Controls.Add(this.label_ChooseFile_Validate);
            this.Controls.Add(this.label_TransportProtocol);
            this.Controls.Add(this.comboBox_TransportProtocol);
            this.Controls.Add(this.button_ChooseFile);
            this.Controls.Add(this.textBox_ChooseFile);
            this.Controls.Add(this.label_ChooseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFileSend";
            this.Load += new System.EventHandler(this.FormFileSend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label label_ChooseFile;
        public TextBox textBox_ChooseFile;
        public Button button_ChooseFile;
        public ComboBox comboBox_TransportProtocol;
        public Label label_TransportProtocol;
        public Label label_ChooseFile_Validate;
        public CheckBox checkBox_isCRC;
    }
}