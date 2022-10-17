using ECOLAB.IOT.Common.Utilities;
using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class ApplicationSetting : Form
    {
        ComponentResourceManager res = new ComponentResourceManager(typeof(ApplicationSetting));
        private List<CustomGroup> customGroups = new List<CustomGroup>();
        public ApplicationSetting()
        {
            InitializeComponent();
            DataBind();
            var lableFirst = new Label();
            var location_First = new Point(label_Add.Location.X, label_Add.Location.Y);
            lableFirst.Location = location_First;
            lableFirst.Font = label_Add.Font;
            lableFirst.Padding = label_Add.Padding;
            lableFirst.Margin = label_Add.Margin;
            lableFirst.Text = "-";
            lableFirst.Click += new EventHandler(label_Delete_Click);
            this.splitContainer2.Width = 150;
            customGroups.Add(new CustomGroup(textBox_SourcePerfix, lableFirst, null));
        }
        private void label_Delete_Click(object sender, EventArgs e)
        {
            var lable = (Label)sender;
            var name = lable.Name;
            var item = customGroups.Where(item => item.Name == $"{name.Replace("lable_", "")}").FirstOrDefault();
            if (item != null)
            {
                var index = customGroups.IndexOf(item);
                customGroups.Remove(item);
                for (var i = index; i < customGroups.Count; i++)
                {
                    customGroups[i].Label.Location = new Point(customGroups[i].Label.Location.X, customGroups[i].Label.Location.Y - 42);
                    customGroups[i].TextBox.Location = new Point(customGroups[i].TextBox.Location.X, customGroups[i].TextBox.Location.Y - 42);

                }

                this.splitContainer2.Panel2.Controls.Remove(item.Label);
                this.splitContainer2.Panel2.Controls.Remove(item.TextBox);
                label_Add.Location = new Point(label_Add.Location.X, label_Add.Location.Y - 42);
            }
        }
        private void label_Add_Click(object sender, EventArgs e)
        {
            if (customGroups.Count >= 8)
            {
                MessageBox.Show(res.GetString("message2"));
                return;
            }
            Add_Control(null);
        }

        private void Add_Control(string source)
        {
            var lasttextBoxControl = new TextBox();
            var lastlabelControl = new Label();
            var Controls = this.splitContainer2.Panel2.Controls;
            foreach (var control in Controls)
            {
                if (control is TextBox)
                {
                    lasttextBoxControl = (TextBox)control;

                }
                if (control is Label)
                {
                    lastlabelControl = (Label)control;
                }
            }
            var sourcePrefixText = new TextBox();
            Point location = new Point(lasttextBoxControl.Location.X, lasttextBoxControl.Location.Y + 42);
            sourcePrefixText.Location = location;
            sourcePrefixText.BorderStyle = BorderStyle.None;
            sourcePrefixText.Width = lasttextBoxControl.Width;
            sourcePrefixText.Multiline = lasttextBoxControl.Multiline;
            sourcePrefixText.Text = source;
            sourcePrefixText.KeyPress += textBox_TargetPrefix_KeyPress;
            Point location_Add = new Point(label_Add.Location.X, label_Add.Location.Y + 42);

            this.splitContainer2.Panel2.Controls.Add(sourcePrefixText);

            if (customGroups.Count >= 1)
            {
                var lable_delete = new Label();
                var location_Delete = new Point(label_Add.Location.X, label_Add.Location.Y + 42);
                lable_delete.Location = location_Delete;
                lable_delete.Font = label_Add.Font;
                lable_delete.Padding = label_Add.Padding;
                lable_delete.Margin = label_Add.Margin;
                lable_delete.Text = "-";
                lable_delete.Width = 300;
                lable_delete.Click += new EventHandler(label_Delete_Click);
                var custonGroup = new CustomGroup(sourcePrefixText, lable_delete);
                var lastLable = customGroups[customGroups.Count - 1].Label;
                lastLable.Click += new EventHandler(label_Delete_Click);
                this.splitContainer2.Panel2.Controls.Add(lastLable);
                customGroups.Add(custonGroup);
            }

            label_Add.Location = location_Add;

        }

        private DeviceType GenerateDeviceType()
        {
            var deviceType = new DeviceType();
            if (string.IsNullOrEmpty(textBox_TargetPrefix.Text))
            {
                return null;
            }

            deviceType.TargetName = textBox_TargetPrefix.Text;

            if (customGroups.Count > 0)
            {
                foreach (var customGroup in customGroups)
                {
                    if (!string.IsNullOrEmpty(customGroup.TextBox.Text))
                    {
                        deviceType.SourceNameList.Add(customGroup.TextBox.Text);
                    }
                }
            }

            if (deviceType.SourceNameList.Count == 0)
            {
                return null;
            }

            return deviceType;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            this.button_Add.Enabled = false;

            bool bl = true;
            foreach (var child in customGroups)
            {
                if (!string.IsNullOrEmpty(child.TextBox.Text))
                {
                    bl = false;
                    break;
                }
            }

            if (string.IsNullOrEmpty(textBox_TargetPrefix.Text) || bl)
            {
                MessageBox.Show(res.GetString("message1"));
                this.button_Add.Enabled = true;
                return;
            }
            var deviceType = GenerateDeviceType();
            if (deviceType == null)
            {
                return;
            }

            var deviceTypeList = CallerContext.ECOLABIOTDeviceTypeService.GetDeviceTypeMapping();
            if (deviceTypeList == null)
            {
                deviceTypeList = new DeviceTypMapping();
            }

            var item = deviceTypeList.List.Where(item => item.TargetName == deviceType.TargetName).FirstOrDefault();
            if (item != null)
            {
                deviceTypeList.List.Remove(item);
            }

            deviceTypeList.List.Add(deviceType);

            CallerContext.ECOLABIOTDeviceTypeService.AddOrUpdateDeviceTypeMapping(deviceTypeList);

            DataBind();
            AddDeleteButton();
            this.textBox_TargetPrefix.Text = "";
            foreach (var child in customGroups)
            {
                child.TextBox.Text = "";
            }
            this.button_Add.Enabled = true;
        }

        private void ApplicationSetting_Load(object sender, EventArgs e)
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
            if(dataGridView1.DataSource ==null)
            {
                return;
            }

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            var btn_CellStyle = new DataGridViewCellStyle();
            btn_CellStyle.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn.Name = "button_Delete";
            btn.DisplayIndex = 2;
            btn.HeaderText = "";
            btn.DefaultCellStyle.NullValue = $"{res.GetString("message_Delete")}";
            btn.FlatStyle = FlatStyle.System;
            btn.DefaultCellStyle.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridView1.Columns.Add(btn);
        }
        private void DataBind()
        {
            this.dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.ClearSelection();
            var deviceTypeList = CallerContext.ECOLABIOTDeviceTypeService.GetDeviceTypeMapping();
            this.dataGridView1.DataSource = deviceTypeList.ToDeviceTypeMappingDisplay();
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.Columns["TargetPrefix"].Width = 100;
                dataGridView1.Columns["SourcePrefixs"].Width = 300;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = SystemColors.Info;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "button_Delete")
            {
                if (!CallerContext.SysAdmin.IsSuper
                    && dataGridView1 == null)
                {
                    MessageBox.Show($"{res.GetString("message_1")}");
                    return;
                }

                var name = dataGridView1["TargetPrefix", e.RowIndex].Value.ToString();
                var deviceTypeList = CallerContext.ECOLABIOTDeviceTypeService.GetDeviceTypeMapping();
                var item = deviceTypeList.List.Where(item => item.TargetName == name).FirstOrDefault();
                if (item != null)
                {
                    deviceTypeList.List.Remove(item);
                }

                var bl = CallerContext.ECOLABIOTDeviceTypeService.AddOrUpdateDeviceTypeMapping(deviceTypeList);


                if (bl.HasValue && !bl.Value)
                {
                    MessageBox.Show("Failed");
                    return;
                }

                MessageBox.Show("Successful");
                DataBind();
                AddDeleteButton();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1 == null)
            {
                MessageBox.Show($"{res.GetString("message_2")}");
                return;
            }
            textBox_TargetPrefix.Text = dataGridView1["TargetPrefix", e.RowIndex].Value.ToString();
            var sourcelist = dataGridView1["SourcePrefixs", e.RowIndex].Value.ToString();
            var i = 0;
            foreach (var item in sourcelist.Split(";"))
            {
                if (i == 0)
                {
                    for (var j = 0; j < customGroups.Count; j++)
                    {
                        if (j != 0)
                        {
                            this.splitContainer2.Panel2.Controls.Remove(customGroups[j].Label);
                            this.splitContainer2.Panel2.Controls.Remove(customGroups[j].TextBox);
                        }
                    }
                    customGroups.RemoveRange(1, customGroups.Count - 1);
                    label_Add.Location = customGroups[0].Label.Location;
                    customGroups[0].TextBox.Text = item;
                }
                else
                {
                    Add_Control(item);
                }

                i++;
            }
        }

        private void textBox_TargetPrefix_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            if ((Regex.IsMatch(e.KeyChar.ToString(), "^[A-Za-z]+$") && textBox.Text.Length < 3) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            this.textBox_TargetPrefix.Text = "";
            foreach (var item in customGroups)
            {
                item.TextBox.Text = "";
            }
        }
    }

    public class CustomGroup
    {
        public CustomGroup(TextBox textBox, Label label, string name = null)
        {
            this.label = label;
            this.textBox = textBox;
            if (string.IsNullOrEmpty(name))
            {
                name = Guid.NewGuid().ToString();
                label.Name = $"lable_{name}";
                textBox.Name = $"textBox_{name}";
            }
            this.name = name;
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { value = name; }
        }

        private TextBox textBox;
        public TextBox TextBox
        {
            get { return textBox; }
            set { textBox = value; }
        }

        private Label label;
        public Label Label
        {
            get { return label; }
            set { label = value; }
        }

    }
}
