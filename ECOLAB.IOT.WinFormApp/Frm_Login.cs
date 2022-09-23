using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOLAB.IOT.WinFormApp
{
    public partial class Frm_Login : Form
    {

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            //this.Dispose();
            //this.Close();
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

            var objAdmins = new SysAdmins()
            {
                UserName = this.textBox_UserName.Text.Trim(),
                Pwd = this.textBox_PassWord.Text.Trim()
            };

            var isexist = CallerContext.ECOLABIOTUserService.AdminLogin(objAdmins);
            if (!isexist.HasValue || !isexist.Value)
            {
                this.textBox_UserName.Text = "";
                this.textBox_PassWord.Text = "";
                MessageBox.Show("用户名或密码错误！", "登录提示");

            }
            else
            {
                var environmentVariable = new EnvironmentVariable();
                if (this.radioButton_Product.Checked)
                {
                    environmentVariable.Name = EnvironmentName.PRODUCT;
                }

                ServiceCollectionExtension.GetCurrentServiceCollection()
                    .RegisterCurrentEnvironment(environmentVariable)
                    .RegisterAppsetting(environmentVariable)
                    .RegisterCurrentSysAdmins(objAdmins).Build();
                ServiceCollectionExtension.GetCurrentServiceCollection()
                    .RegisterSecretClient(CallerContext.AppServiceOptionsWrapper).Build();
                this.DialogResult = DialogResult.OK;

            }
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
    }
}
