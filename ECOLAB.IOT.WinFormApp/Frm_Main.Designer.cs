namespace ECOLAB.IOT.WinFormApp
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.panel_Side = new System.Windows.Forms.Panel();
            this.button_Profile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Cash = new System.Windows.Forms.Button();
            this.button_DashBorad = new System.Windows.Forms.Button();
            this.button_Account = new System.Windows.Forms.Button();
            this.button_SerialCOM = new System.Windows.Forms.Button();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.button_Main_Close = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Side
            // 
            this.panel_Side.BackColor = System.Drawing.Color.DimGray;
            this.panel_Side.Controls.Add(this.button_Profile);
            this.panel_Side.Controls.Add(this.pictureBox1);
            this.panel_Side.Controls.Add(this.button_Cash);
            this.panel_Side.Controls.Add(this.button_DashBorad);
            this.panel_Side.Controls.Add(this.button_Account);
            this.panel_Side.Controls.Add(this.button_SerialCOM);
            this.panel_Side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Side.Location = new System.Drawing.Point(0, 42);
            this.panel_Side.Name = "panel_Side";
            this.panel_Side.Size = new System.Drawing.Size(221, 722);
            this.panel_Side.TabIndex = 0;
            this.panel_Side.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Side_MouseDown);
            // 
            // button_Profile
            // 
            this.button_Profile.BackColor = System.Drawing.Color.DimGray;
            this.button_Profile.FlatAppearance.BorderSize = 0;
            this.button_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Profile.Font = new System.Drawing.Font("Century Gothic", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Profile.Image = ((System.Drawing.Image)(resources.GetObject("button_Profile.Image")));
            this.button_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Profile.Location = new System.Drawing.Point(0, 397);
            this.button_Profile.Name = "button_Profile";
            this.button_Profile.Size = new System.Drawing.Size(210, 38);
            this.button_Profile.TabIndex = 0;
            this.button_Profile.Text = "Profile";
            this.button_Profile.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.电脑;
            this.pictureBox1.Location = new System.Drawing.Point(44, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_Cash
            // 
            this.button_Cash.BackColor = System.Drawing.Color.DimGray;
            this.button_Cash.FlatAppearance.BorderSize = 0;
            this.button_Cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cash.Font = new System.Drawing.Font("Century Gothic", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Cash.Image = ((System.Drawing.Image)(resources.GetObject("button_Cash.Image")));
            this.button_Cash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cash.Location = new System.Drawing.Point(0, 342);
            this.button_Cash.Name = "button_Cash";
            this.button_Cash.Size = new System.Drawing.Size(210, 38);
            this.button_Cash.TabIndex = 0;
            this.button_Cash.Text = "Cash";
            this.button_Cash.UseVisualStyleBackColor = false;
            // 
            // button_DashBorad
            // 
            this.button_DashBorad.BackColor = System.Drawing.Color.DimGray;
            this.button_DashBorad.FlatAppearance.BorderSize = 0;
            this.button_DashBorad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DashBorad.Font = new System.Drawing.Font("Century Gothic", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_DashBorad.Image = ((System.Drawing.Image)(resources.GetObject("button_DashBorad.Image")));
            this.button_DashBorad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DashBorad.Location = new System.Drawing.Point(0, 165);
            this.button_DashBorad.Name = "button_DashBorad";
            this.button_DashBorad.Size = new System.Drawing.Size(210, 38);
            this.button_DashBorad.TabIndex = 0;
            this.button_DashBorad.Text = "DASHBORAD";
            this.button_DashBorad.UseVisualStyleBackColor = false;
            this.button_DashBorad.Click += new System.EventHandler(this.button_DashBorad_Click);
            // 
            // button_Account
            // 
            this.button_Account.BackColor = System.Drawing.Color.DimGray;
            this.button_Account.FlatAppearance.BorderSize = 0;
            this.button_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Account.Font = new System.Drawing.Font("Century Gothic", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Account.Image = ((System.Drawing.Image)(resources.GetObject("button_Account.Image")));
            this.button_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Account.Location = new System.Drawing.Point(0, 280);
            this.button_Account.Name = "button_Account";
            this.button_Account.Size = new System.Drawing.Size(210, 38);
            this.button_Account.TabIndex = 0;
            this.button_Account.Text = "Account";
            this.button_Account.UseVisualStyleBackColor = false;
            // 
            // button_SerialCOM
            // 
            this.button_SerialCOM.BackColor = System.Drawing.Color.DimGray;
            this.button_SerialCOM.FlatAppearance.BorderSize = 0;
            this.button_SerialCOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SerialCOM.Font = new System.Drawing.Font("Century Gothic", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_SerialCOM.Image = ((System.Drawing.Image)(resources.GetObject("button_SerialCOM.Image")));
            this.button_SerialCOM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SerialCOM.Location = new System.Drawing.Point(5, 224);
            this.button_SerialCOM.Name = "button_SerialCOM";
            this.button_SerialCOM.Size = new System.Drawing.Size(210, 38);
            this.button_SerialCOM.TabIndex = 0;
            this.button_SerialCOM.Text = "SerialCOM";
            this.button_SerialCOM.UseVisualStyleBackColor = false;
            this.button_SerialCOM.Click += new System.EventHandler(this.button_SerialCOM_Click);
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.Gray;
            this.panel_Header.Controls.Add(this.button_Main_Close);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1346, 42);
            this.panel_Header.TabIndex = 1;
            this.panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseDown);
            // 
            // button_Main_Close
            // 
            this.button_Main_Close.BackColor = System.Drawing.Color.Gray;
            this.button_Main_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Main_Close.FlatAppearance.BorderSize = 0;
            this.button_Main_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Main_Close.Font = new System.Drawing.Font("Century Gothic", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Main_Close.Image = ((System.Drawing.Image)(resources.GetObject("button_Main_Close.Image")));
            this.button_Main_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Main_Close.Location = new System.Drawing.Point(1303, 0);
            this.button_Main_Close.Name = "button_Main_Close";
            this.button_Main_Close.Size = new System.Drawing.Size(43, 42);
            this.button_Main_Close.TabIndex = 1;
            this.button_Main_Close.UseVisualStyleBackColor = false;
            this.button_Main_Close.Click += new System.EventHandler(this.button_Main_Close_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(221, 42);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1125, 722);
            this.panel_Main.TabIndex = 2;
            this.panel_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Main_MouseDown);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 764);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Side);
            this.Controls.Add(this.panel_Header);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Main";
            this.panel_Side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Side;
        private Button button_Profile;
        private PictureBox pictureBox1;
        private Button button_Cash;
        private Button button_DashBorad;
        private Button button_Account;
        private Button button_SerialCOM;
        private Panel panel_Header;
        private Button button_Main_Close;
        private Panel panel_Main;
    }
}