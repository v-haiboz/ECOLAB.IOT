using ECOLAB.IOT.Common.Utilities;
using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using ECOLAB.IOT.WinFormApp.ChildWinForm;
using Microsoft.VisualStudio.Shell.Interop;
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
    public partial class DGWMode : Form
    {
        private class DGWModeDisplay
        {
            public string ValueMember { get; set; } = "";
            public string ModeName { get; set; } = "";
            public string Version { get; set; } = "";
            public string FilePath { get; set; } = "";
        }
        ComponentResourceManager res = new ComponentResourceManager(typeof(DGWMode));
        public DGWMode()
        {
            InitializeComponent();
            //Clear();
            BangDing();
        }

        private void BangDing()
        {
            this.dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.ClearSelection();
            var list = CallerContext.ECOLABIOTDGWModeService.GetDGWMode();

            var dataSource = list.Select(item => new DGWModeDisplay()
           {
                ValueMember = item.ModeName,
                ModeName = item.ModeName,
                Version = item.Version,
                FilePath = item.FilePath
            }).ToList();
            
            var name = string.Empty;
            foreach (var item in dataSource.OrderBy(n=>n.ModeName))
            {
                if (name == item.ModeName)
                {
                    item.ModeName = "";
                }
                if (!string.IsNullOrEmpty(item.ModeName))
                {
                    name = item.ModeName;
                }
            }

            this.dataGridView1.DataSource = dataSource;
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["ValueMember"].FillWeight =1;
                dataGridView1.Columns["ValueMember"].Visible = false;
                dataGridView1.Columns["ModeName"].FillWeight = 30;
                dataGridView1.Columns["Version"].FillWeight = 20;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = SystemColors.Info;
            }

            Clear();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            DisableValidateEvent();
            this.textBox_ChooseFile.Text = "";
            this.textBox_ModeName.Text = "";
            this.textBox_Version.Text = "";
            this.label_ChooseFile_Validate.Text = "";
            this.label_ModeName_Validate.Text = "";
            this.label_Version_Validate.Text = "";
            EnableValidateEvent();
        }

        private void EnableValidateEvent()
        {
            textBox_ModeName.KeyPress += new KeyPressEventHandler(textBox_ModeName_KeyPress);
            textBox_ModeName.TextChanged += new EventHandler(textBox_ModeName_TextChanged);

            textBox_Version.KeyPress += new KeyPressEventHandler(textBox_Version_KeyPress);
            textBox_Version.TextChanged += new EventHandler(textBox_Version_TextChanged);

            textBox_ChooseFile.KeyPress += new KeyPressEventHandler(textBox_ChooseFile_KeyPress);
            textBox_ChooseFile.TextChanged += new EventHandler(textBox_ChooseFile_TextChanged);
        }

        private void DisableValidateEvent()
        {
            textBox_ModeName.KeyPress -= new KeyPressEventHandler(textBox_ModeName_KeyPress);
            textBox_ModeName.TextChanged -= new EventHandler(textBox_ModeName_TextChanged);

            textBox_Version.KeyPress += new KeyPressEventHandler(textBox_Version_KeyPress);
            textBox_Version.TextChanged -= new EventHandler(textBox_Version_TextChanged);

            textBox_ChooseFile.KeyPress -= new KeyPressEventHandler(textBox_ChooseFile_KeyPress);
            textBox_ChooseFile.TextChanged -= new EventHandler(textBox_ChooseFile_TextChanged);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                return;
            }

            var item = new DGWModeConfig();
            item.ModeName = textBox_ModeName.Text.ToUpperInvariant();
            item.Version = textBox_Version.Text.ToLowerInvariant();
            item.FilePath = textBox_ChooseFile.Text;

            var bl=CallerContext.ECOLABIOTDGWModeService.AddOrUpdateDGWMode(item);
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

        private bool Validate()
        {
            if (Validate_ModeName() & Validate_Version() & Validate_ChooseFile())
            {
                return true;
            }

            return false;
        }

        private bool Validate_ModeName()
        {
            if (string.IsNullOrEmpty(textBox_ModeName.Text))
            {
                this.label_ModeName_Validate.Text = "Mode Name is Empty.";
                return false;
            }

            if (!Utilities.IsStringOrNumberOrOthers(textBox_ModeName.Text))
            {
                label_ModeName_Validate.Text = "Mode Name can only contain letters,numbers or(.、-、_)";
                return false;
            }

            this.label_ModeName_Validate.Text =string.Empty;
            return true;

        }
        private bool Validate_Version()
        {
            if (string.IsNullOrEmpty(textBox_Version.Text))
            {
                this.label_Version_Validate.Text = "Version is Empty.";
                return false;
            }

            if (!Utilities.IsStringOrNumberOrOthers(textBox_Version.Text))
            {
                label_Version_Validate.Text = "Version can only contain letters,numbers or(.、-、_)";
                return false;
            }

            this.label_Version_Validate.Text = string.Empty;
            return true;

        }
        private bool Validate_ChooseFile()
        {
            if (string.IsNullOrEmpty(textBox_ChooseFile.Text))
            {
                this.label_ChooseFile_Validate.Text = "Choose File is Empty.";
                return false;
            }
            this.label_ChooseFile_Validate.Text = string.Empty;
            return true;

        }

        private void button_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_ChooseFile.Text = openFileDialog.FileName;
            }
        }

        private void textBox_ModeName_TextChanged(object sender, EventArgs e)
        {
            Validate_ModeName();
        }

        private void textBox_ModeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate_ModeName();
        }
        private void textBox_Version_TextChanged(object sender, EventArgs e)
        {
            Validate_Version();
        }

        private void textBox_Version_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate_Version();
        }

        private void textBox_ChooseFile_TextChanged(object sender, EventArgs e)
        {
            Validate_ChooseFile();
        }

        private void textBox_ChooseFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate_ChooseFile();
        }

        private void DGWMode_Load(object sender, EventArgs e)
        {
            AddDeleteButton();
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = SystemColors.Info;
            }
            dataGridView1.ClearSelection();
        }
        private void AddDeleteButton()
        {
            if (dataGridView1.DataSource == null)
            {
                return;
            }

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            var btn_CellStyle = new DataGridViewCellStyle();
            btn_CellStyle.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn.Name = "button_Delete";
            btn.HeaderText = "";
            btn.DefaultCellStyle.NullValue = $"{res.GetString("message_Delete")}";
            btn.FlatStyle = FlatStyle.System;
            btn.DefaultCellStyle.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridView1.Columns.Add(btn);
            dataGridView1.Columns["button_Delete"].FillWeight = 30;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "button_Delete")
            {

                var filePath = dataGridView1["FilePath", e.RowIndex].Value.ToString();

                var bl = CallerContext.ECOLABIOTDGWModeService.RemoveDGWMode(new DGWModeConfig()
                {
                     FilePath= filePath
                });

                if (!bl)
                {
                    MessageBox.Show("Failed");
                    return;
                }

                MessageBox.Show("Successful");
                BangDing();
                AddDeleteButton();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            textBox_ModeName.Text = dataGridView1["ValueMember", e.RowIndex].Value.ToString();
            textBox_Version.Text = dataGridView1["Version", e.RowIndex].Value.ToString();
            textBox_ChooseFile.Text = dataGridView1["FilePath", e.RowIndex].Value.ToString();
        }
    }
}
