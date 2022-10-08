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
            this.label_Header = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_Env = new System.Windows.Forms.ComboBox();
            this.radioButton_Chinese = new System.Windows.Forms.RadioButton();
            this.radioButton_English = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox_Min);
            this.panel1.Name = "panel1";
            // 
            // pictureBox_Min
            // 
            resources.ApplyResources(this.pictureBox_Min, "pictureBox_Min");
            this.pictureBox_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Click += new System.EventHandler(this.pictureBox_Min_Click);
            // 
            // label_Header
            // 
            resources.ApplyResources(this.label_Header, "label_Header");
            this.label_Header.Name = "label_Header";
            // 
            // label_Username
            // 
            resources.ApplyResources(this.label_Username, "label_Username");
            this.label_Username.Name = "label_Username";
            // 
            // textBox_UserName
            // 
            resources.ApplyResources(this.textBox_UserName, "textBox_UserName");
            this.textBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_UserName.Name = "textBox_UserName";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Name = "panel2";
            // 
            // label_Password
            // 
            resources.ApplyResources(this.label_Password, "label_Password");
            this.label_Password.Name = "label_Password";
            // 
            // textBox_PassWord
            // 
            resources.ApplyResources(this.textBox_PassWord, "textBox_PassWord");
            this.textBox_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Tag = "ECOLAB123|123123";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Name = "panel3";
            // 
            // button_Login
            // 
            resources.ApplyResources(this.button_Login, "button_Login");
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Name = "button_Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Cancel
            // 
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // comboBox_Env
            // 
            resources.ApplyResources(this.comboBox_Env, "comboBox_Env");
            this.comboBox_Env.BackColor = System.Drawing.Color.Azure;
            this.comboBox_Env.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Env.FormattingEnabled = true;
            this.comboBox_Env.Name = "comboBox_Env";
            // 
            // radioButton_Chinese
            // 
            resources.ApplyResources(this.radioButton_Chinese, "radioButton_Chinese");
            this.radioButton_Chinese.FlatAppearance.BorderSize = 0;
            this.radioButton_Chinese.Name = "radioButton_Chinese";
            this.radioButton_Chinese.UseVisualStyleBackColor = true;
            this.radioButton_Chinese.CheckedChanged += new System.EventHandler(this.radioButton_Chinese_CheckedChanged);
            // 
            // radioButton_English
            // 
            resources.ApplyResources(this.radioButton_English, "radioButton_English");
            this.radioButton_English.Checked = true;
            this.radioButton_English.FlatAppearance.BorderSize = 0;
            this.radioButton_English.Name = "radioButton_English";
            this.radioButton_English.TabStop = true;
            this.radioButton_English.UseVisualStyleBackColor = true;
            this.radioButton_English.CheckedChanged += new System.EventHandler(this.radioButton_English_CheckedChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.ECOLAB2;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_Header);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton_Chinese);
            this.Controls.Add(this.radioButton_English);
            this.Controls.Add(this.comboBox_Env);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label_Header;
        private Label label_Username;
        private TextBox textBox_UserName;
        private Panel panel2;
        private Label label_Password;
        private TextBox textBox_PassWord;
        private Panel panel3;
        private Button button_Login;
        private Button button_Cancel;
        private PictureBox pictureBox_Min;
        private ComboBox comboBox_Env;
        private RadioButton radioButton_Chinese;
        private RadioButton radioButton_English;
        private PictureBox pictureBox1;
    }
}