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
            this.comboBox_Env = new System.Windows.Forms.ComboBox();
            this.radioButton_Chinese = new System.Windows.Forms.RadioButton();
            this.radioButton_English = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Login = new System.Windows.Forms.Panel();
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
            // panel_Login
            // 
            resources.ApplyResources(this.panel_Login, "panel_Login");
            this.panel_Login.Name = "panel_Login";
            // 
            // Frm_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.label_Header);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton_Chinese);
            this.Controls.Add(this.radioButton_English);
            this.Controls.Add(this.comboBox_Env);
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
        private PictureBox pictureBox_Min;
        private ComboBox comboBox_Env;
        private RadioButton radioButton_Chinese;
        private RadioButton radioButton_English;
        private PictureBox pictureBox1;
        private Panel panel_Login;
    }
}