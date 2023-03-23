using ECOLAB.IOT.WinFormApp.ChildWinForm;
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
    public partial class CustomMessageBox : Form
    {
        private string _titleText = "提示";

        public string TitleText
        {
            get { return _titleText; }
            set { _titleText = value; }
        }


        private string _contentText = "暂无信息!";

        public string ContentText
        {
            get { return _contentText; }
            set { _contentText = value; }
        }

        Point _downPoint;
        void Control_MouseDown(object sender, MouseEventArgs e)
        {
            _downPoint = new Point(e.X, e.Y);
        }

        void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - _downPoint.X, this.Location.Y + e.Y - _downPoint.Y);
            }
        }

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public string GetFilePath()
        {
            return "test";
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            if (this._contentText.Trim() != "")
            {
                this.lblTitleContent.Text = this._titleText;
            }
        }
        private Form activeForm = null;
        private Form unActionedForm = null;
        private FormFileSend formNormal = new FormFileSend();
        private void AddChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                unActionedForm = activeForm;
                unActionedForm.Hide();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void dgwMode_CheckedChanged(object sender, EventArgs e)
        {
            AddChildForm(formNormal);
        }
        string theClickButton = "cancel";
        private void button1_Click(object sender, EventArgs e)
        {
            theClickButton = "confirm";
            this.Close();
        }

        public string showMessage()
        {

            //ShowDialog相当于线程暂停 此处的话就需要close或者dispose以后才会 return theClickButton;
            this.ShowDialog();
            return theClickButton;
        }
    }
}
