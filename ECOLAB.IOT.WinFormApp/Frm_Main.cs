using ECOLAB.IOT.Common.Utilities;
using ECOLAB.IOT.Common.Win32;
using ECOLAB.IOT.Service;
using ECOLAB.IOT.WinFormApp.ChildWinForm;
using Microsoft.Identity.Client;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using YamlDotNet.Core.Tokens;
using static System.Windows.Forms.AxHost;

namespace ECOLAB.IOT.WinFormApp
{
    public partial class Frm_Main : Form
    {
        [STAThread]
        static void Main()
        {
            Thread.Sleep(100);
            Process cur = Process.GetCurrentProcess();
            foreach (Process p in Process.GetProcesses())
            {
                if (p.Id == cur.Id) continue;
                if (p.ProcessName == cur.ProcessName)
                {
                    Win32SafeNativeMethods.SetForegroundWindow(p.MainWindowHandle);
                    Win32SafeNativeMethods.SendMessage(p.MainWindowHandle, Win32SafeNativeMethods.WM_SYSCOMMAND, Win32SafeNativeMethods.SC_RESTORE, 0);
                    return;
                }
            }


            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-us");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Frm_Login objFrm = new Frm_Login();

            ServiceCollectionExtension.GetCurrentServiceCollection()
                .ConfigureService().Build();
            ServiceCollectionExtension.GetCurrentServiceCollection()
                .RegisterPublicClientApplication(InitializeAuth())
                .Build();

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
            Thread.CurrentThread.CurrentUICulture = CallerContext.currentCulture;
            InitializeComponent();
            CustomizeDesing();
            SelectLanguage();
            OpenChildForm(new Burn());
            ShowNavigationMenu(button_SerialCOM_Burn.Name);
            HideSubMenu();
            Transmit.Utility.Track($"\n\r UserName:{CallerContext.SysAdmin.UserName} Login in.", true);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label_DateTime.Text = $"{DateTime.Now}";
        }

        private void button_Account_Click(object sender, EventArgs e)
        {
            //ShowNavigationMenu(button_Account.Name);
            ShowSubMenu(panel_AccountSubMenu);
        }
        #region Account sub menu
        private void button_Profile_Click(object sender, EventArgs e)
        {
            ShowNavigationMenu(button_Help_Instruction.Name);
            HideSubMenu();
        }
        private void button_SignOut_Click(object sender, EventArgs e)
        {
            var bl = Logout().Result;
            Process.Start(Application.StartupPath + "\\Ecolink_SNPSK_tool.exe");
            Process.GetCurrentProcess().Kill();
        }

        private async Task<bool> Logout()
        {
            var accounts = await CallerContext.PublicClientApplication.GetAccountsAsync().ConfigureAwait(false);
            if (accounts.Any())
            {
                try
                {
                    await CallerContext.PublicClientApplication.RemoveAsync(accounts.FirstOrDefault()).ConfigureAwait(false);
                    if (File.Exists("Ecolink_SNPSK_tool.dll.msalcache.bin3"))
                    {
                        File.Delete("Ecolink_SNPSK_tool.dll.msalcache.bin3");
                    }
                }
                catch (MsalException ex)
                {
                    throw new Exception($"Error signing-out user: {ex.Message}");
                }
            }

            return await Task.FromResult(true);
        }
        #endregion


        #region  SerialCOM Sub menu
        private void button_SerialCOM_Click(object sender, EventArgs e)
        {
            //ShowNavigationMenu(button_SerialCOM.Name);
            ShowSubMenu(panel_SerialCOMSubMenu);
        }

        //private void button_BurnFile_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new BurnFile());
        //    ShowNavigationMenu(button_SerialCOM_GateWay.Name);
        //    HideSubMenu();
        //}
        #endregion

        private void button_Help_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_Help);
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
            var bl = Logout().Result;
            Application.Exit();
        }

        private void pictureBox_Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                pictureBox_Max.Image = Properties.Resources.Max_Main;
                this.WindowState = FormWindowState.Maximized;
                this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                pictureBox_Max.Image = Properties.Resources.Normal_Main;
                //this.MaximumSize = new Size(0, 0);
                this.WindowState = FormWindowState.Normal;
                int DWidth = Convert.ToInt32(1280 * 0.85);
                int DHeight = Convert.ToInt32(672 * 0.9);

                this.Width = DWidth;
                this.Height = DHeight;
            }
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            var bl = Logout().Result;
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
            int DWidth = Convert.ToInt32(1280 * 0.85);
            int DHeight = Convert.ToInt32(672 * 0.9);

            this.Width = DWidth;
            this.Height = DHeight;
            //int DWidth = Screen.PrimaryScreen.WorkingArea.Width;
            //int DHeight = Screen.PrimaryScreen.WorkingArea.Height;

            //this.Width = DWidth;
            //this.Height = DHeight;
            //if (DWidth >= 1920)
            //{
            //    this.Width = Convert.ToInt32(DWidth * 0.6);
            //    this.Height = Convert.ToInt32(DHeight * 0.6);
            //}
            //else if (DWidth >= 1680)
            //{
            //    this.Width = Convert.ToInt32(DWidth * 0.7);
            //    this.Height = Convert.ToInt32(DHeight * 0.7);
            //}
            //else if (DWidth >= 1440)
            //{
            //    this.Width = Convert.ToInt32(DWidth * 0.8);
            //    this.Height = Convert.ToInt32(DHeight * 0.8);
            //}
            //else
            //{
            //    this.Width = Convert.ToInt32(DWidth * 0.9);
            //    this.Height = Convert.ToInt32(DHeight * 0.9);
            //}
           
            this.timer1.Start();
        }


        private void ToolTip()
        {
            ComponentResourceManager res = new ComponentResourceManager(typeof(Frm_Main));
            var dateString = CallerContext.AppServiceOptions.SecretExpireTime;
            DateTime dt = Convert.ToDateTime(dateString);
            var tooltip = res.GetString("SecretExpire_Message3").Replace("{day}", Utilities.DateDiff(dt, DateTime.Now).ToString()).Replace("{env}", CallerContext.EnvironmentVariable.Name);
            
            if(dt.Date < DateTime.Now.Date)
            {
                var str = res.GetString("SecretExpire_Message2").Replace("{day}", Utilities.DateDiff(dt, DateTime.Now).ToString());
                MessageBox.Show(str, tooltip);
            }
            else if (dt.Date < DateTime.Now.Date.AddDays(14))
            {
                var str = res.GetString("SecretExpire_Message1").Replace("{day}", Utilities.DateDiff(DateTime.Now, dt).ToString());

                MessageBox.Show(str, tooltip, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button_SerialCOM_Burn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Burn());
            ShowNavigationMenu(button_SerialCOM_Burn.Name);
            HideSubMenu();
        }

        private void button_Setting_Application_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ApplicationSetting());
            ShowNavigationMenu(button_Setting_Application.Name);
            HideSubMenu();
        }

        private void button_Setting_AAD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AADSetting());
            ShowNavigationMenu(button_Setting_AAD.Name);
            HideSubMenu();
        }

        private static IPublicClientApplication InitializeAuth()
        {
            var setting = CallerContext.ECOLABIOTADDSettingService.GetAADSetting();
            //Net Framework. Support pop-up window:embedded web brower.
            var clientApp = PublicClientApplicationBuilder.Create(setting.ClientId)
                    .WithDefaultRedirectUri()
                    //.WithRedirectUri(AADSetting.Instance)
                    .WithAuthority(AzureCloudInstance.AzureChina, setting.TenantId)
                    .Build();

            TokenCacheHelper.EnableSerialization(clientApp.UserTokenCache);
            return clientApp;
        }
        private void button_Help_Instruction_Click(object sender, EventArgs e)
        {

        }

        private void button_Help_Troubleshooting_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Frm_Main_Shown(object sender, EventArgs e)
        {
            ToolTip();
        }

        private void button_Setting_DGWMode_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DGWMode());
            ShowNavigationMenu(button_Setting_DGWMode.Name);
            HideSubMenu();
        }
    }
}
