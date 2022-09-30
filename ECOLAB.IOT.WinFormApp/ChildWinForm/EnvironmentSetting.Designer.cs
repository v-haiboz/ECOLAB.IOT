namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    partial class EnvironmentSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer_Environment = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Environment = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_KeyValutUrl = new System.Windows.Forms.Label();
            this.label_TenantId = new System.Windows.Forms.Label();
            this.label_ClientSecret = new System.Windows.Forms.Label();
            this.label_DeviceRegisterUrl = new System.Windows.Forms.Label();
            this.label_PlatformName = new System.Windows.Forms.Label();
            this.label_ClientId = new System.Windows.Forms.Label();
            this.label_DeviceType = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_EnvironmentDeviceRegisterUrl = new System.Windows.Forms.TextBox();
            this.textBox_EnvironmentClientSecret = new System.Windows.Forms.TextBox();
            this.label_EnvironmentDeviceRegisterUrl = new System.Windows.Forms.Label();
            this.label_EnvironmentClientSecret = new System.Windows.Forms.Label();
            this.textBox_EnvironmentKeyValutUrl = new System.Windows.Forms.TextBox();
            this.label_EnvironmentKeyValutUrl = new System.Windows.Forms.Label();
            this.textBox_EnvironmentPlatformName = new System.Windows.Forms.TextBox();
            this.textBox_EnvironmentClientId = new System.Windows.Forms.TextBox();
            this.label_EnvironmentPlatformName = new System.Windows.Forms.Label();
            this.textBox_EnvironmentTenantId = new System.Windows.Forms.TextBox();
            this.label_EnvironmentClientId = new System.Windows.Forms.Label();
            this.textBox_EnvironmentDeviceType = new System.Windows.Forms.TextBox();
            this.label_EnvironmentTenantId = new System.Windows.Forms.Label();
            this.label_EnvironmentDeviceType = new System.Windows.Forms.Label();
            this.textBox_EnvironmentName = new System.Windows.Forms.TextBox();
            this.label_EnvironmentName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Environment)).BeginInit();
            this.splitContainer_Environment.Panel1.SuspendLayout();
            this.splitContainer_Environment.Panel2.SuspendLayout();
            this.splitContainer_Environment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Environment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_Environment
            // 
            this.splitContainer_Environment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Environment.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Environment.Name = "splitContainer_Environment";
            this.splitContainer_Environment.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Environment.Panel1
            // 
            this.splitContainer_Environment.Panel1.Controls.Add(this.dataGridView_Environment);
            // 
            // splitContainer_Environment.Panel2
            // 
            this.splitContainer_Environment.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer_Environment.Size = new System.Drawing.Size(1370, 693);
            this.splitContainer_Environment.SplitterDistance = 312;
            this.splitContainer_Environment.TabIndex = 0;
            // 
            // dataGridView_Environment
            // 
            this.dataGridView_Environment.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Environment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Environment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Environment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Environment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Environment.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Environment.Name = "dataGridView_Environment";
            this.dataGridView_Environment.RowHeadersWidth = 62;
            this.dataGridView_Environment.RowTemplate.Height = 32;
            this.dataGridView_Environment.Size = new System.Drawing.Size(1370, 312);
            this.dataGridView_Environment.TabIndex = 0;
            this.dataGridView_Environment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Environment_CellClick);
            this.dataGridView_Environment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Environment_CellContentClick);
            this.dataGridView_Environment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Environment_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label_KeyValutUrl);
            this.groupBox1.Controls.Add(this.label_TenantId);
            this.groupBox1.Controls.Add(this.label_ClientSecret);
            this.groupBox1.Controls.Add(this.label_DeviceRegisterUrl);
            this.groupBox1.Controls.Add(this.label_PlatformName);
            this.groupBox1.Controls.Add(this.label_ClientId);
            this.groupBox1.Controls.Add(this.label_DeviceType);
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Controls.Add(this.button_Clear);
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentDeviceRegisterUrl);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentClientSecret);
            this.groupBox1.Controls.Add(this.label_EnvironmentDeviceRegisterUrl);
            this.groupBox1.Controls.Add(this.label_EnvironmentClientSecret);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentKeyValutUrl);
            this.groupBox1.Controls.Add(this.label_EnvironmentKeyValutUrl);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentPlatformName);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentClientId);
            this.groupBox1.Controls.Add(this.label_EnvironmentPlatformName);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentTenantId);
            this.groupBox1.Controls.Add(this.label_EnvironmentClientId);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentDeviceType);
            this.groupBox1.Controls.Add(this.label_EnvironmentTenantId);
            this.groupBox1.Controls.Add(this.label_EnvironmentDeviceType);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentName);
            this.groupBox1.Controls.Add(this.label_EnvironmentName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1370, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maintenance information";
            // 
            // label_KeyValutUrl
            // 
            this.label_KeyValutUrl.AutoSize = true;
            this.label_KeyValutUrl.ForeColor = System.Drawing.Color.Red;
            this.label_KeyValutUrl.Location = new System.Drawing.Point(225, 330);
            this.label_KeyValutUrl.Name = "label_KeyValutUrl";
            this.label_KeyValutUrl.Size = new System.Drawing.Size(0, 24);
            this.label_KeyValutUrl.TabIndex = 20;
            // 
            // label_TenantId
            // 
            this.label_TenantId.AutoSize = true;
            this.label_TenantId.ForeColor = System.Drawing.Color.Red;
            this.label_TenantId.Location = new System.Drawing.Point(225, 263);
            this.label_TenantId.Name = "label_TenantId";
            this.label_TenantId.Size = new System.Drawing.Size(0, 24);
            this.label_TenantId.TabIndex = 19;
            // 
            // label_ClientSecret
            // 
            this.label_ClientSecret.AutoSize = true;
            this.label_ClientSecret.ForeColor = System.Drawing.Color.Red;
            this.label_ClientSecret.Location = new System.Drawing.Point(225, 203);
            this.label_ClientSecret.Name = "label_ClientSecret";
            this.label_ClientSecret.Size = new System.Drawing.Size(0, 24);
            this.label_ClientSecret.TabIndex = 18;
            // 
            // label_DeviceRegisterUrl
            // 
            this.label_DeviceRegisterUrl.AutoSize = true;
            this.label_DeviceRegisterUrl.ForeColor = System.Drawing.Color.Red;
            this.label_DeviceRegisterUrl.Location = new System.Drawing.Point(860, 265);
            this.label_DeviceRegisterUrl.Name = "label_DeviceRegisterUrl";
            this.label_DeviceRegisterUrl.Size = new System.Drawing.Size(0, 24);
            this.label_DeviceRegisterUrl.TabIndex = 17;
            // 
            // label_PlatformName
            // 
            this.label_PlatformName.AutoSize = true;
            this.label_PlatformName.ForeColor = System.Drawing.Color.Red;
            this.label_PlatformName.Location = new System.Drawing.Point(860, 140);
            this.label_PlatformName.Name = "label_PlatformName";
            this.label_PlatformName.Size = new System.Drawing.Size(0, 24);
            this.label_PlatformName.TabIndex = 17;
            // 
            // label_ClientId
            // 
            this.label_ClientId.AutoSize = true;
            this.label_ClientId.ForeColor = System.Drawing.Color.Red;
            this.label_ClientId.Location = new System.Drawing.Point(225, 140);
            this.label_ClientId.Name = "label_ClientId";
            this.label_ClientId.Size = new System.Drawing.Size(0, 24);
            this.label_ClientId.TabIndex = 17;
            // 
            // label_DeviceType
            // 
            this.label_DeviceType.AutoSize = true;
            this.label_DeviceType.ForeColor = System.Drawing.Color.Red;
            this.label_DeviceType.Location = new System.Drawing.Point(859, 74);
            this.label_DeviceType.Name = "label_DeviceType";
            this.label_DeviceType.Size = new System.Drawing.Size(0, 24);
            this.label_DeviceType.TabIndex = 16;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.ForeColor = System.Drawing.Color.Red;
            this.label_Name.Location = new System.Drawing.Point(225, 74);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(0, 24);
            this.label_Name.TabIndex = 16;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Location = new System.Drawing.Point(1096, 296);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(204, 38);
            this.button_Clear.TabIndex = 15;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(850, 296);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(204, 38);
            this.button_Add.TabIndex = 15;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_EnvironmentDeviceRegisterUrl
            // 
            this.textBox_EnvironmentDeviceRegisterUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentDeviceRegisterUrl.Location = new System.Drawing.Point(850, 167);
            this.textBox_EnvironmentDeviceRegisterUrl.Multiline = true;
            this.textBox_EnvironmentDeviceRegisterUrl.Name = "textBox_EnvironmentDeviceRegisterUrl";
            this.textBox_EnvironmentDeviceRegisterUrl.Size = new System.Drawing.Size(508, 91);
            this.textBox_EnvironmentDeviceRegisterUrl.TabIndex = 14;
            this.textBox_EnvironmentDeviceRegisterUrl.TextChanged += new System.EventHandler(this.textBox_EnvironmentDeviceRegisterUrl_TextChanged);
            this.textBox_EnvironmentDeviceRegisterUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentDeviceRegisterUrl_KeyPress);
            // 
            // textBox_EnvironmentClientSecret
            // 
            this.textBox_EnvironmentClientSecret.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentClientSecret.Location = new System.Drawing.Point(225, 169);
            this.textBox_EnvironmentClientSecret.Multiline = true;
            this.textBox_EnvironmentClientSecret.Name = "textBox_EnvironmentClientSecret";
            this.textBox_EnvironmentClientSecret.Size = new System.Drawing.Size(416, 30);
            this.textBox_EnvironmentClientSecret.TabIndex = 14;
            this.textBox_EnvironmentClientSecret.TextChanged += new System.EventHandler(this.textBox_EnvironmentClientSecret_TextChanged);
            this.textBox_EnvironmentClientSecret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentClientSecret_KeyPress);
            // 
            // label_EnvironmentDeviceRegisterUrl
            // 
            this.label_EnvironmentDeviceRegisterUrl.AutoSize = true;
            this.label_EnvironmentDeviceRegisterUrl.Location = new System.Drawing.Point(659, 175);
            this.label_EnvironmentDeviceRegisterUrl.Name = "label_EnvironmentDeviceRegisterUrl";
            this.label_EnvironmentDeviceRegisterUrl.Size = new System.Drawing.Size(167, 24);
            this.label_EnvironmentDeviceRegisterUrl.TabIndex = 13;
            this.label_EnvironmentDeviceRegisterUrl.Text = "DeviceRegisterUrl:";
            // 
            // label_EnvironmentClientSecret
            // 
            this.label_EnvironmentClientSecret.AutoSize = true;
            this.label_EnvironmentClientSecret.Location = new System.Drawing.Point(82, 173);
            this.label_EnvironmentClientSecret.Name = "label_EnvironmentClientSecret";
            this.label_EnvironmentClientSecret.Size = new System.Drawing.Size(117, 24);
            this.label_EnvironmentClientSecret.TabIndex = 13;
            this.label_EnvironmentClientSecret.Text = "ClientSecret:";
            // 
            // textBox_EnvironmentKeyValutUrl
            // 
            this.textBox_EnvironmentKeyValutUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentKeyValutUrl.ForeColor = System.Drawing.Color.Black;
            this.textBox_EnvironmentKeyValutUrl.Location = new System.Drawing.Point(225, 297);
            this.textBox_EnvironmentKeyValutUrl.Multiline = true;
            this.textBox_EnvironmentKeyValutUrl.Name = "textBox_EnvironmentKeyValutUrl";
            this.textBox_EnvironmentKeyValutUrl.Size = new System.Drawing.Size(547, 30);
            this.textBox_EnvironmentKeyValutUrl.TabIndex = 9;
            this.textBox_EnvironmentKeyValutUrl.TextChanged += new System.EventHandler(this.textBox_EnvironmentKeyValutUrl_TextChanged);
            this.textBox_EnvironmentKeyValutUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentKeyValutUrl_KeyPress);
            // 
            // label_EnvironmentKeyValutUrl
            // 
            this.label_EnvironmentKeyValutUrl.AutoSize = true;
            this.label_EnvironmentKeyValutUrl.Location = new System.Drawing.Point(80, 297);
            this.label_EnvironmentKeyValutUrl.Name = "label_EnvironmentKeyValutUrl";
            this.label_EnvironmentKeyValutUrl.Size = new System.Drawing.Size(115, 24);
            this.label_EnvironmentKeyValutUrl.TabIndex = 5;
            this.label_EnvironmentKeyValutUrl.Text = "KeyValutUrl:";
            // 
            // textBox_EnvironmentPlatformName
            // 
            this.textBox_EnvironmentPlatformName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentPlatformName.Location = new System.Drawing.Point(850, 104);
            this.textBox_EnvironmentPlatformName.Multiline = true;
            this.textBox_EnvironmentPlatformName.Name = "textBox_EnvironmentPlatformName";
            this.textBox_EnvironmentPlatformName.Size = new System.Drawing.Size(398, 30);
            this.textBox_EnvironmentPlatformName.TabIndex = 10;
            this.textBox_EnvironmentPlatformName.TextChanged += new System.EventHandler(this.textBox_EnvironmentPlatformName_TextChanged);
            this.textBox_EnvironmentPlatformName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentPlatformName_KeyPress);
            // 
            // textBox_EnvironmentClientId
            // 
            this.textBox_EnvironmentClientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentClientId.Location = new System.Drawing.Point(225, 104);
            this.textBox_EnvironmentClientId.Multiline = true;
            this.textBox_EnvironmentClientId.Name = "textBox_EnvironmentClientId";
            this.textBox_EnvironmentClientId.Size = new System.Drawing.Size(416, 30);
            this.textBox_EnvironmentClientId.TabIndex = 10;
            this.textBox_EnvironmentClientId.TextChanged += new System.EventHandler(this.textBox_EnvironmentClientId_TextChanged);
            this.textBox_EnvironmentClientId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentClientId_KeyPress);
            // 
            // label_EnvironmentPlatformName
            // 
            this.label_EnvironmentPlatformName.AutoSize = true;
            this.label_EnvironmentPlatformName.Location = new System.Drawing.Point(686, 110);
            this.label_EnvironmentPlatformName.Name = "label_EnvironmentPlatformName";
            this.label_EnvironmentPlatformName.Size = new System.Drawing.Size(140, 24);
            this.label_EnvironmentPlatformName.TabIndex = 6;
            this.label_EnvironmentPlatformName.Text = "PlatformName:";
            // 
            // textBox_EnvironmentTenantId
            // 
            this.textBox_EnvironmentTenantId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentTenantId.Location = new System.Drawing.Point(225, 230);
            this.textBox_EnvironmentTenantId.Multiline = true;
            this.textBox_EnvironmentTenantId.Name = "textBox_EnvironmentTenantId";
            this.textBox_EnvironmentTenantId.Size = new System.Drawing.Size(416, 30);
            this.textBox_EnvironmentTenantId.TabIndex = 11;
            this.textBox_EnvironmentTenantId.TextChanged += new System.EventHandler(this.textBox_EnvironmentTenantId_TextChanged);
            this.textBox_EnvironmentTenantId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentTenantId_KeyPress);
            // 
            // label_EnvironmentClientId
            // 
            this.label_EnvironmentClientId.AutoSize = true;
            this.label_EnvironmentClientId.Location = new System.Drawing.Point(118, 105);
            this.label_EnvironmentClientId.Name = "label_EnvironmentClientId";
            this.label_EnvironmentClientId.Size = new System.Drawing.Size(81, 24);
            this.label_EnvironmentClientId.TabIndex = 6;
            this.label_EnvironmentClientId.Text = "ClientId:";
            // 
            // textBox_EnvironmentDeviceType
            // 
            this.textBox_EnvironmentDeviceType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentDeviceType.Location = new System.Drawing.Point(850, 38);
            this.textBox_EnvironmentDeviceType.Multiline = true;
            this.textBox_EnvironmentDeviceType.Name = "textBox_EnvironmentDeviceType";
            this.textBox_EnvironmentDeviceType.Size = new System.Drawing.Size(398, 30);
            this.textBox_EnvironmentDeviceType.TabIndex = 12;
            this.textBox_EnvironmentDeviceType.TextChanged += new System.EventHandler(this.textBox_EnvironmentDeviceType_TextChanged);
            this.textBox_EnvironmentDeviceType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentDeviceType_KeyPress);
            // 
            // label_EnvironmentTenantId
            // 
            this.label_EnvironmentTenantId.AutoSize = true;
            this.label_EnvironmentTenantId.Location = new System.Drawing.Point(105, 236);
            this.label_EnvironmentTenantId.Name = "label_EnvironmentTenantId";
            this.label_EnvironmentTenantId.Size = new System.Drawing.Size(90, 24);
            this.label_EnvironmentTenantId.TabIndex = 7;
            this.label_EnvironmentTenantId.Text = "TenantId:";
            // 
            // label_EnvironmentDeviceType
            // 
            this.label_EnvironmentDeviceType.AutoSize = true;
            this.label_EnvironmentDeviceType.Location = new System.Drawing.Point(713, 44);
            this.label_EnvironmentDeviceType.Name = "label_EnvironmentDeviceType";
            this.label_EnvironmentDeviceType.Size = new System.Drawing.Size(113, 24);
            this.label_EnvironmentDeviceType.TabIndex = 8;
            this.label_EnvironmentDeviceType.Text = "DeviceType:";
            // 
            // textBox_EnvironmentName
            // 
            this.textBox_EnvironmentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentName.Location = new System.Drawing.Point(225, 38);
            this.textBox_EnvironmentName.Multiline = true;
            this.textBox_EnvironmentName.Name = "textBox_EnvironmentName";
            this.textBox_EnvironmentName.Size = new System.Drawing.Size(416, 30);
            this.textBox_EnvironmentName.TabIndex = 12;
            this.textBox_EnvironmentName.TextChanged += new System.EventHandler(this.textBox_EnvironmentName_TextChanged);
            this.textBox_EnvironmentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentName_KeyPress);
            // 
            // label_EnvironmentName
            // 
            this.label_EnvironmentName.AutoSize = true;
            this.label_EnvironmentName.Location = new System.Drawing.Point(133, 38);
            this.label_EnvironmentName.Name = "label_EnvironmentName";
            this.label_EnvironmentName.Size = new System.Drawing.Size(66, 24);
            this.label_EnvironmentName.TabIndex = 8;
            this.label_EnvironmentName.Text = "Name:";
            // 
            // EnvironmentSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 693);
            this.Controls.Add(this.splitContainer_Environment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnvironmentSetting";
            this.Text = "EnvironmentSetting";
            this.Load += new System.EventHandler(this.EnvironmentSetting_Load);
            this.splitContainer_Environment.Panel1.ResumeLayout(false);
            this.splitContainer_Environment.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Environment)).EndInit();
            this.splitContainer_Environment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Environment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer_Environment;
        private DataGridView dataGridView_Environment;
        private GroupBox groupBox1;
        private Button button_Add;
        private TextBox textBox_EnvironmentClientSecret;
        private Label label_EnvironmentClientSecret;
        private TextBox textBox_EnvironmentKeyValutUrl;
        private Label label_EnvironmentKeyValutUrl;
        private TextBox textBox_EnvironmentClientId;
        private TextBox textBox_EnvironmentTenantId;
        private Label label_EnvironmentClientId;
        private Label label_EnvironmentTenantId;
        private TextBox textBox_EnvironmentName;
        private Label label_EnvironmentName;
        private Label label_KeyValutUrl;
        private Label label_TenantId;
        private Label label_ClientSecret;
        private Label label_ClientId;
        private Label label_Name;
        private Label label_PlatformName;
        private Label label_DeviceType;
        private TextBox textBox_EnvironmentDeviceRegisterUrl;
        private Label label_EnvironmentDeviceRegisterUrl;
        private TextBox textBox_EnvironmentPlatformName;
        private Label label_EnvironmentPlatformName;
        private TextBox textBox_EnvironmentDeviceType;
        private Label label_EnvironmentDeviceType;
        private Label label_DeviceRegisterUrl;
        private Button button_Clear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}