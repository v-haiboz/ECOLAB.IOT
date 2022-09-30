namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    partial class FormNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNormal));
            this.linkLabel_ClearSerialNumber = new System.Windows.Forms.LinkLabel();
            this.checkBox_ValidateSN = new System.Windows.Forms.CheckBox();
            this.textBox_SerialNumber = new System.Windows.Forms.TextBox();
            this.label_SerualNubmer_Validate = new System.Windows.Forms.Label();
            this.label_SerialNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel_ClearSerialNumber
            // 
            resources.ApplyResources(this.linkLabel_ClearSerialNumber, "linkLabel_ClearSerialNumber");
            this.linkLabel_ClearSerialNumber.Name = "linkLabel_ClearSerialNumber";
            this.linkLabel_ClearSerialNumber.TabStop = true;
            this.linkLabel_ClearSerialNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ClearSerialNumber_LinkClicked);
            // 
            // checkBox_ValidateSN
            // 
            resources.ApplyResources(this.checkBox_ValidateSN, "checkBox_ValidateSN");
            this.checkBox_ValidateSN.Checked = true;
            this.checkBox_ValidateSN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ValidateSN.Name = "checkBox_ValidateSN";
            this.checkBox_ValidateSN.UseVisualStyleBackColor = true;
            // 
            // textBox_SerialNumber
            // 
            this.textBox_SerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_SerialNumber, "textBox_SerialNumber");
            this.textBox_SerialNumber.Name = "textBox_SerialNumber";
            // 
            // label_SerualNubmer_Validate
            // 
            resources.ApplyResources(this.label_SerualNubmer_Validate, "label_SerualNubmer_Validate");
            this.label_SerualNubmer_Validate.ForeColor = System.Drawing.Color.Red;
            this.label_SerualNubmer_Validate.Name = "label_SerualNubmer_Validate";
            // 
            // label_SerialNumber
            // 
            resources.ApplyResources(this.label_SerialNumber, "label_SerialNumber");
            this.label_SerialNumber.Name = "label_SerialNumber";
            // 
            // FormNormal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.linkLabel_ClearSerialNumber);
            this.Controls.Add(this.checkBox_ValidateSN);
            this.Controls.Add(this.textBox_SerialNumber);
            this.Controls.Add(this.label_SerualNubmer_Validate);
            this.Controls.Add(this.label_SerialNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNormal";
            this.Load += new System.EventHandler(this.FormNormal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public LinkLabel linkLabel_ClearSerialNumber;
        public CheckBox checkBox_ValidateSN;
        public TextBox textBox_SerialNumber;
        public Label label_SerualNubmer_Validate;
        public Label label_SerialNumber;
    }
}