using ECOLAB.IOT.Common.Win32;
using ECOLAB.IOT.Service;
using ECOLAB.IOT.WinFormApp.ChildWinForm;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace ECOLAB.IOT.WinFormApp
{
    public partial class F_Main : Form
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Frm_Login objFrm = new Frm_Login();

            ServiceCollectionExtension.GetCurrentServiceCollection()
                .ConfigureService().Build();

            DialogResult result = objFrm.ShowDialog();

            if (result == DialogResult.OK)//login sucessful
            {
                //show main windows
                F_Main obj = new F_Main();
                Application.Run(obj);

            }
            else
            {
                Application.Exit();
            }
        }

        public F_Main()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_DateTime.Text = $"{DateTime.Now.ToString()}";
        }
        private void CustomizeDesing()
        {
            panel_SerialCOMSubMenu.Visible = false;
            panel_AccountSubMenu.Visible = false;
            panel_SettingSubMenu.Visible = false;

            this.label_CurrentUser.Text = "Current User: " + CallerContext.SysAdmins.UserName;
            this.label_Environment.Text = $"{label_Environment.Text}  ({CallerContext.EnvironmentVariable.Name.ToString()})";
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

        private void button_Account_Click(object sender, EventArgs e)
        {
            //ShowNavigationMenu(button_Account.Name);
            ShowSubMenu(panel_AccountSubMenu);
        }
        #region Account sub menu
        private void button_Profile_Click(object sender, EventArgs e)
        {
            ShowNavigationMenu(button_Account_Profile.Name);
            HideSubMenu();
        }

        private void button_SignOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Process.Start(Application.StartupPath+ "\\ECOLAB.IOT.WinFormApp.exe");
            ShowNavigationMenu(button_Account_SignOut.Name);
            HideSubMenu();
        }
        #endregion

        private void button_BurnSNAndPSK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BurnSNAndPSK());
            ShowNavigationMenu(button_SerialCOM_EDM.Name);
            HideSubMenu();
        }
        #region  SerialCom Sub menu
        private void button_SerialCOM_Click(object sender, EventArgs e)
        {
            //ShowNavigationMenu(button_SerialCOM.Name);
            ShowSubMenu(panel_SerialCOMSubMenu);
        }

        private void button_BurnFile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BurnFile());
            ShowNavigationMenu(button_SerialCOM_GateWay.Name);
            HideSubMenu();
        }
        #endregion

        private void button_Help_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private Form activeForm = null;
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

        private void panel_ChildForm_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWinForm();
        }

        private void panel_SideMenu_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWinForm();
        }

        private void panel_Header_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWinForm();
        }

        private void button_Setting_Click(object sender, EventArgs e)
        {
            //ShowNavigationMenu(button_Setting.Name);
            ShowSubMenu(panel_SettingSubMenu);
        }

        private void button_Environment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EnvironmentSetting());
            ShowNavigationMenu(button_Setting_Environment.Name);
            HideSubMenu();
        }

        private void pictureBox_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pictureBox_Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_MainMenu_Click(object sender, EventArgs e)
        {
            ShowMainMenu();
            HideSubMenu();
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

        private void label_Environment_Click(object sender, EventArgs e)
        {

        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            int DWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int DHeight = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Convert.ToInt32(DWidth * 0.9);
            this.Height = Convert.ToInt32(DHeight * 0.9);
            this.timer1.Start();
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
            if (strArray.Length>2)
            {
                Control control = Controls.Find(controlName, true)[0];
                childText = control.GetType().GetProperty("Text").GetValue(control, null).ToString().Trim();
                parentControlName = $"{strArray[0]}_{strArray[1]}";
            }

            Control parentControl = Controls.Find(parentControlName, true)[0];
            parentText = parentControl.GetType().GetProperty("Text").GetValue(parentControl, null).ToString().Trim();
            label_ChildHeader_Menu.Text=string.IsNullOrEmpty(childText)? $"Location: {parentText}": $"Location: {parentText}->{childText}";
        }
    }
}
