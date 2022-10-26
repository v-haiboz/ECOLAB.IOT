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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnvironmentSetting));
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
            resources.ApplyResources(this.splitContainer_Environment, "splitContainer_Environment");
            this.splitContainer_Environment.Name = "splitContainer_Environment";
            // 
            // splitContainer_Environment.Panel1
            // 
            this.splitContainer_Environment.Panel1.Controls.Add(this.dataGridView_Environment);
            // 
            // splitContainer_Environment.Panel2
            // 
            this.splitContainer_Environment.Panel2.Controls.Add(this.groupBox1);
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
            resources.ApplyResources(this.dataGridView_Environment, "dataGridView_Environment");
            this.dataGridView_Environment.Name = "dataGridView_Environment";
            this.dataGridView_Environment.ReadOnly = true;
            this.dataGridView_Environment.RowTemplate.Height = 32;
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label_KeyValutUrl
            // 
            resources.ApplyResources(this.label_KeyValutUrl, "label_KeyValutUrl");
            this.label_KeyValutUrl.ForeColor = System.Drawing.Color.Red;
            this.label_KeyValutUrl.Name = "label_KeyValutUrl";
            // 
            // label_TenantId
            // 
            resources.ApplyResources(this.label_TenantId, "label_TenantId");
            this.label_TenantId.ForeColor = System.Drawing.Color.Red;
            this.label_TenantId.Name = "label_TenantId";
            // 
            // label_ClientSecret
            // 
            resources.ApplyResources(this.label_ClientSecret, "label_ClientSecret");
            this.label_ClientSecret.ForeColor = System.Drawing.Color.Red;
            this.label_ClientSecret.Name = "label_ClientSecret";
            // 
            // label_DeviceRegisterUrl
            // 
            resources.ApplyResources(this.label_DeviceRegisterUrl, "label_DeviceRegisterUrl");
            this.label_DeviceRegisterUrl.ForeColor = System.Drawing.Color.Red;
            this.label_DeviceRegisterUrl.Name = "label_DeviceRegisterUrl";
            // 
            // label_PlatformName
            // 
            resources.ApplyResources(this.label_PlatformName, "label_PlatformName");
            this.label_PlatformName.ForeColor = System.Drawing.Color.Red;
            this.label_PlatformName.Name = "label_PlatformName";
            // 
            // label_ClientId
            // 
            resources.ApplyResources(this.label_ClientId, "label_ClientId");
            this.label_ClientId.ForeColor = System.Drawing.Color.Red;
            this.label_ClientId.Name = "label_ClientId";
            // 
            // label_DeviceType
            // 
            resources.ApplyResources(this.label_DeviceType, "label_DeviceType");
            this.label_DeviceType.ForeColor = System.Drawing.Color.Red;
            this.label_DeviceType.Name = "label_DeviceType";
            // 
            // label_Name
            // 
            resources.ApplyResources(this.label_Name, "label_Name");
            this.label_Name.ForeColor = System.Drawing.Color.Red;
            this.label_Name.Name = "label_Name";
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Clear.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Clear, "button_Clear");
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Add.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Add, "button_Add");
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Name = "button_Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_EnvironmentDeviceRegisterUrl
            // 
            this.textBox_EnvironmentDeviceRegisterUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_EnvironmentDeviceRegisterUrl, "textBox_EnvironmentDeviceRegisterUrl");
            this.textBox_EnvironmentDeviceRegisterUrl.Name = "textBox_EnvironmentDeviceRegisterUrl";
            this.textBox_EnvironmentDeviceRegisterUrl.TextChanged += new System.EventHandler(this.textBox_EnvironmentDeviceRegisterUrl_TextChanged);
            this.textBox_EnvironmentDeviceRegisterUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentDeviceRegisterUrl_KeyPress);
            // 
            // textBox_EnvironmentClientSecret
            // 
            this.textBox_EnvironmentClientSecret.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_EnvironmentClientSecret, "textBox_EnvironmentClientSecret");
            this.textBox_EnvironmentClientSecret.Name = "textBox_EnvironmentClientSecret";
            this.textBox_EnvironmentClientSecret.TextChanged += new System.EventHandler(this.textBox_EnvironmentClientSecret_TextChanged);
            this.textBox_EnvironmentClientSecret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentClientSecret_KeyPress);
            // 
            // label_EnvironmentDeviceRegisterUrl
            // 
            resources.ApplyResources(this.label_EnvironmentDeviceRegisterUrl, "label_EnvironmentDeviceRegisterUrl");
            this.label_EnvironmentDeviceRegisterUrl.Name = "label_EnvironmentDeviceRegisterUrl";
            // 
            // label_EnvironmentClientSecret
            // 
            resources.ApplyResources(this.label_EnvironmentClientSecret, "label_EnvironmentClientSecret");
            this.label_EnvironmentClientSecret.Name = "label_EnvironmentClientSecret";
            // 
            // textBox_EnvironmentKeyValutUrl
            // 
            this.textBox_EnvironmentKeyValutUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentKeyValutUrl.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.textBox_EnvironmentKeyValutUrl, "textBox_EnvironmentKeyValutUrl");
            this.textBox_EnvironmentKeyValutUrl.Name = "textBox_EnvironmentKeyValutUrl";
            this.textBox_EnvironmentKeyValutUrl.TextChanged += new System.EventHandler(this.textBox_EnvironmentKeyValutUrl_TextChanged);
            this.textBox_EnvironmentKeyValutUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentKeyValutUrl_KeyPress);
            // 
            // label_EnvironmentKeyValutUrl
            // 
            resources.ApplyResources(this.label_EnvironmentKeyValutUrl, "label_EnvironmentKeyValutUrl");
            this.label_EnvironmentKeyValutUrl.Name = "label_EnvironmentKeyValutUrl";
            // 
            // textBox_EnvironmentPlatformName
            // 
            this.textBox_EnvironmentPlatformName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_EnvironmentPlatformName, "textBox_EnvironmentPlatformName");
            this.textBox_EnvironmentPlatformName.Name = "textBox_EnvironmentPlatformName";
            this.textBox_EnvironmentPlatformName.TextChanged += new System.EventHandler(this.textBox_EnvironmentPlatformName_TextChanged);
            this.textBox_EnvironmentPlatformName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentPlatformName_KeyPress);
            // 
            // textBox_EnvironmentClientId
            // 
            this.textBox_EnvironmentClientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_EnvironmentClientId, "textBox_EnvironmentClientId");
            this.textBox_EnvironmentClientId.Name = "textBox_EnvironmentClientId";
            this.textBox_EnvironmentClientId.TextChanged += new System.EventHandler(this.textBox_EnvironmentClientId_TextChanged);
            this.textBox_EnvironmentClientId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentClientId_KeyPress);
            // 
            // label_EnvironmentPlatformName
            // 
            resources.ApplyResources(this.label_EnvironmentPlatformName, "label_EnvironmentPlatformName");
            this.label_EnvironmentPlatformName.Name = "label_EnvironmentPlatformName";
            // 
            // textBox_EnvironmentTenantId
            // 
            this.textBox_EnvironmentTenantId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_EnvironmentTenantId, "textBox_EnvironmentTenantId");
            this.textBox_EnvironmentTenantId.Name = "textBox_EnvironmentTenantId";
            this.textBox_EnvironmentTenantId.TextChanged += new System.EventHandler(this.textBox_EnvironmentTenantId_TextChanged);
            this.textBox_EnvironmentTenantId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentTenantId_KeyPress);
            // 
            // label_EnvironmentClientId
            // 
            resources.ApplyResources(this.label_EnvironmentClientId, "label_EnvironmentClientId");
            this.label_EnvironmentClientId.Name = "label_EnvironmentClientId";
            // 
            // textBox_EnvironmentDeviceType
            // 
            this.textBox_EnvironmentDeviceType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_EnvironmentDeviceType, "textBox_EnvironmentDeviceType");
            this.textBox_EnvironmentDeviceType.Name = "textBox_EnvironmentDeviceType";
            this.textBox_EnvironmentDeviceType.TextChanged += new System.EventHandler(this.textBox_EnvironmentDeviceType_TextChanged);
            this.textBox_EnvironmentDeviceType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentDeviceType_KeyPress);
            // 
            // label_EnvironmentTenantId
            // 
            resources.ApplyResources(this.label_EnvironmentTenantId, "label_EnvironmentTenantId");
            this.label_EnvironmentTenantId.Name = "label_EnvironmentTenantId";
            // 
            // label_EnvironmentDeviceType
            // 
            resources.ApplyResources(this.label_EnvironmentDeviceType, "label_EnvironmentDeviceType");
            this.label_EnvironmentDeviceType.Name = "label_EnvironmentDeviceType";
            // 
            // textBox_EnvironmentName
            // 
            this.textBox_EnvironmentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_EnvironmentName, "textBox_EnvironmentName");
            this.textBox_EnvironmentName.Name = "textBox_EnvironmentName";
            this.textBox_EnvironmentName.TextChanged += new System.EventHandler(this.textBox_EnvironmentName_TextChanged);
            this.textBox_EnvironmentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EnvironmentName_KeyPress);
            // 
            // label_EnvironmentName
            // 
            resources.ApplyResources(this.label_EnvironmentName, "label_EnvironmentName");
            this.label_EnvironmentName.Name = "label_EnvironmentName";
            // 
            // EnvironmentSetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer_Environment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnvironmentSetting";
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