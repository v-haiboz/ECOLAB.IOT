using ECOLAB.IOT.Service;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class AADSetting : Form
    {
        public AADSetting()
        {
            InitializeComponent();
            Clear();
            Bangding();
        }

        private void Bangding()
        {
            var setting = CallerContext.ECOLABIOTADDSettingService.GetAADSetting();
            if (setting != null
                && (!string.IsNullOrEmpty(setting.ClientId) 
                || !string.IsNullOrEmpty(setting.TenantId) 
                || !string.IsNullOrEmpty(setting.Instance)))
            {
                textBox_ClientId.Text = setting.ClientId;
                textBox_TentId.Text = setting.TenantId;
                richTextBox_Instance.Text = setting.Instance;
                EnableOrDisableControl(false);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
            {
                return;
            }

            CallerContext.ECOLABIOTADDSettingService.AddOrUpdateAADSetting(new Entity.AADSetting()
            {
                ClientId = textBox_ClientId.Text,
                TenantId = textBox_TentId.Text,
                Instance = richTextBox_Instance.Text
            });

            EnableOrDisableControl(false);
        }

        private void EnableOrDisableControl(bool bl = true)
        {
            if (CallerContext.SysAdmin.IsSuper)
            {
                button_Save.Visible = true;
                button_Modify.Visible = true;
            }
            else
            {
                button_Save.Visible = false;
                button_Modify.Visible = false; ;
            }
            textBox_ClientId.Enabled = bl;
            textBox_TentId.Enabled = bl;
            richTextBox_Instance.Enabled = bl;
            button_Save.Enabled = bl;
            button_Modify.Enabled = !bl;
            if (button_Save.Enabled)
            {
                button_Save.BackColor = Color.FromArgb(0, 192, 0);
            }
            else {
                button_Save.BackColor = Color.DarkGray;
            }
            if (button_Modify.Enabled)
            {
                button_Modify.BackColor= Color.FromArgb(0, 192, 0);
            }
            else
            {
                button_Modify.BackColor = Color.DarkGray;
            }
            this.label_ADDClientId.Focus();
        }

        private bool ValidateAll()
        {
            return ValidateClientId()
                   & ValidateTenantId()
                   & ValidateInstanceUrl();
        }

        private bool ValidateClientId()
        {
            if (string.IsNullOrEmpty(textBox_ClientId.Text))
            {
                label_ClientId.Text = "ClientId is required.";
                return false;
            }

            label_ClientId.Text = "";
            return true;
        }
        private bool ValidateTenantId()
        {
            if (string.IsNullOrEmpty(textBox_TentId.Text))
            {
                label_TentId.Text = "TentId is required.";
                return false;
            }

            label_TentId.Text = "";
            return true;
        }
        private bool ValidateInstanceUrl()
        {
            if (string.IsNullOrEmpty(richTextBox_Instance.Text))
            {
                label_Instance.Text = "Instance is required.";
                return false;
            }

            label_Instance.Text = "";
            return true;
        }

        private void Clear()
        {
            label_ClientId.Text = "";
            label_Instance.Text = "";
            label_TentId.Text = "";
        }
        private void textBox_TentId_TextChanged(object sender, EventArgs e)
        {
            ValidateTenantId();
        }

        private void textBox_ClientId_TextChanged(object sender, EventArgs e)
        {
            ValidateClientId();
        }

        private void richTextBox_Instance_TextChanged(object sender, EventArgs e)
        {
            ValidateInstanceUrl();
        }

        private void textBox_TentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTenantId();
        }

        private void textBox_ClientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateClientId();
        }

        private void richTextBox_Instance_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInstanceUrl();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            EnableOrDisableControl(true);
        }
    }
}
