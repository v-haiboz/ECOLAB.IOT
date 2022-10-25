namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    partial class AADSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AADSetting));
            this.label_ADDTentId = new System.Windows.Forms.Label();
            this.label_ADDClientId = new System.Windows.Forms.Label();
            this.label_ADDInstance = new System.Windows.Forms.Label();
            this.textBox_TentId = new System.Windows.Forms.TextBox();
            this.richTextBox_Instance = new System.Windows.Forms.RichTextBox();
            this.textBox_ClientId = new System.Windows.Forms.TextBox();
            this.button_Modify = new System.Windows.Forms.Button();
            this.label_TentId = new System.Windows.Forms.Label();
            this.label_ClientId = new System.Windows.Forms.Label();
            this.label_Instance = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ADDTentId
            // 
            resources.ApplyResources(this.label_ADDTentId, "label_ADDTentId");
            this.label_ADDTentId.Name = "label_ADDTentId";
            // 
            // label_ADDClientId
            // 
            resources.ApplyResources(this.label_ADDClientId, "label_ADDClientId");
            this.label_ADDClientId.Name = "label_ADDClientId";
            // 
            // label_ADDInstance
            // 
            resources.ApplyResources(this.label_ADDInstance, "label_ADDInstance");
            this.label_ADDInstance.Name = "label_ADDInstance";
            // 
            // textBox_TentId
            // 
            this.textBox_TentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_TentId, "textBox_TentId");
            this.textBox_TentId.Name = "textBox_TentId";
            this.textBox_TentId.TextChanged += new System.EventHandler(this.textBox_TentId_TextChanged);
            this.textBox_TentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TentId_KeyPress);
            // 
            // richTextBox_Instance
            // 
            this.richTextBox_Instance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox_Instance, "richTextBox_Instance");
            this.richTextBox_Instance.Name = "richTextBox_Instance";
            this.richTextBox_Instance.TextChanged += new System.EventHandler(this.richTextBox_Instance_TextChanged);
            this.richTextBox_Instance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_Instance_KeyPress);
            // 
            // textBox_ClientId
            // 
            this.textBox_ClientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_ClientId, "textBox_ClientId");
            this.textBox_ClientId.Name = "textBox_ClientId";
            this.textBox_ClientId.TextChanged += new System.EventHandler(this.textBox_ClientId_TextChanged);
            this.textBox_ClientId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ClientId_KeyPress);
            // 
            // button_Modify
            // 
            this.button_Modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Modify.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Modify, "button_Modify");
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.UseVisualStyleBackColor = false;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // label_TentId
            // 
            resources.ApplyResources(this.label_TentId, "label_TentId");
            this.label_TentId.ForeColor = System.Drawing.Color.Red;
            this.label_TentId.Name = "label_TentId";
            // 
            // label_ClientId
            // 
            resources.ApplyResources(this.label_ClientId, "label_ClientId");
            this.label_ClientId.ForeColor = System.Drawing.Color.Red;
            this.label_ClientId.Name = "label_ClientId";
            // 
            // label_Instance
            // 
            resources.ApplyResources(this.label_Instance, "label_Instance");
            this.label_Instance.ForeColor = System.Drawing.Color.Red;
            this.label_Instance.Name = "label_Instance";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Save.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Save, "button_Save");
            this.button_Save.Name = "button_Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // AADSetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label_Instance);
            this.Controls.Add(this.label_ClientId);
            this.Controls.Add(this.label_TentId);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.richTextBox_Instance);
            this.Controls.Add(this.textBox_ClientId);
            this.Controls.Add(this.textBox_TentId);
            this.Controls.Add(this.label_ADDInstance);
            this.Controls.Add(this.label_ADDClientId);
            this.Controls.Add(this.label_ADDTentId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AADSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_ADDTentId;
        private Label label_ADDClientId;
        private Label label_ADDInstance;
        private TextBox textBox_TentId;
        private RichTextBox richTextBox_Instance;
        private TextBox textBox_ClientId;
        private Button button_Modify;
        private Label label_TentId;
        private Label label_ClientId;
        private Label label_Instance;
        private Button button_Save;
    }
}