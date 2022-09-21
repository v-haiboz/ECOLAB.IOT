namespace ECOLAB.IOT.WinFormApp
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Min = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton_Int = new System.Windows.Forms.RadioButton();
            this.radioButton_Product = new System.Windows.Forms.RadioButton();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.pictureBox_Min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 42);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Min.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_Min.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Min.Image")));
            this.pictureBox_Min.Location = new System.Drawing.Point(966, 0);
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.Size = new System.Drawing.Size(42, 42);
            this.pictureBox_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Min.TabIndex = 8;
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Click += new System.EventHandler(this.pictureBox_Min_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1008, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Login ECOLAB IOT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_UserName.Location = new System.Drawing.Point(322, 198);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(119, 28);
            this.label_UserName.TabIndex = 2;
            this.label_UserName.Text = "UserName";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_UserName.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_UserName.Location = new System.Drawing.Point(322, 233);
            this.textBox_UserName.Multiline = true;
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.PlaceholderText = "Admin";
            this.textBox_UserName.Size = new System.Drawing.Size(300, 40);
            this.textBox_UserName.TabIndex = 0;
            this.textBox_UserName.Text = "UserProduct";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(328, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 2);
            this.panel2.TabIndex = 4;
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PassWord.Location = new System.Drawing.Point(322, 304);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(119, 28);
            this.label_PassWord.TabIndex = 2;
            this.label_PassWord.Text = "UserName";
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PassWord.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PassWord.Location = new System.Drawing.Point(322, 339);
            this.textBox_PassWord.Multiline = true;
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.PasswordChar = '*';
            this.textBox_PassWord.PlaceholderText = "Password";
            this.textBox_PassWord.Size = new System.Drawing.Size(300, 40);
            this.textBox_PassWord.TabIndex = 1;
            this.textBox_PassWord.Text = "123";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(328, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 2);
            this.panel3.TabIndex = 4;
            // 
            // radioButton_Int
            // 
            this.radioButton_Int.AutoSize = true;
            this.radioButton_Int.Checked = true;
            this.radioButton_Int.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_Int.Location = new System.Drawing.Point(322, 406);
            this.radioButton_Int.Name = "radioButton_Int";
            this.radioButton_Int.Size = new System.Drawing.Size(58, 28);
            this.radioButton_Int.TabIndex = 2;
            this.radioButton_Int.TabStop = true;
            this.radioButton_Int.Text = "Int";
            this.radioButton_Int.UseVisualStyleBackColor = true;
            // 
            // radioButton_Product
            // 
            this.radioButton_Product.AutoSize = true;
            this.radioButton_Product.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_Product.Location = new System.Drawing.Point(494, 406);
            this.radioButton_Product.Name = "radioButton_Product";
            this.radioButton_Product.Size = new System.Drawing.Size(103, 28);
            this.radioButton_Product.TabIndex = 3;
            this.radioButton_Product.Text = "Product";
            this.radioButton_Product.UseVisualStyleBackColor = true;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Purple;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Login.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(311, 489);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(150, 40);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.Purple;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(494, 489);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(150, 40);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 586);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.radioButton_Product);
            this.Controls.Add(this.radioButton_Int);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_PassWord);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label_UserName;
        private TextBox textBox_UserName;
        private Panel panel2;
        private Label label_PassWord;
        private TextBox textBox_PassWord;
        private Panel panel3;
        private RadioButton radioButton_Int;
        private RadioButton radioButton_Product;
        private Button button_Login;
        private Button button_Cancel;
        private PictureBox pictureBox_Min;
    }
}