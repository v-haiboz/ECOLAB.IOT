using ECOLAB.IOT.Common.Win32;
using ECOLAB.IOT.Service;
using ECOLAB.IOT.WinFormApp.ChildWinForm;
using Sunny.UI;

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
        private void CustomizeDesing()
        {
            panel_SerialCOMSubMenu.Visible = false;
            panel_AccountSubMenu.Visible = false;
            panel_SettingSubMenu.Visible = false;

            this.label_CurrentUser.Text = "Current User: "+ CallerContext.SysAdmins.UserName;
            this.label_DateTime.Text = DateTime.Now.ToString();
            this.label_Environment.Text =$"{label_Environment.Text}  ({CallerContext.EnvironmentVariable.Name.ToString()})";
        }

        private void HideSubMenu()
        {
            if (panel_SerialCOMSubMenu.Visible == true)
            {
                panel_SerialCOMSubMenu.Visible = false;
            }
            if(panel_AccountSubMenu.Visible == true)
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
            ShowSubMenu(panel_AccountSubMenu);
        }
        #region Account sub menu
        private void button_Profile_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button_SignOut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        private void button_BurnSNAndPSK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BurnSNAndPSK());
            HideSubMenu();
        }
        #region  SerialCom Sub menu
        private void button_SerialCOM_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_SerialCOMSubMenu);
        }

        private void button_BurnFile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BurnFile());
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
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
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
            ShowSubMenu(panel_SettingSubMenu);
        }

        private void button_Environment_Click(object sender, EventArgs e)
        {
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
        //    if (this.WindowState == FormWindowState.Maximized)
        //    {
        //        pictureBox_Max.Image = Properties.Resources.Max_Main;
        //        int DWidth = Screen.PrimaryScreen.WorkingArea.Width;
        //        int DHeight = Screen.PrimaryScreen.WorkingArea.Height;
        //        this.Width = Convert.ToInt32(DWidth * 0.5);
        //        this.Height = Convert.ToInt32(DHeight * 0.5);
        //    }
        //    else
        //    {
        //        this.WindowState = FormWindowState.Maximized;
        //        pictureBox_Max.Image = Properties.Resources.narrow_Main;
        //    }
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
    }
}
