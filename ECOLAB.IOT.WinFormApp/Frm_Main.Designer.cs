using ECOLAB.IOT.Common.Win32;
using ECOLAB.IOT.Service;
using System.ComponentModel;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.panel_ChildHeader = new System.Windows.Forms.Panel();
            this.label_ChildHeader_Menu = new System.Windows.Forms.Label();
            this.panel_SideMenu = new System.Windows.Forms.Panel();
            this.button_Account_Profile = new System.Windows.Forms.Button();
            this.button_SerialCOM_GateWay = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.panel_SettingSubMenu = new System.Windows.Forms.Panel();
            this.button_Setting_AAD = new System.Windows.Forms.Button();
            this.button_Setting_Application = new System.Windows.Forms.Button();
            this.button_Setting_Environment = new System.Windows.Forms.Button();
            this.button_Setting = new System.Windows.Forms.Button();
            this.panel_SerialCOMSubMenu = new System.Windows.Forms.Panel();
            this.button_SerialCOM_Burn = new System.Windows.Forms.Button();
            this.button_SerialCOM = new System.Windows.Forms.Button();
            this.panel_AccountSubMenu = new System.Windows.Forms.Panel();
            this.button_Account_SignOut = new System.Windows.Forms.Button();
            this.button_Account = new System.Windows.Forms.Button();
            this.panel_Log = new System.Windows.Forms.Panel();
            this.label_Environment = new System.Windows.Forms.Label();
            this.pictureBox_MainMenu = new System.Windows.Forms.PictureBox();
            this.panel_BottomToolTip = new System.Windows.Forms.Panel();
            this.label_DateTime = new System.Windows.Forms.Label();
            this.label_Exit = new System.Windows.Forms.Label();
            this.label_CurrentUser = new System.Windows.Forms.Label();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.label_CurrentMenu = new System.Windows.Forms.Label();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.pictureBox_Min = new System.Windows.Forms.PictureBox();
            this.pictureBox_Max = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_ChildForm.SuspendLayout();
            this.panel_ChildHeader.SuspendLayout();
            this.panel_SideMenu.SuspendLayout();
            this.panel_SettingSubMenu.SuspendLayout();
            this.panel_SerialCOMSubMenu.SuspendLayout();
            this.panel_AccountSubMenu.SuspendLayout();
            this.panel_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MainMenu)).BeginInit();
            this.panel_BottomToolTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Max)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ChildForm
            // 
            this.panel_ChildForm.Controls.Add(this.panel_ChildHeader);
            this.panel_ChildForm.Controls.Add(this.panel_SideMenu);
            this.panel_ChildForm.Controls.Add(this.panel_BottomToolTip);
            resources.ApplyResources(this.panel_ChildForm, "panel_ChildForm");
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_ChildForm_MouseDown);
            // 
            // panel_ChildHeader
            // 
            this.panel_ChildHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.panel_ChildHeader.Controls.Add(this.label_ChildHeader_Menu);
            resources.ApplyResources(this.panel_ChildHeader, "panel_ChildHeader");
            this.panel_ChildHeader.ForeColor = System.Drawing.Color.White;
            this.panel_ChildHeader.Name = "panel_ChildHeader";
            // 
            // label_ChildHeader_Menu
            // 
            resources.ApplyResources(this.label_ChildHeader_Menu, "label_ChildHeader_Menu");
            this.label_ChildHeader_Menu.Name = "label_ChildHeader_Menu";
            // 
            // panel_SideMenu
            // 
            resources.ApplyResources(this.panel_SideMenu, "panel_SideMenu");
            this.panel_SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panel_SideMenu.Controls.Add(this.button_Account_Profile);
            this.panel_SideMenu.Controls.Add(this.button_SerialCOM_GateWay);
            this.panel_SideMenu.Controls.Add(this.button_Help);
            this.panel_SideMenu.Controls.Add(this.panel_SettingSubMenu);
            this.panel_SideMenu.Controls.Add(this.button_Setting);
            this.panel_SideMenu.Controls.Add(this.panel_SerialCOMSubMenu);
            this.panel_SideMenu.Controls.Add(this.button_SerialCOM);
            this.panel_SideMenu.Controls.Add(this.panel_AccountSubMenu);
            this.panel_SideMenu.Controls.Add(this.button_Account);
            this.panel_SideMenu.Controls.Add(this.panel_Log);
            this.panel_SideMenu.Name = "panel_SideMenu";
            // 
            // button_Account_Profile
            // 
            resources.ApplyResources(this.button_Account_Profile, "button_Account_Profile");
            this.button_Account_Profile.FlatAppearance.BorderSize = 0;
            this.button_Account_Profile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Account_Profile.Name = "button_Account_Profile";
            this.button_Account_Profile.UseVisualStyleBackColor = true;
            // 
            // button_SerialCOM_GateWay
            // 
            resources.ApplyResources(this.button_SerialCOM_GateWay, "button_SerialCOM_GateWay");
            this.button_SerialCOM_GateWay.FlatAppearance.BorderSize = 0;
            this.button_SerialCOM_GateWay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_SerialCOM_GateWay.Name = "button_SerialCOM_GateWay";
            this.button_SerialCOM_GateWay.UseVisualStyleBackColor = true;
            // 
            // button_Help
            // 
            resources.ApplyResources(this.button_Help, "button_Help");
            this.button_Help.FlatAppearance.BorderSize = 0;
            this.button_Help.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Help.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.help_Main;
            this.button_Help.Name = "button_Help";
            this.button_Help.UseVisualStyleBackColor = true;
            // 
            // panel_SettingSubMenu
            // 
            this.panel_SettingSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_SettingSubMenu.Controls.Add(this.button_Setting_AAD);
            this.panel_SettingSubMenu.Controls.Add(this.button_Setting_Application);
            this.panel_SettingSubMenu.Controls.Add(this.button_Setting_Environment);
            resources.ApplyResources(this.panel_SettingSubMenu, "panel_SettingSubMenu");
            this.panel_SettingSubMenu.Name = "panel_SettingSubMenu";
            // 
            // button_Setting_AAD
            // 
            resources.ApplyResources(this.button_Setting_AAD, "button_Setting_AAD");
            this.button_Setting_AAD.FlatAppearance.BorderSize = 0;
            this.button_Setting_AAD.ForeColor = System.Drawing.Color.White;
            this.button_Setting_AAD.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.setting_ADD_Main;
            this.button_Setting_AAD.Name = "button_Setting_AAD";
            this.button_Setting_AAD.UseVisualStyleBackColor = true;
            this.button_Setting_AAD.Click += new System.EventHandler(this.button_Setting_AAD_Click);
            // 
            // button_Setting_Application
            // 
            resources.ApplyResources(this.button_Setting_Application, "button_Setting_Application");
            this.button_Setting_Application.FlatAppearance.BorderSize = 0;
            this.button_Setting_Application.ForeColor = System.Drawing.Color.White;
            this.button_Setting_Application.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.setting_aaplication_Main1;
            this.button_Setting_Application.Name = "button_Setting_Application";
            this.button_Setting_Application.UseVisualStyleBackColor = true;
            this.button_Setting_Application.Click += new System.EventHandler(this.button_Setting_Application_Click);
            // 
            // button_Setting_Environment
            // 
            resources.ApplyResources(this.button_Setting_Environment, "button_Setting_Environment");
            this.button_Setting_Environment.FlatAppearance.BorderSize = 0;
            this.button_Setting_Environment.ForeColor = System.Drawing.Color.White;
            this.button_Setting_Environment.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.setting_environment_Main;
            this.button_Setting_Environment.Name = "button_Setting_Environment";
            this.button_Setting_Environment.UseVisualStyleBackColor = true;
            this.button_Setting_Environment.Click += new System.EventHandler(this.button_Environment_Click);
            // 
            // button_Setting
            // 
            resources.ApplyResources(this.button_Setting, "button_Setting");
            this.button_Setting.FlatAppearance.BorderSize = 0;
            this.button_Setting.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Setting.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.setting_Main;
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.UseVisualStyleBackColor = true;
            this.button_Setting.Click += new System.EventHandler(this.button_Setting_Click);
            // 
            // panel_SerialCOMSubMenu
            // 
            this.panel_SerialCOMSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_SerialCOMSubMenu.Controls.Add(this.button_SerialCOM_Burn);
            resources.ApplyResources(this.panel_SerialCOMSubMenu, "panel_SerialCOMSubMenu");
            this.panel_SerialCOMSubMenu.Name = "panel_SerialCOMSubMenu";
            // 
            // button_SerialCOM_Burn
            // 
            resources.ApplyResources(this.button_SerialCOM_Burn, "button_SerialCOM_Burn");
            this.button_SerialCOM_Burn.FlatAppearance.BorderSize = 0;
            this.button_SerialCOM_Burn.ForeColor = System.Drawing.Color.White;
            this.button_SerialCOM_Burn.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.feature_device_Main;
            this.button_SerialCOM_Burn.Name = "button_SerialCOM_Burn";
            this.button_SerialCOM_Burn.UseVisualStyleBackColor = true;
            this.button_SerialCOM_Burn.Click += new System.EventHandler(this.button_SerialCOM_Burn_Click);
            // 
            // button_SerialCOM
            // 
            resources.ApplyResources(this.button_SerialCOM, "button_SerialCOM");
            this.button_SerialCOM.FlatAppearance.BorderSize = 0;
            this.button_SerialCOM.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_SerialCOM.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.feature_Main;
            this.button_SerialCOM.Name = "button_SerialCOM";
            this.button_SerialCOM.UseVisualStyleBackColor = true;
            this.button_SerialCOM.Click += new System.EventHandler(this.button_SerialCOM_Click);
            // 
            // panel_AccountSubMenu
            // 
            this.panel_AccountSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_AccountSubMenu.Controls.Add(this.button_Account_SignOut);
            resources.ApplyResources(this.panel_AccountSubMenu, "panel_AccountSubMenu");
            this.panel_AccountSubMenu.Name = "panel_AccountSubMenu";
            // 
            // button_Account_SignOut
            // 
            resources.ApplyResources(this.button_Account_SignOut, "button_Account_SignOut");
            this.button_Account_SignOut.FlatAppearance.BorderSize = 0;
            this.button_Account_SignOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Account_SignOut.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.account_signout_Main;
            this.button_Account_SignOut.Name = "button_Account_SignOut";
            this.button_Account_SignOut.UseVisualStyleBackColor = true;
            this.button_Account_SignOut.Click += new System.EventHandler(this.button_SignOut_Click);
            // 
            // button_Account
            // 
            this.button_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            resources.ApplyResources(this.button_Account, "button_Account");
            this.button_Account.FlatAppearance.BorderSize = 0;
            this.button_Account.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Account.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.account_Main;
            this.button_Account.Name = "button_Account";
            this.button_Account.UseVisualStyleBackColor = false;
            this.button_Account.Click += new System.EventHandler(this.button_Account_Click);
            // 
            // panel_Log
            // 
            this.panel_Log.Controls.Add(this.label_Environment);
            this.panel_Log.Controls.Add(this.pictureBox_MainMenu);
            resources.ApplyResources(this.panel_Log, "panel_Log");
            this.panel_Log.Name = "panel_Log";
            // 
            // label_Environment
            // 
            resources.ApplyResources(this.label_Environment, "label_Environment");
            this.label_Environment.ForeColor = System.Drawing.Color.White;
            this.label_Environment.Name = "label_Environment";
            this.label_Environment.Click += new System.EventHandler(this.label_Environment_Click);
            // 
            // pictureBox_MainMenu
            // 
            this.pictureBox_MainMenu.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.fold_Main_Menu;
            resources.ApplyResources(this.pictureBox_MainMenu, "pictureBox_MainMenu");
            this.pictureBox_MainMenu.Name = "pictureBox_MainMenu";
            this.pictureBox_MainMenu.TabStop = false;
            this.pictureBox_MainMenu.Click += new System.EventHandler(this.pictureBox_MainMenu_Click);
            // 
            // panel_BottomToolTip
            // 
            this.panel_BottomToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.panel_BottomToolTip.Controls.Add(this.label_DateTime);
            this.panel_BottomToolTip.Controls.Add(this.label_Exit);
            this.panel_BottomToolTip.Controls.Add(this.label_CurrentUser);
            resources.ApplyResources(this.panel_BottomToolTip, "panel_BottomToolTip");
            this.panel_BottomToolTip.Name = "panel_BottomToolTip";
            // 
            // label_DateTime
            // 
            resources.ApplyResources(this.label_DateTime, "label_DateTime");
            this.label_DateTime.ForeColor = System.Drawing.Color.White;
            this.label_DateTime.Name = "label_DateTime";
            // 
            // label_Exit
            // 
            resources.ApplyResources(this.label_Exit, "label_Exit");
            this.label_Exit.ForeColor = System.Drawing.Color.White;
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // label_CurrentUser
            // 
            resources.ApplyResources(this.label_CurrentUser, "label_CurrentUser");
            this.label_CurrentUser.ForeColor = System.Drawing.Color.White;
            this.label_CurrentUser.Name = "label_CurrentUser";
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox_Close, "pictureBox_Close");
            this.pictureBox_Close.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.Close_Main;
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // label_CurrentMenu
            // 
            resources.ApplyResources(this.label_CurrentMenu, "label_CurrentMenu");
            this.label_CurrentMenu.ForeColor = System.Drawing.Color.White;
            this.label_CurrentMenu.Name = "label_CurrentMenu";
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panel_Header.Controls.Add(this.pictureBox_Min);
            this.panel_Header.Controls.Add(this.pictureBox_Max);
            this.panel_Header.Controls.Add(this.label_CurrentMenu);
            this.panel_Header.Controls.Add(this.pictureBox_Close);
            resources.ApplyResources(this.panel_Header, "panel_Header");
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseDown);
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox_Min, "pictureBox_Min");
            this.pictureBox_Min.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.Min_Main;
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Click += new System.EventHandler(this.pictureBox_Min_Click);
            // 
            // pictureBox_Max
            // 
            this.pictureBox_Max.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox_Max, "pictureBox_Max");
            this.pictureBox_Max.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.Normal_Main;
            this.pictureBox_Max.Name = "pictureBox_Max";
            this.pictureBox_Max.TabStop = false;
            this.pictureBox_Max.Click += new System.EventHandler(this.pictureBox_Max_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.panel_ChildForm.ResumeLayout(false);
            this.panel_ChildHeader.ResumeLayout(false);
            this.panel_ChildHeader.PerformLayout();
            this.panel_SideMenu.ResumeLayout(false);
            this.panel_SettingSubMenu.ResumeLayout(false);
            this.panel_SerialCOMSubMenu.ResumeLayout(false);
            this.panel_AccountSubMenu.ResumeLayout(false);
            this.panel_Log.ResumeLayout(false);
            this.panel_Log.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MainMenu)).EndInit();
            this.panel_BottomToolTip.ResumeLayout(false);
            this.panel_BottomToolTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Max)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Custom
        private void CustomizeDesing()
        {
            panel_SerialCOMSubMenu.Visible = false;
            panel_AccountSubMenu.Visible = false;
            panel_SettingSubMenu.Visible = false;

            this.label_CurrentUser.Text = "Current User: " + CallerContext.SysAdmin.UserName;
            this.label_Environment.Text = $"{label_Environment.Text}  ({CallerContext.EnvironmentVariable.Name.ToString()})";
        }
        private void SelectLanguate()
        {
            ComponentResourceManager res = new ComponentResourceManager(typeof(Frm_Main));
            this.button_Help.Text = $"           {res.GetString("button_Help")}";
            this.button_Setting_Environment.Text = $"           {res.GetString("button_Setting_Environment")}";
            this.button_Setting.Text = $"           {res.GetString("button_Setting")}";
            this.button_SerialCOM_Burn.Text = $"           {res.GetString("button_SerialCOM_Burn")}";
            this.button_SerialCOM_GateWay.Text = $"           {res.GetString("button_SerialCOM_GateWay")}";
            this.button_SerialCOM.Text = $"           {res.GetString("button_SerialCOM")}";
            this.button_Account_SignOut.Text = $"           {res.GetString("button_Account_SignOut")}";
            this.button_Account_Profile.Text = $"           {res.GetString("button_Account_Profile")}";
            this.button_Account.Text = $"           {res.GetString("button_Account")}";
            this.button_Setting_Application.Text = $"           {res.GetString("button_Setting_Application")}";
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_ChildForm.Controls.Add(childForm);
            panel_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MoveWinForm()
        {
            Win32SafeNativeMethods.ReleaseCapture();
            Win32SafeNativeMethods.SendMessage(this.Handle, Win32SafeNativeMethods.WM_SYSCOMMAND, Win32SafeNativeMethods.SC_MOVE + Win32SafeNativeMethods.HTCAPTION, 0);
        }

        private void ShowMainMenu()
        {
            if (this.panel_SideMenu.Width > 150)
            {
                ChangeSideMenu(50, Properties.Resources.open_Main_Menu);
            }
            else if (this.panel_SideMenu.Width < 60)
            {
                ChangeSideMenu(200, Properties.Resources.fold_Main_Menu);
            }
        }

        private void ChangeSideMenu(int width, Bitmap bitmap)
        {
            this.panel_SideMenu.Width = width;
            pictureBox_MainMenu.Image = bitmap;
        }

        private void ShowNavigationMenu(string controlName)
        {
            //button_Account_Profile

            if (string.IsNullOrEmpty(controlName))
                return;

            var childText = "";
            var parentText = "";
            var strArray = controlName.Split("_");
            var parentControlName = controlName;
            var navigationMenuParentText = "";
            if (strArray.Length > 2)
            {
                Control control = Controls.Find(controlName, true)[0];
                childText = control.GetType().GetProperty("Text").GetValue(control, null).ToString().Trim();
                parentControlName = $"{strArray[0]}_{strArray[1]}";
            }
            ComponentResourceManager res = new ComponentResourceManager(typeof(Frm_Main));
            var str = res.GetString("Custom_Location");
            Control parentControl = Controls.Find(parentControlName, true)[0];
            parentText = parentControl.GetType().GetProperty("Text").GetValue(parentControl, null).ToString().Trim();
            label_ChildHeader_Menu.Text = string.IsNullOrEmpty(childText) ? $"{str}: {parentText}" : $"{str}: {parentText}->{childText}";
        }
        private void HideSubMenu()
        {
            if (panel_SerialCOMSubMenu.Visible == true)
            {
                panel_SerialCOMSubMenu.Visible = false;
            }
            if (panel_AccountSubMenu.Visible == true)
            {
                panel_AccountSubMenu.Visible = false;
            }
            if (panel_SettingSubMenu.Visible == true)
            {
                panel_SettingSubMenu.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

            ChangeSideMenu(200, Properties.Resources.fold_Main_Menu);
        }
        #endregion

        private Panel panel_ChildForm;
        private Panel panel_SideMenu;
        private Panel panel_SettingSubMenu;
        private Button button_Setting_Environment;
        private Button button_Setting;
        private Panel panel_SerialCOMSubMenu;
        private Button button_SerialCOM;
        private Panel panel_AccountSubMenu;
        private Button button_Account_SignOut;
        private Button button_Account;
        private Panel panel_Log;
        private Label label_Environment;
        private PictureBox pictureBox_MainMenu;
        private Panel panel_BottomToolTip;
        private Label label_CurrentUser;
        private PictureBox pictureBox_Close;
        private Label label_CurrentMenu;
        private Panel panel_Header;
        private PictureBox pictureBox_Min;
        private PictureBox pictureBox_Max;
        private Label label_Exit;
        private Label label_DateTime;
        private Button button_Help;
        private Button button_SerialCOM_Burn;
        private Panel panel_ChildHeader;
        private Label label_ChildHeader_Menu;
        private System.Windows.Forms.Timer timer1;
        private Form activeForm = null;
        private Button button_Account_Profile;
        private Button button_SerialCOM_GateWay;
        private Button button_Setting_Application;
        private Button button_Setting_AAD;
    }
}