namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    partial class ApplicationSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationSetting));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox_TargetPrefix = new System.Windows.Forms.TextBox();
            this.label_TargetPrefix = new System.Windows.Forms.Label();
            this.label_Add = new System.Windows.Forms.Label();
            this.textBox_SourcePerfix = new System.Windows.Forms.TextBox();
            this.label_SourcePrefix = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.textBox_TargetPrefix);
            this.splitContainer2.Panel1.Controls.Add(this.label_TargetPrefix);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel2.Controls.Add(this.label_Add);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_SourcePerfix);
            this.splitContainer2.Panel2.Controls.Add(this.label_SourcePrefix);
            // 
            // textBox_TargetPrefix
            // 
            this.textBox_TargetPrefix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_TargetPrefix, "textBox_TargetPrefix");
            this.textBox_TargetPrefix.Name = "textBox_TargetPrefix";
            this.textBox_TargetPrefix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TargetPrefix_KeyPress);
            // 
            // label_TargetPrefix
            // 
            resources.ApplyResources(this.label_TargetPrefix, "label_TargetPrefix");
            this.label_TargetPrefix.Name = "label_TargetPrefix";
            // 
            // label_Add
            // 
            resources.ApplyResources(this.label_Add, "label_Add");
            this.label_Add.Name = "label_Add";
            this.label_Add.Click += new System.EventHandler(this.label_Add_Click);
            // 
            // textBox_SourcePerfix
            // 
            this.textBox_SourcePerfix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_SourcePerfix, "textBox_SourcePerfix");
            this.textBox_SourcePerfix.Name = "textBox_SourcePerfix";
            this.textBox_SourcePerfix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TargetPrefix_KeyPress);
            // 
            // label_SourcePrefix
            // 
            resources.ApplyResources(this.label_SourcePrefix, "label_SourcePrefix");
            this.label_SourcePrefix.Name = "label_SourcePrefix";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button_Clear);
            this.panel1.Controls.Add(this.button_Add);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ApplicationSetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApplicationSetting";
            this.Load += new System.EventHandler(this.ApplicationSetting_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TextBox textBox_TargetPrefix;
        private Label label_TargetPrefix;
        private TextBox textBox_SourcePerfix;
        private Label label_SourcePrefix;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button_Add;
        private Label label_Add;
        private Button button_Clear;
    }
}