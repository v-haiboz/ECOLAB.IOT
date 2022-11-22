namespace ECOLAB.IOT.WinFormApp
{
    partial class DGWMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DGWMode));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_Version_Validate = new System.Windows.Forms.Label();
            this.label_ModeName_Validate = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.textBox_ModeName = new System.Windows.Forms.TextBox();
            this.textBox_Version = new System.Windows.Forms.TextBox();
            this.label_ChooseFile_Validate = new System.Windows.Forms.Label();
            this.button_ChooseFile = new System.Windows.Forms.Button();
            this.textBox_ChooseFile = new System.Windows.Forms.TextBox();
            this.label_ChooseFile = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.label_ModeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.label_Version_Validate);
            this.splitContainer1.Panel2.Controls.Add(this.label_ModeName_Validate);
            this.splitContainer1.Panel2.Controls.Add(this.button_Save);
            this.splitContainer1.Panel2.Controls.Add(this.button_Clear);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_ModeName);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_Version);
            this.splitContainer1.Panel2.Controls.Add(this.label_ChooseFile_Validate);
            this.splitContainer1.Panel2.Controls.Add(this.button_ChooseFile);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_ChooseFile);
            this.splitContainer1.Panel2.Controls.Add(this.label_ChooseFile);
            this.splitContainer1.Panel2.Controls.Add(this.label_Version);
            this.splitContainer1.Panel2.Controls.Add(this.label_ModeName);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label_Version_Validate
            // 
            resources.ApplyResources(this.label_Version_Validate, "label_Version_Validate");
            this.label_Version_Validate.ForeColor = System.Drawing.Color.Red;
            this.label_Version_Validate.Name = "label_Version_Validate";
            // 
            // label_ModeName_Validate
            // 
            resources.ApplyResources(this.label_ModeName_Validate, "label_ModeName_Validate");
            this.label_ModeName_Validate.ForeColor = System.Drawing.Color.Red;
            this.label_ModeName_Validate.Name = "label_ModeName_Validate";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Save.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Save, "button_Save");
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Name = "button_Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
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
            // textBox_ModeName
            // 
            this.textBox_ModeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_ModeName, "textBox_ModeName");
            this.textBox_ModeName.Name = "textBox_ModeName";
            this.textBox_ModeName.TextChanged += new System.EventHandler(this.textBox_ModeName_TextChanged);
            this.textBox_ModeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ModeName_KeyPress);
            // 
            // textBox_Version
            // 
            this.textBox_Version.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_Version, "textBox_Version");
            this.textBox_Version.Name = "textBox_Version";
            this.textBox_Version.TextChanged += new System.EventHandler(this.textBox_Version_TextChanged);
            this.textBox_Version.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Version_KeyPress);
            // 
            // label_ChooseFile_Validate
            // 
            resources.ApplyResources(this.label_ChooseFile_Validate, "label_ChooseFile_Validate");
            this.label_ChooseFile_Validate.ForeColor = System.Drawing.Color.Red;
            this.label_ChooseFile_Validate.Name = "label_ChooseFile_Validate";
            // 
            // button_ChooseFile
            // 
            this.button_ChooseFile.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_ChooseFile.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_ChooseFile, "button_ChooseFile");
            this.button_ChooseFile.ForeColor = System.Drawing.Color.White;
            this.button_ChooseFile.Name = "button_ChooseFile";
            this.button_ChooseFile.UseVisualStyleBackColor = false;
            this.button_ChooseFile.Click += new System.EventHandler(this.button_ChooseFile_Click);
            // 
            // textBox_ChooseFile
            // 
            this.textBox_ChooseFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_ChooseFile, "textBox_ChooseFile");
            this.textBox_ChooseFile.Name = "textBox_ChooseFile";
            this.textBox_ChooseFile.TextChanged += new System.EventHandler(this.textBox_ChooseFile_TextChanged);
            this.textBox_ChooseFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ChooseFile_KeyPress);
            // 
            // label_ChooseFile
            // 
            resources.ApplyResources(this.label_ChooseFile, "label_ChooseFile");
            this.label_ChooseFile.Name = "label_ChooseFile";
            // 
            // label_Version
            // 
            resources.ApplyResources(this.label_Version, "label_Version");
            this.label_Version.Name = "label_Version";
            // 
            // label_ModeName
            // 
            resources.ApplyResources(this.label_ModeName, "label_ModeName");
            this.label_ModeName.Name = "label_ModeName";
            // 
            // DGWMode
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DGWMode";
            this.Load += new System.EventHandler(this.DGWMode_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Label label_Version;
        private Label label_ModeName;
        public Label label_ChooseFile_Validate;
        public Button button_ChooseFile;
        public TextBox textBox_ChooseFile;
        public Label label_ChooseFile;
        private Button button_Save;
        private Button button_Clear;
        public TextBox textBox_ModeName;
        public TextBox textBox_Version;
        public Label label_Version_Validate;
        public Label label_ModeName_Validate;
    }
}