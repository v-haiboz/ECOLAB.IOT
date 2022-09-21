using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;

namespace ECOLAB.IOT.WinFormApp
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void uiButton_Submit_Click(object sender, EventArgs e)
        {
            if (!CheckValidate())
            {
                return;
            }

            var objAdmins = new SysAdmins()
            {
                UserName = this.uiTextBox_UserName.Text.Trim(),
                Pwd = this.uiTextBox_Password.Text.Trim()
            };

            var isexist = CallerContext.ECOLABIOTUserService.AdminLogin(objAdmins);
            if (!isexist.HasValue || !isexist.Value)
            {
                this.uiTextBox_UserName.Text = "";
                this.uiTextBox_Password.Text = "";
                MessageBox.Show("用户名或密码错误！", "登录提示");

            }
            else
            {
                var environmentVariable = new EnvironmentVariable();
                if (this.uiRadioButton_Product.Checked)
                {
                    environmentVariable.Name = EnvironmentName.PRODUCT;
                }

                ServiceCollectionExtension.GetCurrentServiceCollection()
                    .RegisterCurrentEnvironment(environmentVariable)
                    .RegisterAppsetting(environmentVariable)
                    .RegisterCurrentSysAdmins(objAdmins);

                this.DialogResult = DialogResult.OK;

            }
        }

        private void uiButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
            this.Close();
        }

        private bool CheckValidate()
        {
            if (this.uiTextBox_UserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写用户名！", "登录提示");
                this.uiTextBox_UserName.Focus();
                return false;
            }
            if (this.uiTextBox_Password.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码！", "登录提示");
                this.uiTextBox_Password.Focus();
                return false;
            }

            return true;
        }
    }
}
