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
            this.linkLabel_ClearSerialNumber = new System.Windows.Forms.LinkLabel();
            this.checkBox_ValidateSN = new System.Windows.Forms.CheckBox();
            this.textBox_SerialNumber = new System.Windows.Forms.TextBox();
            this.label_SerualNubmer_Validate = new System.Windows.Forms.Label();
            this.label_SerialNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel_ClearSerialNumber
            // 
            this.linkLabel_ClearSerialNumber.AutoSize = true;
            this.linkLabel_ClearSerialNumber.Location = new System.Drawing.Point(831, 81);
            this.linkLabel_ClearSerialNumber.Name = "linkLabel_ClearSerialNumber";
            this.linkLabel_ClearSerialNumber.Size = new System.Drawing.Size(54, 24);
            this.linkLabel_ClearSerialNumber.TabIndex = 21;
            this.linkLabel_ClearSerialNumber.TabStop = true;
            this.linkLabel_ClearSerialNumber.Text = "Clear";
            this.linkLabel_ClearSerialNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ClearSerialNumber_LinkClicked);
            // 
            // checkBox_ValidateSN
            // 
            this.checkBox_ValidateSN.AutoSize = true;
            this.checkBox_ValidateSN.Checked = true;
            this.checkBox_ValidateSN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ValidateSN.Location = new System.Drawing.Point(325, 38);
            this.checkBox_ValidateSN.Name = "checkBox_ValidateSN";
            this.checkBox_ValidateSN.Size = new System.Drawing.Size(190, 28);
            this.checkBox_ValidateSN.TabIndex = 20;
            this.checkBox_ValidateSN.Text = "EnableValidateSN";
            this.checkBox_ValidateSN.UseVisualStyleBackColor = true;
            // 
            // textBox_SerialNumber
            // 
            this.textBox_SerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SerialNumber.Location = new System.Drawing.Point(325, 81);
            this.textBox_SerialNumber.Multiline = true;
            this.textBox_SerialNumber.Name = "textBox_SerialNumber";
            this.textBox_SerialNumber.Size = new System.Drawing.Size(466, 28);
            this.textBox_SerialNumber.TabIndex = 18;
            // 
            // label_SerualNubmer_Validate
            // 
            this.label_SerualNubmer_Validate.AutoSize = true;
            this.label_SerualNubmer_Validate.ForeColor = System.Drawing.Color.Red;
            this.label_SerualNubmer_Validate.Location = new System.Drawing.Point(312, 112);
            this.label_SerualNubmer_Validate.Name = "label_SerualNubmer_Validate";
            this.label_SerualNubmer_Validate.Size = new System.Drawing.Size(0, 24);
            this.label_SerualNubmer_Validate.TabIndex = 19;
            // 
            // label_SerialNumber
            // 
            this.label_SerialNumber.AutoSize = true;
            this.label_SerialNumber.Location = new System.Drawing.Point(153, 81);
            this.label_SerialNumber.Name = "label_SerialNumber";
            this.label_SerialNumber.Size = new System.Drawing.Size(138, 24);
            this.label_SerialNumber.TabIndex = 17;
            this.label_SerialNumber.Text = "Serial Number:";
            // 
            // FormNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 191);
            this.Controls.Add(this.linkLabel_ClearSerialNumber);
            this.Controls.Add(this.checkBox_ValidateSN);
            this.Controls.Add(this.textBox_SerialNumber);
            this.Controls.Add(this.label_SerualNubmer_Validate);
            this.Controls.Add(this.label_SerialNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNormal";
            this.Text = "FormNormal";
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