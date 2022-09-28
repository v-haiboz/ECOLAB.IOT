using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class FormNormal : Form
    {
        public FormNormal()
        {
            InitializeComponent();
        }

        private void FormNormal_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_ClearSerialNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_SerialNumber.Text = "";
        }
    }
}
