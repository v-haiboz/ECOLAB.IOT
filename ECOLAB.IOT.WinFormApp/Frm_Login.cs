using ECOLAB.IOT.Common.Win32;
using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using ECOLAB.IOT.WinFormApp.ChildWinForm;
using System.ComponentModel;
using System.Globalization;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ECOLAB.IOT.WinFormApp
{
    public partial class Frm_Login : Form
    {
        ComponentResourceManager res = new ComponentResourceManager(typeof(Frm_Login));
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            Init();
            var accountLogin = new AccountLogin(this);
            OpenChildForm(accountLogin, null);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public void Login(SysAdmin sysAdmin, EventArgs e)
        {
            var environmentVariable = CallerContext.ECOLABIOTEnvironmentService.GetEnvironmentVariableByName(comboBox_Env.Text);
            ServiceCollectionExtension.GetCurrentServiceCollection()
                .RegisterCurrentEnvironment(environmentVariable)
                .RegisterAppsetting(environmentVariable)
                .RegisterCurrentSysAdmins(sysAdmin).Build();
            ServiceCollectionExtension.GetCurrentServiceCollection()
                .RegisterSecretClient(CallerContext.AppServiceOptions).Build();
            this.DialogResult = DialogResult.OK;
        }
        private void Init()
        {
            comboBox_Env.Items.Clear();
            var items = CallerContext.ECOLABIOTEnvironmentService.GetEnvironmentVariables();
            comboBox_Env.DataSource = items;
            comboBox_Env.ValueMember = "FileName";
            comboBox_Env.DisplayMember = "Name";
        }


        private void radioButton_English_CheckedChanged(object sender, EventArgs e)
        {
            SelectLanguage();
        }

        private void radioButton_Chinese_CheckedChanged(object sender, EventArgs e)
        {
            SelectLanguage();
        }
        private void MoveWinForm()
        {
            Win32SafeNativeMethods.ReleaseCapture();
            Win32SafeNativeMethods.SendMessage(this.Handle, Win32SafeNativeMethods.WM_SYSCOMMAND, Win32SafeNativeMethods.SC_MOVE + Win32SafeNativeMethods.HTCAPTION, 0);
        }
        private void SelectLanguage()
        {
            if (radioButton_English.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-us");
                CallerContext.currentCulture = CultureInfo.GetCultureInfo("en-us");

            }
            if (radioButton_Chinese.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-cn");
                CallerContext.currentCulture = CultureInfo.GetCultureInfo("zh-cn");
            }
            ReloadText();
        }

        private void ReloadText()
        {
            label_Header.Text = res.GetString("label_Header.Text");
            radioButton_Chinese.Text = res.GetString("radioButton_Chinese.Text");
            radioButton_English.Text = res.GetString("radioButton_English.Text");
            if (activeForm is DMPAccountLogin)
            {
                var dmpAccountLogin = activeForm as DMPAccountLogin;
                if (dmpAccountLogin != null)
                {
                    dmpAccountLogin.button_Cancel.Text = res.GetString("button_Cancel.Text");
                    dmpAccountLogin.button_Login.Text = res.GetString("button_Login.Text");
                    dmpAccountLogin.label_Password.Text = res.GetString("label_Password.Text");
                    dmpAccountLogin.label_Username.Text = res.GetString("label_Username.Text");
                }
            }
            else if (activeForm is AccountLogin)
            {
                var acccoutLogin = activeForm as AccountLogin;
                if (acccoutLogin != null)
                {
                    acccoutLogin.button_DMPAccountLogin.Text = res.GetString("button_DMPAccountLogin.Text");
                    acccoutLogin.button_ECOLABAcountLogin.Text = res.GetString("button_ECOLABAcountLogin.Text");
                }
            }
        }

        private Form activeForm = null;
        public void OpenChildForm(object form, EventArgs e)
        {
            var childForm = (Form)form;
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Login.Controls.Add(childForm);
            panel_Login.Tag = childForm;
            childForm.BringToFront();
            SelectLanguage();
            childForm.Show();
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWinForm();
        }
    }
}
