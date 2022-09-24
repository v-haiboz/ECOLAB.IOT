using ECOLAB.IOT.Common;
using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dataGridView_Environment.Columns.Clear();
            this.dataGridView_Environment.DataSource = null;
            dataGridView_Environment.ClearSelection();
            var list = CallerContext.ECOLABIOTEnvironmentService.GetEnvironmentVariables();
            var dataSource = list.Select(item => new
            {
                Name = item.Name,
                ClientId = item.AppServiceOption.ClientId,
                ClientSecret = item.AppServiceOption.ClientSecret,
                TenantId = item.AppServiceOption.TenantId,
                KeyValutUri = item.AppServiceOption.KeyValutUri
            }).ToList();
            this.dataGridView_Environment.DataSource = dataSource;
            dataGridView_Environment.Columns[0].Width = 100;
            dataGridView_Environment.Columns[1].Width = 150;
            dataGridView_Environment.Columns[2].Width = 150;
            dataGridView_Environment.Columns[3].Width = 150;
            dataGridView_Environment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddDeleteButton();
        }

        private void dataGridView_Environment_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (var i = 0; i < dataGridView_Environment.Rows.Count; i++)
            {
                dataGridView_Environment.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
            }
        }

        private void dataGridView_Environment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView_Environment.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
            dataGridView_Environment.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
        }

        private void EnvironmentSetting_Load(object sender, EventArgs e)
        {
            dataGridView_Environment.ClearSelection();
        }

        private void AddDeleteButton()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "button_Delete";
            btn.HeaderText = "";
            btn.DefaultCellStyle.NullValue = "Delete";
            btn.FlatStyle = FlatStyle.System;
            btn.DefaultCellStyle.BackColor = Color.Red;
            dataGridView_Environment.Columns.Add(btn);

        }
        private void dataGridView_Environment_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void dataGridView_Environment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Environment.Columns[e.ColumnIndex].Name == "button_Delete")
            {
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
            var bl = CallerContext.ECOLABIOTEnvironmentService.AddOrUpdateEnvironmentVariable(BuildObject());

            if (!bl)
            {
                MessageBox.Show("Failed");
                return;
            }

            Clear();
            MessageBox.Show("Successful");
            BangDing();
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
                    KeyValutUri = textBox_EnvironmentKeyValutUrl.Text
                }
            };
        }
        private void DisableOrEnableGeneratePSKButton()
        {
            if (!string.IsNullOrEmpty(textBox_EnvironmentName.Text)
                && !string.IsNullOrEmpty(textBox_EnvironmentClientId.Text)
                && !string.IsNullOrEmpty(textBox_EnvironmentClientSecret.Text)
                && !string.IsNullOrEmpty(textBox_EnvironmentTenantId.Text)
                && !string.IsNullOrEmpty(textBox_EnvironmentKeyValutUrl.Text)
                )
            {
                button_Add.BackColor = Color.FromArgb(0, 192, 0);
                button_Add.Enabled = true;
            }
            else
            {
                button_Add.BackColor = SystemColors.AppWorkspace;
                button_Add.Enabled = false;
            }
        }

        private void Clear()
        {
            textBox_EnvironmentName.Text = "";
            textBox_EnvironmentClientId.Text = "";
            textBox_EnvironmentClientSecret.Text = "";
            textBox_EnvironmentTenantId.Text = "";
            textBox_EnvironmentKeyValutUrl.Text = "";
        }
    }
}
