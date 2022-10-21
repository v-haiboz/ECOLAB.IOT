namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    partial class AccountLogin
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
            this.button_DMPAccountLogin = new System.Windows.Forms.Button();
            this.button_ECOLABAcountLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_DMPAccountLogin
            // 
            this.button_DMPAccountLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.button_DMPAccountLogin.FlatAppearance.BorderSize = 0;
            this.button_DMPAccountLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DMPAccountLogin.Location = new System.Drawing.Point(12, 12);
            this.button_DMPAccountLogin.Name = "button_DMPAccountLogin";
            this.button_DMPAccountLogin.Size = new System.Drawing.Size(304, 71);
            this.button_DMPAccountLogin.TabIndex = 0;
            this.button_DMPAccountLogin.Text = "DMP account login";
            this.button_DMPAccountLogin.UseVisualStyleBackColor = false;
            this.button_DMPAccountLogin.Click += new System.EventHandler(this.button_DMPAccountLogin_Click);
            // 
            // button_ECOLABAcountLogin
            // 
            this.button_ECOLABAcountLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_ECOLABAcountLogin.FlatAppearance.BorderSize = 0;
            this.button_ECOLABAcountLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ECOLABAcountLogin.Location = new System.Drawing.Point(12, 137);
            this.button_ECOLABAcountLogin.Name = "button_ECOLABAcountLogin";
            this.button_ECOLABAcountLogin.Size = new System.Drawing.Size(304, 75);
            this.button_ECOLABAcountLogin.TabIndex = 0;
            this.button_ECOLABAcountLogin.Text = "ECOLAB One click Login";
            this.button_ECOLABAcountLogin.UseVisualStyleBackColor = false;
            this.button_ECOLABAcountLogin.Click += new System.EventHandler(this.button_ECOLABAcountLogin_Click);
            // 
            // AccountLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 291);
            this.Controls.Add(this.button_ECOLABAcountLogin);
            this.Controls.Add(this.button_DMPAccountLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountLogin";
            this.Text = "AccountLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_DMPAccountLogin;
        private Button button_ECOLABAcountLogin;
    }
}