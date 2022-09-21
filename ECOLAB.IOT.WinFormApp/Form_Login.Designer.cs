namespace ECOLAB.IOT.WinFormApp
{
    partial class Form_Login
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
            this.label_username = new System.Windows.Forms.Label();
            this.uiLabel_Login = new Sunny.UI.UILabel();
            this.uiLabel_UserName = new Sunny.UI.UILabel();
            this.uiLabel_Password = new Sunny.UI.UILabel();
            this.uiTextBox_UserName = new Sunny.UI.UITextBox();
            this.uiTextBox_Password = new Sunny.UI.UITextBox();
            this.uiRadioButton_Int = new Sunny.UI.UIRadioButton();
            this.uiRadioButton_Product = new Sunny.UI.UIRadioButton();
            this.uiButton_Cancel = new Sunny.UI.UIButton();
            this.uiButton_Submit = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(274, 124);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(0, 24);
            this.label_username.TabIndex = 2;
            // 
            // uiLabel_Login
            // 
            this.uiLabel_Login.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uiLabel_Login.Location = new System.Drawing.Point(333, 38);
            this.uiLabel_Login.Name = "uiLabel_Login";
            this.uiLabel_Login.Size = new System.Drawing.Size(162, 54);
            this.uiLabel_Login.TabIndex = 5;
            this.uiLabel_Login.Text = "Login";
            this.uiLabel_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel_Login.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel_UserName
            // 
            this.uiLabel_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel_UserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel_UserName.Location = new System.Drawing.Point(149, 124);
            this.uiLabel_UserName.Name = "uiLabel_UserName";
            this.uiLabel_UserName.Size = new System.Drawing.Size(150, 34);
            this.uiLabel_UserName.TabIndex = 6;
            this.uiLabel_UserName.Text = "UserName:";
            this.uiLabel_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel_UserName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel_Password
            // 
            this.uiLabel_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel_Password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel_Password.Location = new System.Drawing.Point(156, 191);
            this.uiLabel_Password.Name = "uiLabel_Password";
            this.uiLabel_Password.Size = new System.Drawing.Size(143, 49);
            this.uiLabel_Password.TabIndex = 7;
            this.uiLabel_Password.Text = "Password:";
            this.uiLabel_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel_Password.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox_UserName
            // 
            this.uiTextBox_UserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox_UserName.Location = new System.Drawing.Point(306, 124);
            this.uiTextBox_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_UserName.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_UserName.Name = "uiTextBox_UserName";
            this.uiTextBox_UserName.ShowText = false;
            this.uiTextBox_UserName.Size = new System.Drawing.Size(298, 35);
            this.uiTextBox_UserName.TabIndex = 8;
            this.uiTextBox_UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_UserName.Watermark = "";
            this.uiTextBox_UserName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox_Password
            // 
            this.uiTextBox_Password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox_Password.Location = new System.Drawing.Point(306, 205);
            this.uiTextBox_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_Password.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_Password.Name = "uiTextBox_Password";
            this.uiTextBox_Password.PasswordChar = '*';
            this.uiTextBox_Password.ShowText = false;
            this.uiTextBox_Password.Size = new System.Drawing.Size(294, 35);
            this.uiTextBox_Password.TabIndex = 9;
            this.uiTextBox_Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_Password.Watermark = "";
            this.uiTextBox_Password.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiRadioButton_Int
            // 
            this.uiRadioButton_Int.Checked = true;
            this.uiRadioButton_Int.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiRadioButton_Int.Location = new System.Drawing.Point(306, 278);
            this.uiRadioButton_Int.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton_Int.Name = "uiRadioButton_Int";
            this.uiRadioButton_Int.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton_Int.Size = new System.Drawing.Size(119, 44);
            this.uiRadioButton_Int.TabIndex = 10;
            this.uiRadioButton_Int.Text = "Int";
            this.uiRadioButton_Int.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiRadioButton_Product
            // 
            this.uiRadioButton_Product.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiRadioButton_Product.Location = new System.Drawing.Point(450, 278);
            this.uiRadioButton_Product.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton_Product.Name = "uiRadioButton_Product";
            this.uiRadioButton_Product.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton_Product.Size = new System.Drawing.Size(150, 44);
            this.uiRadioButton_Product.TabIndex = 11;
            this.uiRadioButton_Product.Text = "Product";
            this.uiRadioButton_Product.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton_Cancel
            // 
            this.uiButton_Cancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uiButton_Cancel.Location = new System.Drawing.Point(427, 348);
            this.uiButton_Cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Cancel.Name = "uiButton_Cancel";
            this.uiButton_Cancel.Size = new System.Drawing.Size(148, 34);
            this.uiButton_Cancel.TabIndex = 15;
            this.uiButton_Cancel.Text = "Cancel";
            this.uiButton_Cancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton_Cancel.Click += new System.EventHandler(this.uiButton_Cancel_Click);
            // 
            // uiButton_Submit
            // 
            this.uiButton_Submit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton_Submit.Location = new System.Drawing.Point(184, 348);
            this.uiButton_Submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Submit.Name = "uiButton_Submit";
            this.uiButton_Submit.Size = new System.Drawing.Size(148, 34);
            this.uiButton_Submit.TabIndex = 14;
            this.uiButton_Submit.Text = "Submit";
            this.uiButton_Submit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton_Submit.Click += new System.EventHandler(this.uiButton_Submit_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiButton_Cancel);
            this.Controls.Add(this.uiButton_Submit);
            this.Controls.Add(this.uiRadioButton_Product);
            this.Controls.Add(this.uiRadioButton_Int);
            this.Controls.Add(this.uiTextBox_Password);
            this.Controls.Add(this.uiTextBox_UserName);
            this.Controls.Add(this.uiLabel_Password);
            this.Controls.Add(this.uiLabel_UserName);
            this.Controls.Add(this.uiLabel_Login);
            this.Controls.Add(this.label_username);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_username;
        private Sunny.UI.UILabel uiLabel_Login;
        private Sunny.UI.UILabel uiLabel_UserName;
        private Sunny.UI.UILabel uiLabel_Password;
        private Sunny.UI.UITextBox uiTextBox_UserName;
        private Sunny.UI.UITextBox uiTextBox_Password;
        private Sunny.UI.UIRadioButton uiRadioButton_Int;
        private Sunny.UI.UIRadioButton uiRadioButton_Product;
        private Sunny.UI.UIButton uiButton_Cancel;
        private Sunny.UI.UIButton uiButton_Submit;
    }
}