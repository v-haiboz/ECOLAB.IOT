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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer_Environment = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Environment = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_EnvironmentClientSecret = new System.Windows.Forms.TextBox();
            this.label_EnvironmentClientSecret = new System.Windows.Forms.Label();
            this.textBox_EnvironmentKeyValutUrl = new System.Windows.Forms.TextBox();
            this.label_EnvironmentKeyValutUrl = new System.Windows.Forms.Label();
            this.textBox_EnvironmentClientId = new System.Windows.Forms.TextBox();
            this.textBox_EnvironmentTenantId = new System.Windows.Forms.TextBox();
            this.label_EnvironmentClientId = new System.Windows.Forms.Label();
            this.label_EnvironmentTenantId = new System.Windows.Forms.Label();
            this.textBox_EnvironmentName = new System.Windows.Forms.TextBox();
            this.label_EnvironmentName = new System.Windows.Forms.Label();
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
            this.splitContainer_Environment.SplitterDistance = 454;
            this.splitContainer_Environment.TabIndex = 0;
            // 
            // dataGridView_Environment
            // 
            this.dataGridView_Environment.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Environment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Environment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Environment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Environment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Environment.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Environment.Name = "dataGridView_Environment";
            this.dataGridView_Environment.RowHeadersWidth = 62;
            this.dataGridView_Environment.RowTemplate.Height = 32;
            this.dataGridView_Environment.Size = new System.Drawing.Size(1370, 454);
            this.dataGridView_Environment.TabIndex = 0;
            this.dataGridView_Environment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Environment_CellClick);
            this.dataGridView_Environment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Environment_CellContentClick);
            this.dataGridView_Environment.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_Environment_RowPrePaint);
            this.dataGridView_Environment.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_Environment_RowsAdded);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentClientSecret);
            this.groupBox1.Controls.Add(this.label_EnvironmentClientSecret);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentKeyValutUrl);
            this.groupBox1.Controls.Add(this.label_EnvironmentKeyValutUrl);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentClientId);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentTenantId);
            this.groupBox1.Controls.Add(this.label_EnvironmentClientId);
            this.groupBox1.Controls.Add(this.label_EnvironmentTenantId);
            this.groupBox1.Controls.Add(this.textBox_EnvironmentName);
            this.groupBox1.Controls.Add(this.label_EnvironmentName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1370, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maintenance information";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_Add.Enabled = false;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(665, 153);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(204, 34);
            this.button_Add.TabIndex = 15;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_EnvironmentClientSecret
            // 
            this.textBox_EnvironmentClientSecret.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentClientSecret.Location = new System.Drawing.Point(291, 153);
            this.textBox_EnvironmentClientSecret.Multiline = true;
            this.textBox_EnvironmentClientSecret.Name = "textBox_EnvironmentClientSecret";
            this.textBox_EnvironmentClientSecret.Size = new System.Drawing.Size(183, 30);
            this.textBox_EnvironmentClientSecret.TabIndex = 14;
            // 
            // label_EnvironmentClientSecret
            // 
            this.label_EnvironmentClientSecret.AutoSize = true;
            this.label_EnvironmentClientSecret.Location = new System.Drawing.Point(148, 157);
            this.label_EnvironmentClientSecret.Name = "label_EnvironmentClientSecret";
            this.label_EnvironmentClientSecret.Size = new System.Drawing.Size(117, 24);
            this.label_EnvironmentClientSecret.TabIndex = 13;
            this.label_EnvironmentClientSecret.Text = "ClientSecret:";
            // 
            // textBox_EnvironmentKeyValutUrl
            // 
            this.textBox_EnvironmentKeyValutUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentKeyValutUrl.Location = new System.Drawing.Point(665, 108);
            this.textBox_EnvironmentKeyValutUrl.Multiline = true;
            this.textBox_EnvironmentKeyValutUrl.Name = "textBox_EnvironmentKeyValutUrl";
            this.textBox_EnvironmentKeyValutUrl.Size = new System.Drawing.Size(547, 30);
            this.textBox_EnvironmentKeyValutUrl.TabIndex = 9;
            // 
            // label_EnvironmentKeyValutUrl
            // 
            this.label_EnvironmentKeyValutUrl.AutoSize = true;
            this.label_EnvironmentKeyValutUrl.Location = new System.Drawing.Point(520, 108);
            this.label_EnvironmentKeyValutUrl.Name = "label_EnvironmentKeyValutUrl";
            this.label_EnvironmentKeyValutUrl.Size = new System.Drawing.Size(115, 24);
            this.label_EnvironmentKeyValutUrl.TabIndex = 5;
            this.label_EnvironmentKeyValutUrl.Text = "KeyValutUrl:";
            // 
            // textBox_EnvironmentClientId
            // 
            this.textBox_EnvironmentClientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentClientId.Location = new System.Drawing.Point(291, 104);
            this.textBox_EnvironmentClientId.Multiline = true;
            this.textBox_EnvironmentClientId.Name = "textBox_EnvironmentClientId";
            this.textBox_EnvironmentClientId.Size = new System.Drawing.Size(183, 30);
            this.textBox_EnvironmentClientId.TabIndex = 10;
            // 
            // textBox_EnvironmentTenantId
            // 
            this.textBox_EnvironmentTenantId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentTenantId.Location = new System.Drawing.Point(665, 51);
            this.textBox_EnvironmentTenantId.Multiline = true;
            this.textBox_EnvironmentTenantId.Name = "textBox_EnvironmentTenantId";
            this.textBox_EnvironmentTenantId.Size = new System.Drawing.Size(204, 30);
            this.textBox_EnvironmentTenantId.TabIndex = 11;
            // 
            // label_EnvironmentClientId
            // 
            this.label_EnvironmentClientId.AutoSize = true;
            this.label_EnvironmentClientId.Location = new System.Drawing.Point(184, 105);
            this.label_EnvironmentClientId.Name = "label_EnvironmentClientId";
            this.label_EnvironmentClientId.Size = new System.Drawing.Size(81, 24);
            this.label_EnvironmentClientId.TabIndex = 6;
            this.label_EnvironmentClientId.Text = "ClientId:";
            // 
            // label_EnvironmentTenantId
            // 
            this.label_EnvironmentTenantId.AutoSize = true;
            this.label_EnvironmentTenantId.Location = new System.Drawing.Point(545, 57);
            this.label_EnvironmentTenantId.Name = "label_EnvironmentTenantId";
            this.label_EnvironmentTenantId.Size = new System.Drawing.Size(90, 24);
            this.label_EnvironmentTenantId.TabIndex = 7;
            this.label_EnvironmentTenantId.Text = "TenantId:";
            // 
            // textBox_EnvironmentName
            // 
            this.textBox_EnvironmentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EnvironmentName.Location = new System.Drawing.Point(291, 51);
            this.textBox_EnvironmentName.Multiline = true;
            this.textBox_EnvironmentName.Name = "textBox_EnvironmentName";
            this.textBox_EnvironmentName.Size = new System.Drawing.Size(183, 30);
            this.textBox_EnvironmentName.TabIndex = 12;
            // 
            // label_EnvironmentName
            // 
            this.label_EnvironmentName.AutoSize = true;
            this.label_EnvironmentName.Location = new System.Drawing.Point(199, 51);
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
    }
}