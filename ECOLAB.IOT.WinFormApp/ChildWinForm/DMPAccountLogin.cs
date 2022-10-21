using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class DMPAccountLogin : Form
    {
        public DMPAccountLogin(Frm_Login frm_Login)
        {
            InitializeComponent();
            Frm_Login = frm_Login;
        }

        private Frm_Login Frm_Login;
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
                return;
            }

            if (Frm_Login != null)
            {
                Frm_Login.Login(objAdmin, null);
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

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            var accountLogin = new AccountLogin(Frm_Login);
            Frm_Login.OpenChildForm(accountLogin, null);
        }

       
    }
}
