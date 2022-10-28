namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    partial class DMPAccountLogin
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Cancel.Location = new System.Drawing.Point(179, 217);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(150, 40);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "Back";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Login.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Login.Location = new System.Drawing.Point(7, 217);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(139, 40);
            this.button_Login.TabIndex = 10;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 2);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(14, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 2);
            this.panel2.TabIndex = 12;
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PassWord.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PassWord.Location = new System.Drawing.Point(10, 145);
            this.textBox_PassWord.Multiline = true;
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.PasswordChar = '*';
            this.textBox_PassWord.PlaceholderText = "Password";
            this.textBox_PassWord.Size = new System.Drawing.Size(313, 40);
            this.textBox_PassWord.TabIndex = 7;
            this.textBox_PassWord.Tag = "ECOLAB123|123123";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_UserName.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_UserName.Location = new System.Drawing.Point(11, 51);
            this.textBox_UserName.Multiline = true;
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.PlaceholderText = "Admin";
            this.textBox_UserName.Size = new System.Drawing.Size(312, 40);
            this.textBox_UserName.TabIndex = 6;
            this.textBox_UserName.Text = "User";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Password.Location = new System.Drawing.Point(6, 106);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(108, 28);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Password";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Username.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Username.Location = new System.Drawing.Point(5, 13);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(115, 28);
            this.label_Username.TabIndex = 9;
            this.label_Username.Text = "Username";
            // 
            // DMPAccountLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 291);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DMPAccountLogin";
            this.Text = "DMPAccountLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button button_Cancel;
        public Button button_Login;
        private Panel panel3;
        private Panel panel2;
        public TextBox textBox_PassWord;
        public TextBox textBox_UserName;
        public Label label_Password;
        public Label label_Username;
    }
}