using ECOLAB.IOT.Common.Win32;
using ECOLAB.IOT.Service;

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
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.panel_ChildHeader = new System.Windows.Forms.Panel();
            this.label_ChildHeader_Menu = new System.Windows.Forms.Label();
            this.panel_SideMenu = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.panel_SettingSubMenu = new System.Windows.Forms.Panel();
            this.button_Setting_Environment = new System.Windows.Forms.Button();
            this.button_Setting = new System.Windows.Forms.Button();
            this.panel_SerialCOMSubMenu = new System.Windows.Forms.Panel();
            this.button_SerialCOM_Burn = new System.Windows.Forms.Button();
            this.button_SerialCOM_GateWay = new System.Windows.Forms.Button();
            this.button_SerialCOM = new System.Windows.Forms.Button();
            this.panel_AccountSubMenu = new System.Windows.Forms.Panel();
            this.button_Account_SignOut = new System.Windows.Forms.Button();
            this.button_Account_Profile = new System.Windows.Forms.Button();
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
            this.panel_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildForm.Location = new System.Drawing.Point(0, 44);
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.Size = new System.Drawing.Size(1500, 756);
            this.panel_ChildForm.TabIndex = 1;
            this.panel_ChildForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_ChildForm_MouseDown);
            // 
            // panel_ChildHeader
            // 
            this.panel_ChildHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.panel_ChildHeader.Controls.Add(this.label_ChildHeader_Menu);
            this.panel_ChildHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_ChildHeader.ForeColor = System.Drawing.Color.White;
            this.panel_ChildHeader.Location = new System.Drawing.Point(285, 0);
            this.panel_ChildHeader.Name = "panel_ChildHeader";
            this.panel_ChildHeader.Size = new System.Drawing.Size(1215, 45);
            this.panel_ChildHeader.TabIndex = 6;
            // 
            // label_ChildHeader_Menu
            // 
            this.label_ChildHeader_Menu.AutoSize = true;
            this.label_ChildHeader_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ChildHeader_Menu.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ChildHeader_Menu.Location = new System.Drawing.Point(0, 0);
            this.label_ChildHeader_Menu.Name = "label_ChildHeader_Menu";
            this.label_ChildHeader_Menu.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.label_ChildHeader_Menu.Size = new System.Drawing.Size(20, 34);
            this.label_ChildHeader_Menu.TabIndex = 0;
            // 
            // panel_SideMenu
            // 
            this.panel_SideMenu.AutoScroll = true;
            this.panel_SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panel_SideMenu.Controls.Add(this.button_Help);
            this.panel_SideMenu.Controls.Add(this.panel_SettingSubMenu);
            this.panel_SideMenu.Controls.Add(this.button_Setting);
            this.panel_SideMenu.Controls.Add(this.panel_SerialCOMSubMenu);
            this.panel_SideMenu.Controls.Add(this.button_SerialCOM);
            this.panel_SideMenu.Controls.Add(this.panel_AccountSubMenu);
            this.panel_SideMenu.Controls.Add(this.button_Account);
            this.panel_SideMenu.Controls.Add(this.panel_Log);
            this.panel_SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SideMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_SideMenu.Name = "panel_SideMenu";
            this.panel_SideMenu.Size = new System.Drawing.Size(285, 718);
            this.panel_SideMenu.TabIndex = 5;
            // 
            // button_Help
            // 
            this.button_Help.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Help.FlatAppearance.BorderSize = 0;
            this.button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Help.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Help.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.help_Main;
            this.button_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Help.Location = new System.Drawing.Point(0, 434);
            this.button_Help.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button_Help.Name = "button_Help";
            this.button_Help.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Help.Size = new System.Drawing.Size(285, 45);
            this.button_Help.TabIndex = 7;
            this.button_Help.Text = "           Help";
            this.button_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Help.UseVisualStyleBackColor = true;
            // 
            // panel_SettingSubMenu
            // 
            this.panel_SettingSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_SettingSubMenu.Controls.Add(this.button_Setting_Environment);
            this.panel_SettingSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SettingSubMenu.Location = new System.Drawing.Point(0, 385);
            this.panel_SettingSubMenu.Name = "panel_SettingSubMenu";
            this.panel_SettingSubMenu.Size = new System.Drawing.Size(285, 49);
            this.panel_SettingSubMenu.TabIndex = 0;
            // 
            // button_Setting_Environment
            // 
            this.button_Setting_Environment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Setting_Environment.FlatAppearance.BorderSize = 0;
            this.button_Setting_Environment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting_Environment.ForeColor = System.Drawing.Color.White;
            this.button_Setting_Environment.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.setting_environment_Main;
            this.button_Setting_Environment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Setting_Environment.Location = new System.Drawing.Point(0, 0);
            this.button_Setting_Environment.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button_Setting_Environment.Name = "button_Setting_Environment";
            this.button_Setting_Environment.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.button_Setting_Environment.Size = new System.Drawing.Size(285, 49);
            this.button_Setting_Environment.TabIndex = 0;
            this.button_Setting_Environment.Text = "           Environment";
            this.button_Setting_Environment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Setting_Environment.UseVisualStyleBackColor = true;
            this.button_Setting_Environment.Click += new System.EventHandler(this.button_Environment_Click);
            // 
            // button_Setting
            // 
            this.button_Setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Setting.FlatAppearance.BorderSize = 0;
            this.button_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Setting.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.setting_Main;
            this.button_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Setting.Location = new System.Drawing.Point(0, 340);
            this.button_Setting.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Setting.Size = new System.Drawing.Size(285, 45);
            this.button_Setting.TabIndex = 5;
            this.button_Setting.Text = "           Setting";
            this.button_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Setting.UseVisualStyleBackColor = true;
            this.button_Setting.Click += new System.EventHandler(this.button_Setting_Click);
            // 
            // panel_SerialCOMSubMenu
            // 
            this.panel_SerialCOMSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_SerialCOMSubMenu.Controls.Add(this.button_SerialCOM_Burn);
            this.panel_SerialCOMSubMenu.Controls.Add(this.button_SerialCOM_GateWay);
            this.panel_SerialCOMSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SerialCOMSubMenu.Location = new System.Drawing.Point(0, 249);
            this.panel_SerialCOMSubMenu.Name = "panel_SerialCOMSubMenu";
            this.panel_SerialCOMSubMenu.Size = new System.Drawing.Size(285, 91);
            this.panel_SerialCOMSubMenu.TabIndex = 4;
            // 
            // button_SerialCOM_Burn
            // 
            this.button_SerialCOM_Burn.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_SerialCOM_Burn.FlatAppearance.BorderSize = 0;
            this.button_SerialCOM_Burn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SerialCOM_Burn.ForeColor = System.Drawing.Color.White;
            this.button_SerialCOM_Burn.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.feature_device_Main;
            this.button_SerialCOM_Burn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SerialCOM_Burn.Location = new System.Drawing.Point(0, 45);
            this.button_SerialCOM_Burn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button_SerialCOM_Burn.Name = "button_SerialCOM_Burn";
            this.button_SerialCOM_Burn.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.button_SerialCOM_Burn.Size = new System.Drawing.Size(285, 45);
            this.button_SerialCOM_Burn.TabIndex = 4;
            this.button_SerialCOM_Burn.Text = "           Burn";
            this.button_SerialCOM_Burn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SerialCOM_Burn.UseVisualStyleBackColor = true;
            this.button_SerialCOM_Burn.Click += new System.EventHandler(this.button_SerialCOM_Burn_Click);
            // 
            // button_SerialCOM_GateWay
            // 
            this.button_SerialCOM_GateWay.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_SerialCOM_GateWay.FlatAppearance.BorderSize = 0;
            this.button_SerialCOM_GateWay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SerialCOM_GateWay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_SerialCOM_GateWay.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.feature_file_Main;
            this.button_SerialCOM_GateWay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SerialCOM_GateWay.Location = new System.Drawing.Point(0, 0);
            this.button_SerialCOM_GateWay.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button_SerialCOM_GateWay.Name = "button_SerialCOM_GateWay";
            this.button_SerialCOM_GateWay.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.button_SerialCOM_GateWay.Size = new System.Drawing.Size(285, 45);
            this.button_SerialCOM_GateWay.TabIndex = 3;
            this.button_SerialCOM_GateWay.Text = "           BurnFile";
            this.button_SerialCOM_GateWay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SerialCOM_GateWay.UseVisualStyleBackColor = true;
            this.button_SerialCOM_GateWay.Click += new System.EventHandler(this.button_BurnFile_Click);
            // 
            // button_SerialCOM
            // 
            this.button_SerialCOM.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_SerialCOM.FlatAppearance.BorderSize = 0;
            this.button_SerialCOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SerialCOM.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_SerialCOM.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.feature_Main;
            this.button_SerialCOM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SerialCOM.Location = new System.Drawing.Point(0, 204);
            this.button_SerialCOM.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button_SerialCOM.Name = "button_SerialCOM";
            this.button_SerialCOM.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_SerialCOM.Size = new System.Drawing.Size(285, 45);
            this.button_SerialCOM.TabIndex = 3;
            this.button_SerialCOM.Text = "           SerialCOM";
            this.button_SerialCOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SerialCOM.UseVisualStyleBackColor = true;
            this.button_SerialCOM.Click += new System.EventHandler(this.button_SerialCOM_Click);
            // 
            // panel_AccountSubMenu
            // 
            this.panel_AccountSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_AccountSubMenu.Controls.Add(this.button_Account_SignOut);
            this.panel_AccountSubMenu.Controls.Add(this.button_Account_Profile);
            this.panel_AccountSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_AccountSubMenu.Location = new System.Drawing.Point(0, 113);
            this.panel_AccountSubMenu.Name = "panel_AccountSubMenu";
            this.panel_AccountSubMenu.Size = new System.Drawing.Size(285, 91);
            this.panel_AccountSubMenu.TabIndex = 2;
            // 
            // button_Account_SignOut
            // 
            this.button_Account_SignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Account_SignOut.FlatAppearance.BorderSize = 0;
            this.button_Account_SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Account_SignOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Account_SignOut.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.account_signout_Main;
            this.button_Account_SignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Account_SignOut.Location = new System.Drawing.Point(0, 45);
            this.button_Account_SignOut.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button_Account_SignOut.Name = "button_Account_SignOut";
            this.button_Account_SignOut.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.button_Account_SignOut.Size = new System.Drawing.Size(285, 45);
            this.button_Account_SignOut.TabIndex = 3;
            this.button_Account_SignOut.Text = "           SignOut";
            this.button_Account_SignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Account_SignOut.UseVisualStyleBackColor = true;
            this.button_Account_SignOut.Click += new System.EventHandler(this.button_SignOut_Click);
            // 
            // button_Account_Profile
            // 
            this.button_Account_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Account_Profile.FlatAppearance.BorderSize = 0;
            this.button_Account_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Account_Profile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Account_Profile.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.account_profile_Main;
            this.button_Account_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Account_Profile.Location = new System.Drawing.Point(0, 0);
            this.button_Account_Profile.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button_Account_Profile.Name = "button_Account_Profile";
            this.button_Account_Profile.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.button_Account_Profile.Size = new System.Drawing.Size(285, 45);
            this.button_Account_Profile.TabIndex = 2;
            this.button_Account_Profile.Text = "           Profile";
            this.button_Account_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Account_Profile.UseVisualStyleBackColor = true;
            this.button_Account_Profile.Click += new System.EventHandler(this.button_Profile_Click);
            // 
            // button_Account
            // 
            this.button_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.button_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Account.FlatAppearance.BorderSize = 0;
            this.button_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Account.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Account.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.account_Main;
            this.button_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Account.Location = new System.Drawing.Point(0, 68);
            this.button_Account.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button_Account.Name = "button_Account";
            this.button_Account.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Account.Size = new System.Drawing.Size(285, 45);
            this.button_Account.TabIndex = 1;
            this.button_Account.Text = "           Account";
            this.button_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Account.UseVisualStyleBackColor = false;
            this.button_Account.Click += new System.EventHandler(this.button_Account_Click);
            // 
            // panel_Log
            // 
            this.panel_Log.Controls.Add(this.label_Environment);
            this.panel_Log.Controls.Add(this.pictureBox_MainMenu);
            this.panel_Log.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Log.Location = new System.Drawing.Point(0, 0);
            this.panel_Log.Name = "panel_Log";
            this.panel_Log.Size = new System.Drawing.Size(285, 68);
            this.panel_Log.TabIndex = 1;
            // 
            // label_Environment
            // 
            this.label_Environment.AutoSize = true;
            this.label_Environment.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Environment.ForeColor = System.Drawing.Color.White;
            this.label_Environment.Location = new System.Drawing.Point(78, 20);
            this.label_Environment.Name = "label_Environment";
            this.label_Environment.Size = new System.Drawing.Size(65, 25);
            this.label_Environment.TabIndex = 0;
            this.label_Environment.Text = "Menu";
            this.label_Environment.Click += new System.EventHandler(this.label_Environment_Click);
            // 
            // pictureBox_MainMenu
            // 
            this.pictureBox_MainMenu.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.fold_Main_Menu;
            this.pictureBox_MainMenu.Location = new System.Drawing.Point(22, 12);
            this.pictureBox_MainMenu.Name = "pictureBox_MainMenu";
            this.pictureBox_MainMenu.Size = new System.Drawing.Size(38, 38);
            this.pictureBox_MainMenu.TabIndex = 0;
            this.pictureBox_MainMenu.TabStop = false;
            this.pictureBox_MainMenu.Click += new System.EventHandler(this.pictureBox_MainMenu_Click);
            // 
            // panel_BottomToolTip
            // 
            this.panel_BottomToolTip.BackColor = System.Drawing.Color.Purple;
            this.panel_BottomToolTip.Controls.Add(this.label_DateTime);
            this.panel_BottomToolTip.Controls.Add(this.label_Exit);
            this.panel_BottomToolTip.Controls.Add(this.label_CurrentUser);
            this.panel_BottomToolTip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_BottomToolTip.Location = new System.Drawing.Point(0, 718);
            this.panel_BottomToolTip.Name = "panel_BottomToolTip";
            this.panel_BottomToolTip.Size = new System.Drawing.Size(1500, 38);
            this.panel_BottomToolTip.TabIndex = 4;
            // 
            // label_DateTime
            // 
            this.label_DateTime.AutoSize = true;
            this.label_DateTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_DateTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DateTime.ForeColor = System.Drawing.Color.White;
            this.label_DateTime.Location = new System.Drawing.Point(1296, 0);
            this.label_DateTime.Name = "label_DateTime";
            this.label_DateTime.Padding = new System.Windows.Forms.Padding(0, 3, 50, 0);
            this.label_DateTime.Size = new System.Drawing.Size(143, 27);
            this.label_DateTime.TabIndex = 13;
            this.label_DateTime.Text = "DateTime";
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Exit.ForeColor = System.Drawing.Color.White;
            this.label_Exit.Location = new System.Drawing.Point(1439, 0);
            this.label_Exit.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Padding = new System.Windows.Forms.Padding(0, 3, 20, 0);
            this.label_Exit.Size = new System.Drawing.Size(61, 27);
            this.label_Exit.TabIndex = 12;
            this.label_Exit.Text = "Exit";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // label_CurrentUser
            // 
            this.label_CurrentUser.AutoSize = true;
            this.label_CurrentUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_CurrentUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_CurrentUser.ForeColor = System.Drawing.Color.White;
            this.label_CurrentUser.Location = new System.Drawing.Point(0, 0);
            this.label_CurrentUser.Name = "label_CurrentUser";
            this.label_CurrentUser.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label_CurrentUser.Size = new System.Drawing.Size(122, 27);
            this.label_CurrentUser.TabIndex = 10;
            this.label_CurrentUser.Text = "Current User:";
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_Close.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.Close_Main;
            this.pictureBox_Close.Location = new System.Drawing.Point(1458, 0);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.pictureBox_Close.Size = new System.Drawing.Size(42, 44);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 9;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // label_CurrentMenu
            // 
            this.label_CurrentMenu.AutoSize = true;
            this.label_CurrentMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_CurrentMenu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_CurrentMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_CurrentMenu.Location = new System.Drawing.Point(0, 0);
            this.label_CurrentMenu.Name = "label_CurrentMenu";
            this.label_CurrentMenu.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label_CurrentMenu.Size = new System.Drawing.Size(250, 31);
            this.label_CurrentMenu.TabIndex = 12;
            this.label_CurrentMenu.Text = "IOT Management Tool";
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panel_Header.Controls.Add(this.pictureBox_Min);
            this.panel_Header.Controls.Add(this.pictureBox_Max);
            this.panel_Header.Controls.Add(this.label_CurrentMenu);
            this.panel_Header.Controls.Add(this.pictureBox_Close);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1500, 44);
            this.panel_Header.TabIndex = 2;
            this.panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseDown);
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Min.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_Min.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.Min_Main;
            this.pictureBox_Min.Location = new System.Drawing.Point(1370, 0);
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.pictureBox_Min.Size = new System.Drawing.Size(45, 44);
            this.pictureBox_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Min.TabIndex = 14;
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Click += new System.EventHandler(this.pictureBox_Min_Click);
            // 
            // pictureBox_Max
            // 
            this.pictureBox_Max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Max.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_Max.Image = global::ECOLAB.IOT.WinFormApp.Properties.Resources.Max_Main;
            this.pictureBox_Max.Location = new System.Drawing.Point(1415, 0);
            this.pictureBox_Max.Name = "pictureBox_Max";
            this.pictureBox_Max.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pictureBox_Max.Size = new System.Drawing.Size(43, 44);
            this.pictureBox_Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Max.TabIndex = 13;
            this.pictureBox_Max.TabStop = false;
            this.pictureBox_Max.Click += new System.EventHandler(this.pictureBox_Max_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Main";
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

            Control parentControl = Controls.Find(parentControlName, true)[0];
            parentText = parentControl.GetType().GetProperty("Text").GetValue(parentControl, null).ToString().Trim();
            label_ChildHeader_Menu.Text = string.IsNullOrEmpty(childText) ? $"Location: {parentText}" : $"Location: {parentText}->{childText}";
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
        private Button button_SerialCOM_GateWay;
        private Button button_SerialCOM;
        private Panel panel_AccountSubMenu;
        private Button button_Account_SignOut;
        private Button button_Account_Profile;
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
    }
}