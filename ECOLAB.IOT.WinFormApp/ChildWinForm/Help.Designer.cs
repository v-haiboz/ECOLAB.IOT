namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    partial class Help
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
            this.button_instruction = new System.Windows.Forms.Button();
            this.button_troubleshooting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_instruction
            // 
            this.button_instruction.Location = new System.Drawing.Point(133, 145);
            this.button_instruction.Name = "button_instruction";
            this.button_instruction.Size = new System.Drawing.Size(192, 85);
            this.button_instruction.TabIndex = 0;
            this.button_instruction.Text = "Instruction";
            this.button_instruction.UseVisualStyleBackColor = true;
            // 
            // button_troubleshooting
            // 
            this.button_troubleshooting.Location = new System.Drawing.Point(444, 145);
            this.button_troubleshooting.Name = "button_troubleshooting";
            this.button_troubleshooting.Size = new System.Drawing.Size(192, 85);
            this.button_troubleshooting.TabIndex = 1;
            this.button_troubleshooting.Text = "Troubleshooting";
            this.button_troubleshooting.UseVisualStyleBackColor = true;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_troubleshooting);
            this.Controls.Add(this.button_instruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_instruction;
        private Button button_troubleshooting;
    }
}