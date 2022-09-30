using ECOLAB.IOT.Common;
using ECOLAB.IOT.Common.Utilities;
using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using System.Data;
using System.Text.RegularExpressions;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class EnvironmentSetting : Form
    {
        public EnvironmentSetting()
        {
            InitializeComponent();
            BangDing();
        }
        private void BangDing()
        {
            this.dataGridView_Environment.DataSource = null;
            dataGridView_Environment.Columns.Clear();
            dataGridView_Environment.ClearSelection();
            var list = CallerContext.ECOLABIOTEnvironmentService.GetEnvironmentVariables();

            var dataSource = list.Select(item => new
            {
                Name = item.Name,
                ClientId = item.AppServiceOption.ClientId,
                ClientSecret = !CallerContext.SysAdmin.IsSuper && item.Name.Trim() == "Product" ? ReplaceChar(item.AppServiceOption.ClientSecret) : item.AppServiceOption.ClientSecret,
                TenantId = item.AppServiceOption.TenantId,
                KeyValutUri = item.AppServiceOption.KeyValutUrl,
                DeviceType = item.AppServiceOption.DeviceType,
                PlatformName = item.AppServiceOption.PlatformName,
                DeviceRegisterUri = !CallerContext.SysAdmin.IsSuper && item.Name.Trim() == "Product" ? ReplaceChar(item.AppServiceOption.DeviceRegisterUrl, @"^[a-zA-Z0-9][-a-zA-Z0-9]{0,62}(\.[a-zA-Z0-9][-a-zA-Z0-9]{0,62})+$") : item.AppServiceOption.DeviceRegisterUrl
            }).ToList();

            this.dataGridView_Environment.DataSource = dataSource;

            dataGridView_Environment.Columns[0].Width = 60;
            dataGridView_Environment.Columns[1].Width = 100;
            dataGridView_Environment.Columns[2].Width = 100;
            dataGridView_Environment.Columns[3].Width = 100;
            dataGridView_Environment.Columns[4].Width = 100;
            dataGridView_Environment.Columns[5].Width = 100;
            dataGridView_Environment.Columns[6].Width = 100;
            dataGridView_Environment.Columns[7].Width = 100;
            dataGridView_Environment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private string ReplaceChar(string str, string patten = @".?", bool bl = true)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            Regex reg = new Regex(patten);
            str = reg.Replace(str, "*");
            if (bl)
            {
                Random rd = new Random();
                var index = rd.Next(str.Length - 5);
                str = str.Remove(str.Length - index);
            }

            return str;
        }

        private void dataGridView_Environment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView_Environment.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
            dataGridView_Environment.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
        }

        private void EnvironmentSetting_Load(object sender, EventArgs e)
        {
            AddDeleteButton();
            for (var i = 0; i < dataGridView_Environment.Rows.Count; i++)
            {
                dataGridView_Environment.Rows[i].DefaultCellStyle.BackColor = SystemColors.Info;
            }
            dataGridView_Environment.ClearSelection();
        }

        private void AddDeleteButton()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            var btn_CellStyle = new DataGridViewCellStyle();
            btn_CellStyle.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn.Name = "button_Delete";
            btn.HeaderText = "";
            btn.DefaultCellStyle.NullValue = "Delete";
            btn.FlatStyle = FlatStyle.System;
            btn.DefaultCellStyle.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridView_Environment.Columns.Add(btn);
        }

        private void dataGridView_Environment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Environment.Columns[e.ColumnIndex].Name == "button_Delete")
            {
                if (!CallerContext.SysAdmin.IsSuper
                    && dataGridView_Environment != null
                    && dataGridView_Environment[0, e.RowIndex].Value.ToString() == "Product")
                {
                    MessageBox.Show("The current user is not a super administrator. Only a super administrator can delete this row of data");
                    return;
                }

                var name = dataGridView_Environment["Name", e.RowIndex].Value.ToString();
                var bl = CallerContext.ECOLABIOTEnvironmentService.RemoveEnvironmentVariable(new EnvironmentVariable()
                {
                    Name = name
                });

                if (!bl)
                {
                    MessageBox.Show("Failed");
                    return;
                }

                MessageBox.Show("Successful");
                BangDing();
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
            {
                return;
            }

            var bl = CallerContext.ECOLABIOTEnvironmentService.AddOrUpdateEnvironmentVariable(BuildObject());

            if (!bl)
            {
                MessageBox.Show("Failed");
                return;
            }

            Clear();
            MessageBox.Show("Successful");
            BangDing();
            AddDeleteButton();
        }

        private EnvironmentVariable BuildObject()
        {
            var fileName = string.Format(Constants.FileNameTemplate, textBox_EnvironmentName.Text);
            return new EnvironmentVariable()
            {
                Name = textBox_EnvironmentName.Text,
                FileName = fileName,
                FilePath = string.Format(Constants.FilePathTemplate, AppDomain.CurrentDomain.BaseDirectory, fileName),
                AppServiceOption = new AppServiceOption()
                {
                    ClientId = textBox_EnvironmentClientId.Text,
                    ClientSecret = textBox_EnvironmentClientSecret.Text,
                    TenantId = textBox_EnvironmentTenantId.Text,
                    KeyValutUrl = textBox_EnvironmentKeyValutUrl.Text,
                    DeviceType = textBox_EnvironmentDeviceType.Text,
                    PlatformName = textBox_EnvironmentPlatformName.Text,
                    DeviceRegisterUrl = textBox_EnvironmentDeviceRegisterUrl.Text
                }
            };
        }

        private void Clear()
        {
            DisableValidateEvent();
            textBox_EnvironmentName.Text = "";
            textBox_EnvironmentClientId.Text = "";
            textBox_EnvironmentClientSecret.Text = "";
            textBox_EnvironmentTenantId.Text = "";
            textBox_EnvironmentKeyValutUrl.Text = "";
            textBox_EnvironmentDeviceType.Text = "";
            textBox_EnvironmentPlatformName.Text = "";
            textBox_EnvironmentDeviceRegisterUrl.Text = "";
            EnableValidateEvent();
        }

        private void EnableValidateEvent()
        {
            textBox_EnvironmentName.KeyPress += new KeyPressEventHandler(textBox_EnvironmentName_KeyPress);
            textBox_EnvironmentName.TextChanged += new EventHandler(textBox_EnvironmentName_TextChanged);

            textBox_EnvironmentClientId.KeyPress += new KeyPressEventHandler(textBox_EnvironmentClientId_KeyPress);
            textBox_EnvironmentClientId.TextChanged += new EventHandler(textBox_EnvironmentClientId_TextChanged);

            textBox_EnvironmentClientSecret.KeyPress += new KeyPressEventHandler(textBox_EnvironmentClientSecret_KeyPress);
            textBox_EnvironmentClientSecret.TextChanged += new EventHandler(textBox_EnvironmentClientSecret_TextChanged);

            textBox_EnvironmentTenantId.KeyPress += new KeyPressEventHandler(textBox_EnvironmentTenantId_KeyPress);
            textBox_EnvironmentTenantId.TextChanged += new EventHandler(textBox_EnvironmentTenantId_TextChanged);

            textBox_EnvironmentKeyValutUrl.KeyPress += new KeyPressEventHandler(textBox_EnvironmentKeyValutUrl_KeyPress);
            textBox_EnvironmentKeyValutUrl.TextChanged += new EventHandler(textBox_EnvironmentKeyValutUrl_TextChanged);

            textBox_EnvironmentDeviceType.KeyPress += new KeyPressEventHandler(textBox_EnvironmentDeviceType_KeyPress);
            textBox_EnvironmentDeviceType.TextChanged += new EventHandler(textBox_EnvironmentDeviceType_TextChanged);

            textBox_EnvironmentPlatformName.KeyPress += new KeyPressEventHandler(textBox_EnvironmentPlatformName_KeyPress);
            textBox_EnvironmentPlatformName.TextChanged += new EventHandler(textBox_EnvironmentPlatformName_TextChanged);

            textBox_EnvironmentDeviceRegisterUrl.KeyPress += new KeyPressEventHandler(textBox_EnvironmentDeviceRegisterUrl_KeyPress);
            textBox_EnvironmentDeviceRegisterUrl.TextChanged += new EventHandler(textBox_EnvironmentDeviceRegisterUrl_TextChanged);
        }

        private void DisableValidateEvent()
        {
            textBox_EnvironmentName.KeyPress -= new KeyPressEventHandler(textBox_EnvironmentName_KeyPress);
            textBox_EnvironmentName.TextChanged -= new EventHandler(textBox_EnvironmentName_TextChanged);

            textBox_EnvironmentClientId.KeyPress -= new KeyPressEventHandler(textBox_EnvironmentClientId_KeyPress);
            textBox_EnvironmentClientId.TextChanged -= new EventHandler(textBox_EnvironmentClientId_TextChanged);

            textBox_EnvironmentClientSecret.KeyPress -= new KeyPressEventHandler(textBox_EnvironmentClientSecret_KeyPress);
            textBox_EnvironmentClientSecret.TextChanged -= new EventHandler(textBox_EnvironmentClientSecret_TextChanged);

            textBox_EnvironmentTenantId.KeyPress -= new KeyPressEventHandler(textBox_EnvironmentTenantId_KeyPress);
            textBox_EnvironmentTenantId.TextChanged -= new EventHandler(textBox_EnvironmentTenantId_TextChanged);

            textBox_EnvironmentKeyValutUrl.KeyPress -= new KeyPressEventHandler(textBox_EnvironmentKeyValutUrl_KeyPress);
            textBox_EnvironmentKeyValutUrl.TextChanged -= new EventHandler(textBox_EnvironmentKeyValutUrl_TextChanged);

            textBox_EnvironmentDeviceType.KeyPress -= new KeyPressEventHandler(textBox_EnvironmentDeviceType_KeyPress);
            textBox_EnvironmentDeviceType.TextChanged -= new EventHandler(textBox_EnvironmentDeviceType_TextChanged);

            textBox_EnvironmentPlatformName.KeyPress -= new KeyPressEventHandler(textBox_EnvironmentPlatformName_KeyPress);
            textBox_EnvironmentPlatformName.TextChanged -= new EventHandler(textBox_EnvironmentPlatformName_TextChanged);

            textBox_EnvironmentDeviceRegisterUrl.KeyPress -= new KeyPressEventHandler(textBox_EnvironmentDeviceRegisterUrl_KeyPress);
            textBox_EnvironmentDeviceRegisterUrl.TextChanged -= new EventHandler(textBox_EnvironmentDeviceRegisterUrl_TextChanged);
        }

        private bool ValidateAll()
        {
            return ValidateName()
                & ValidateClientId()
                & ValidateClientSecret()
                & ValidateTenantId()
                & ValidateKeyValutUrl()
                & ValidateDeviceType()
                & ValidatePlatformName()
                & Validate_DeviceRegisterUrl();
        }

        private bool ValidateName()
        {
            if (string.IsNullOrEmpty(textBox_EnvironmentName.Text))
            {
                label_Name.Text = "Name is required.";
                return false;
            }

            if (!CallerContext.SysAdmin.IsSuper && textBox_EnvironmentName.Text.Trim() == "Product")
            {
                label_Name.Text = "Only super administrator can add production configurations";
                return false;
            }

            if (!Utilities.IsStringOrNumber(textBox_EnvironmentName.Text))
            {
                label_Name.Text = "Name can only contain letters and numbers.";
                return false;
            }

            label_Name.Text = "";
            return true;
        }

        private bool ValidateClientId()
        {
            if (string.IsNullOrEmpty(textBox_EnvironmentClientId.Text))
            {
                label_ClientId.Text = "ClientId is required.";
                return false;
            }

            if (!Utilities.IsGUID(textBox_EnvironmentClientId.Text))
            {
                label_ClientId.Text = "ClientId must be GUID.";
                return false;
            }

            label_ClientId.Text = "";
            return true;
        }

        private bool ValidateClientSecret()
        {
            if (string.IsNullOrEmpty(textBox_EnvironmentClientSecret.Text))
            {
                label_ClientSecret.Text = "ClientSecret is required.";
                return false;
            }

            label_ClientSecret.Text = "";
            return true;
        }
        private bool ValidateTenantId()
        {
            if (string.IsNullOrEmpty(textBox_EnvironmentTenantId.Text))
            {
                label_TenantId.Text = "TenantId is required.";
                return false;
            }

            if (!Utilities.IsGUID(textBox_EnvironmentTenantId.Text))
            {
                label_TenantId.Text = "TenantId must be GUID.";
                return false;
            }

            label_TenantId.Text = "";
            return true;
        }
        private bool ValidateDeviceType()
        {
            if (string.IsNullOrEmpty(textBox_EnvironmentDeviceType.Text))
            {
                label_DeviceType.Text = "DeviceType is required.";
                return false;
            }

            label_DeviceType.Text = "";
            return true;
        }

        private bool ValidatePlatformName()
        {
            if (string.IsNullOrEmpty(textBox_EnvironmentPlatformName.Text))
            {
                label_PlatformName.Text = "ClientSecret is required.";
                return false;
            }

            label_PlatformName.Text = "";
            return true;
        }

        private bool ValidateKeyValutUrl()
        {
            if (string.IsNullOrEmpty(textBox_EnvironmentKeyValutUrl.Text))
            {
                label_KeyValutUrl.Text = "KeyValutUrl is required.";
                return false;
            }

            if (!Utilities.IsURL(textBox_EnvironmentKeyValutUrl.Text))
            {
                label_KeyValutUrl.Text = "KeyValutUrl must be a Url.";
                return false;
            }

            label_KeyValutUrl.Text = "";
            return true;
        }

        private bool Validate_DeviceRegisterUrl()
        {
            if (string.IsNullOrEmpty(textBox_EnvironmentDeviceRegisterUrl.Text))
            {
                label_DeviceRegisterUrl.Text = "DeviceRegisterUrl is required.";
                return false;
            }

            if (!Utilities.IsURL(textBox_EnvironmentDeviceRegisterUrl.Text))
            {
                label_DeviceRegisterUrl.Text = "DeviceRegisterUrl must be a Url.";
                return false;
            }

            label_DeviceRegisterUrl.Text = "";
            return true;
        }

        private void textBox_EnvironmentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateName();
        }

        private void textBox_EnvironmentName_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }

        private void textBox_EnvironmentTenantId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTenantId();
        }

        private void textBox_EnvironmentTenantId_TextChanged(object sender, EventArgs e)
        {
            ValidateTenantId();
        }

        private void textBox_EnvironmentClientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateClientId();
        }

        private void textBox_EnvironmentClientId_TextChanged(object sender, EventArgs e)
        {
            ValidateClientId();
        }

        private void textBox_EnvironmentKeyValutUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyValutUrl();
        }

        private void textBox_EnvironmentKeyValutUrl_TextChanged(object sender, EventArgs e)
        {
            ValidateKeyValutUrl();
        }

        private void textBox_EnvironmentClientSecret_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateClientSecret();
        }

        private void textBox_EnvironmentClientSecret_TextChanged(object sender, EventArgs e)
        {
            ValidateClientSecret();
        }

        private void textBox_EnvironmentDeviceType_TextChanged(object sender, EventArgs e)
        {
            ValidateDeviceType();
        }

        private void textBox_EnvironmentDeviceType_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDeviceType();
        }

        private void textBox_EnvironmentPlatformName_TextChanged(object sender, EventArgs e)
        {
            ValidatePlatformName();
        }

        private void textBox_EnvironmentPlatformName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatePlatformName();
        }

        private void textBox_EnvironmentDeviceRegisterUrl_TextChanged(object sender, EventArgs e)
        {
            Validate_DeviceRegisterUrl();
        }

        private void textBox_EnvironmentDeviceRegisterUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate_DeviceRegisterUrl();
        }

        private void dataGridView_Environment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!CallerContext.SysAdmin.IsSuper
                && dataGridView_Environment != null
                && dataGridView_Environment[0, e.RowIndex].Value.ToString() == "Product")
            {
                MessageBox.Show("The current user is not a super administrator. Only a super administrator can modify this row of data");
                return;
            }

            textBox_EnvironmentName.Text = dataGridView_Environment[0, e.RowIndex].Value.ToString();
            textBox_EnvironmentClientId.Text = dataGridView_Environment[1, e.RowIndex].Value.ToString();
            textBox_EnvironmentClientSecret.Text = dataGridView_Environment[2, e.RowIndex].Value.ToString();
            textBox_EnvironmentTenantId.Text = dataGridView_Environment[3, e.RowIndex].Value.ToString();

            textBox_EnvironmentKeyValutUrl.Text = dataGridView_Environment[4, e.RowIndex].Value.ToString();
            textBox_EnvironmentDeviceType.Text = dataGridView_Environment[5, e.RowIndex].Value.ToString();
            textBox_EnvironmentPlatformName.Text = dataGridView_Environment[6, e.RowIndex].Value.ToString();
            textBox_EnvironmentDeviceRegisterUrl.Text = dataGridView_Environment[7, e.RowIndex].Value.ToString();

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
