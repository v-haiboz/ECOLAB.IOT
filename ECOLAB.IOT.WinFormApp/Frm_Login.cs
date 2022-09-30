using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
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
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Min_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (!CheckValidate())
            {
                return;
            }

            var objAdmin = new SysAdmin()
            {
                UserName = this.textBox_UserName.Text.Trim(),
                Pwd = this.textBox_PassWord.Text.Trim()
            };

            var isexist = CallerContext.ECOLABIOTUserService.AdminLogin(objAdmin);
            if (!isexist.HasValue || !isexist.Value)
            {
                this.textBox_UserName.Text = "";
                this.textBox_PassWord.Text = "";
                MessageBox.Show("用户名或密码错误！", "登录提示");

            }
            else
            {
                var currentUser = CallerContext.ECOLABIOTUserService.GetUser(objAdmin);
                var environmentVariable = CallerContext.ECOLABIOTEnvironmentService.GetEnvironmentVariableByName(comboBox_Env.Text); ;
                ServiceCollectionExtension.GetCurrentServiceCollection()
                    .RegisterCurrentEnvironment(environmentVariable)
                    .RegisterAppsetting(environmentVariable)
                    .RegisterCurrentSysAdmins(currentUser).Build();
                ServiceCollectionExtension.GetCurrentServiceCollection()
                    .RegisterSecretClient(CallerContext.AppServiceOptions).Build();
                this.DialogResult = DialogResult.OK;

            }
        }
        private void Init()
        {
            comboBox_Env.Items.Clear();
            var items = CallerContext.ECOLABIOTEnvironmentService.GetEnvironmentVariables();
            comboBox_Env.DataSource=items;
            comboBox_Env.ValueMember = "FileName";
            comboBox_Env.DisplayMember = "Name";
        }
        private bool CheckValidate()
        {
            if (this.textBox_UserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写用户名！", "登录提示");
                this.textBox_UserName.Focus();
                return false;
            }
            if (this.textBox_PassWord.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码！", "登录提示");
                this.textBox_PassWord.Focus();
                return false;
            }

            return true;
        }

        private void radioButton_English_CheckedChanged(object sender, EventArgs e)
        {
            SelectLanguage();
        }

        private void radioButton_Chinese_CheckedChanged(object sender, EventArgs e)
        {
            SelectLanguage();
        }

        private void SelectLanguage()
        {
            if (radioButton_English.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-us");
                CallerContext.currentCulture= CultureInfo.GetCultureInfo("en-us");
                
            }
            if (radioButton_Chinese.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-cn");
                CallerContext.currentCulture = CultureInfo.GetCultureInfo("zh-cn");
            }
            ReloadText();
           // ApplyResource();
        }

        private void ReloadText()
        {
            button_Cancel.Text = res.GetString("button_Cancel.Text");
            button_Login.Text = res.GetString("button_Login.Text");
            label_Header.Text = res.GetString("label_Header.Text");
            label_Password.Text = res.GetString("label_Password.Text");
            label_Username.Text = res.GetString("label_Username.Text");
            radioButton_Chinese.Text  = res.GetString("radioButton_Chinese.Text"); 
            radioButton_English.Text = res.GetString("radioButton_English.Text");
        }
        private void ApplyResource()
        {
            var size = this.Size;
            ComponentResourceManager res = new ComponentResourceManager(typeof(Frm_Login));
            foreach (Control ctl in Controls)
            {
                if (ctl is GroupBox)
                {
                    res.ApplyResources(ctl, ctl.Name);
                    GroupBox g = ctl as GroupBox;
                    foreach (Control item in g.Controls)
                    {
                        res.ApplyResources(item, item.Name);
                    }
                }
                else
                {
                    res.ApplyResources(ctl, ctl.Name);
                }
            }
            this.ResumeLayout(false);
            this.PerformLayout();
            res.ApplyResources(this, "$this");
            this.Size = size;
        }
    }
}
