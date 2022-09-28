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
            this.label_ChooseFile = new System.Windows.Forms.Label();
            this.textBox_ChooseFile = new System.Windows.Forms.TextBox();
            this.button_ChooseFile = new System.Windows.Forms.Button();
            this.comboBox_TransportProtocol = new System.Windows.Forms.ComboBox();
            this.label_TransportProtocol = new System.Windows.Forms.Label();
            this.label_ChooseFile_Validate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ChooseFile
            // 
            this.label_ChooseFile.AutoSize = true;
            this.label_ChooseFile.Location = new System.Drawing.Point(149, 99);
            this.label_ChooseFile.Name = "label_ChooseFile";
            this.label_ChooseFile.Size = new System.Drawing.Size(112, 24);
            this.label_ChooseFile.TabIndex = 0;
            this.label_ChooseFile.Text = "Choose File:";
            // 
            // textBox_ChooseFile
            // 
            this.textBox_ChooseFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ChooseFile.Location = new System.Drawing.Point(297, 95);
            this.textBox_ChooseFile.Multiline = true;
            this.textBox_ChooseFile.Name = "textBox_ChooseFile";
            this.textBox_ChooseFile.Size = new System.Drawing.Size(494, 30);
            this.textBox_ChooseFile.TabIndex = 1;
            // 
            // button_ChooseFile
            // 
            this.button_ChooseFile.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_ChooseFile.FlatAppearance.BorderSize = 0;
            this.button_ChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChooseFile.Location = new System.Drawing.Point(826, 93);
            this.button_ChooseFile.Name = "button_ChooseFile";
            this.button_ChooseFile.Size = new System.Drawing.Size(145, 34);
            this.button_ChooseFile.TabIndex = 2;
            this.button_ChooseFile.Text = "Choose ...";
            this.button_ChooseFile.UseVisualStyleBackColor = false;
            this.button_ChooseFile.Click += new System.EventHandler(this.button_ChooseFile_Click);
            // 
            // comboBox_TransportProtocol
            // 
            this.comboBox_TransportProtocol.FormattingEnabled = true;
            this.comboBox_TransportProtocol.Location = new System.Drawing.Point(297, 42);
            this.comboBox_TransportProtocol.Name = "comboBox_TransportProtocol";
            this.comboBox_TransportProtocol.Size = new System.Drawing.Size(182, 32);
            this.comboBox_TransportProtocol.TabIndex = 4;
            // 
            // label_TransportProtocol
            // 
            this.label_TransportProtocol.AutoSize = true;
            this.label_TransportProtocol.Location = new System.Drawing.Point(86, 45);
            this.label_TransportProtocol.Name = "label_TransportProtocol";
            this.label_TransportProtocol.Size = new System.Drawing.Size(174, 24);
            this.label_TransportProtocol.TabIndex = 5;
            this.label_TransportProtocol.Text = "Transport Protocol:";
            // 
            // label_ChooseFile_Validate
            // 
            this.label_ChooseFile_Validate.AutoSize = true;
            this.label_ChooseFile_Validate.ForeColor = System.Drawing.Color.Red;
            this.label_ChooseFile_Validate.Location = new System.Drawing.Point(297, 138);
            this.label_ChooseFile_Validate.Name = "label_ChooseFile_Validate";
            this.label_ChooseFile_Validate.Size = new System.Drawing.Size(0, 24);
            this.label_ChooseFile_Validate.TabIndex = 6;
            // 
            // FormFileSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1237, 199);
            this.Controls.Add(this.label_ChooseFile_Validate);
            this.Controls.Add(this.label_TransportProtocol);
            this.Controls.Add(this.comboBox_TransportProtocol);
            this.Controls.Add(this.button_ChooseFile);
            this.Controls.Add(this.textBox_ChooseFile);
            this.Controls.Add(this.label_ChooseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFileSend";
            this.Text = "FormFileSend";
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
    }
}