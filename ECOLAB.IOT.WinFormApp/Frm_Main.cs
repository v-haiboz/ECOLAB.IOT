using ECOLAB.IOT.WinFormApp.ChildWinForm;
using System.Diagnostics;

namespace ECOLAB.IOT.WinFormApp
{
    public partial class Frm_Main : Form
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
                Frm_Main obj = new Frm_Main();
                Application.Run(obj);

            }
            else
            {
                Application.Exit();
            }
        }

        public Frm_Main()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_DateTime.Text = $"{DateTime.Now.ToString()}";
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


        #region  SerialCOM Sub menu
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

        private void button_SerialCOM_Burn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Burn());
            ShowNavigationMenu(button_SerialCOM_Burn.Name);
            HideSubMenu();
        }
    }
}
