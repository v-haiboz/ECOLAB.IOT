namespace ECOLAB.IOT.WinFormApp
{
    partial class CustomMessageBox
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
            this.lblTitleContent = new System.Windows.Forms.Label();
            this.normalMode = new System.Windows.Forms.RadioButton();
            this.dgwMode = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleContent
            // 
            this.lblTitleContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(117)))), ((int)(((byte)(151)))));
            this.lblTitleContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleContent.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleContent.ForeColor = System.Drawing.Color.White;
            this.lblTitleContent.Location = new System.Drawing.Point(0, 0);
            this.lblTitleContent.Name = "lblTitleContent";
            this.lblTitleContent.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblTitleContent.Size = new System.Drawing.Size(842, 49);
            this.lblTitleContent.TabIndex = 0;
            this.lblTitleContent.Text = "label1";
            this.lblTitleContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.lblTitleContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // normalMode
            // 
            this.normalMode.AutoSize = true;
            this.normalMode.Checked = true;
            this.normalMode.Location = new System.Drawing.Point(175, 62);
            this.normalMode.Name = "normalMode";
            this.normalMode.Size = new System.Drawing.Size(156, 28);
            this.normalMode.TabIndex = 0;
            this.normalMode.TabStop = true;
            this.normalMode.Text = "Normal Mode";
            this.normalMode.UseVisualStyleBackColor = true;
            // 
            // dgwMode
            // 
            this.dgwMode.AutoSize = true;
            this.dgwMode.Location = new System.Drawing.Point(442, 62);
            this.dgwMode.Name = "dgwMode";
            this.dgwMode.Size = new System.Drawing.Size(131, 28);
            this.dgwMode.TabIndex = 1;
            this.dgwMode.TabStop = true;
            this.dgwMode.Text = "DGWMode";
            this.dgwMode.UseVisualStyleBackColor = true;
            this.dgwMode.CheckedChanged += new System.EventHandler(this.dgwMode_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(117)))), ((int)(((byte)(151)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(184, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(117)))), ((int)(((byte)(151)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(425, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwMode);
            this.panel1.Controls.Add(this.normalMode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 144);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 175);
            this.panel2.TabIndex = 8;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitleContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.Text = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitleContent;
        private RadioButton normalMode;
        private RadioButton dgwMode;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
    }
}