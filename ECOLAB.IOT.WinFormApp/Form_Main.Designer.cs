namespace ECOLAB.IOT.WinFormApp
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiContextMenuStrip_System = new Sunny.UI.UIContextMenuStrip();
            this.MenuItem_System_UpdatePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_System_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_System_SignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_System = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_System_UpdatePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_System_SignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_System_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Feature = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Feature_EmitDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Feature_EmitGateway = new System.Windows.Forms.ToolStripMenuItem();
            this.uiContextMenuStrip_System.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiContextMenuStrip_System
            // 
            this.uiContextMenuStrip_System.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip_System.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiContextMenuStrip_System.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uiContextMenuStrip_System.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_System_UpdatePassword,
            this.MenuItem_System_LogOut,
            this.MenuItem_System_SignOut});
            this.uiContextMenuStrip_System.Name = "uiContextMenuStrip_System";
            this.uiContextMenuStrip_System.Size = new System.Drawing.Size(233, 118);
            this.uiContextMenuStrip_System.Text = "系统";
            this.uiContextMenuStrip_System.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // MenuItem_System_UpdatePassword
            // 
            this.MenuItem_System_UpdatePassword.Name = "MenuItem_System_UpdatePassword";
            this.MenuItem_System_UpdatePassword.Size = new System.Drawing.Size(232, 38);
            this.MenuItem_System_UpdatePassword.Text = "更改密码";
            // 
            // MenuItem_System_LogOut
            // 
            this.MenuItem_System_LogOut.Name = "MenuItem_System_LogOut";
            this.MenuItem_System_LogOut.Size = new System.Drawing.Size(232, 38);
            this.MenuItem_System_LogOut.Text = "注销重新登录";
            // 
            // MenuItem_System_SignOut
            // 
            this.MenuItem_System_SignOut.Name = "MenuItem_System_SignOut";
            this.MenuItem_System_SignOut.Size = new System.Drawing.Size(232, 38);
            this.MenuItem_System_SignOut.Text = "退出系统";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_System,
            this.menu_Feature});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1341, 32);
            this.menu.TabIndex = 1;
            // 
            // menu_System
            // 
            this.menu_System.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_System_UpdatePassword,
            this.menu_System_SignOut,
            this.menu_System_LogOut});
            this.menu_System.Name = "menu_System";
            this.menu_System.Size = new System.Drawing.Size(62, 28);
            this.menu_System.Text = "系统";
            // 
            // menu_System_UpdatePassword
            // 
            this.menu_System_UpdatePassword.Name = "menu_System_UpdatePassword";
            this.menu_System_UpdatePassword.Size = new System.Drawing.Size(218, 34);
            this.menu_System_UpdatePassword.Text = "修改个人密码";
            // 
            // menu_System_SignOut
            // 
            this.menu_System_SignOut.Name = "menu_System_SignOut";
            this.menu_System_SignOut.Size = new System.Drawing.Size(218, 34);
            this.menu_System_SignOut.Text = "注销重新登录";
            // 
            // menu_System_LogOut
            // 
            this.menu_System_LogOut.Name = "menu_System_LogOut";
            this.menu_System_LogOut.Size = new System.Drawing.Size(218, 34);
            this.menu_System_LogOut.Text = "退出系统";
            // 
            // menu_Feature
            // 
            this.menu_Feature.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Feature_EmitDevice,
            this.menu_Feature_EmitGateway});
            this.menu_Feature.Name = "menu_Feature";
            this.menu_Feature.Size = new System.Drawing.Size(62, 28);
            this.menu_Feature.Text = "能力";
            // 
            // menu_Feature_EmitDevice
            // 
            this.menu_Feature_EmitDevice.Name = "menu_Feature_EmitDevice";
            this.menu_Feature_EmitDevice.Size = new System.Drawing.Size(223, 34);
            this.menu_Feature_EmitDevice.Text = "EmitDevice";
            // 
            // menu_Feature_EmitGateway
            // 
            this.menu_Feature_EmitGateway.Name = "menu_Feature_EmitGateway";
            this.menu_Feature_EmitGateway.Size = new System.Drawing.Size(223, 34);
            this.menu_Feature_EmitGateway.Text = "EmitGateway";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 668);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.uiContextMenuStrip_System.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip_System;
        private ToolStripMenuItem MenuItem_System_UpdatePassword;
        private ToolStripMenuItem MenuItem_System_LogOut;
        private ToolStripMenuItem MenuItem_System_SignOut;
        private MenuStrip menu;
        private ToolStripMenuItem menu_System;
        private ToolStripMenuItem menu_System_UpdatePassword;
        private ToolStripMenuItem menu_System_SignOut;
        private ToolStripMenuItem menu_System_LogOut;
        private ToolStripMenuItem menu_Feature;
        private ToolStripMenuItem menu_Feature_EmitDevice;
        private ToolStripMenuItem menu_Feature_EmitGateway;
    }
}