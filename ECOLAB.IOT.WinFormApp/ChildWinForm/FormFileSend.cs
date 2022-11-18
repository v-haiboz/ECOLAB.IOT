using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
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
    public partial class FormFileSend : Form
    {
        public FormFileSend()
        {
            InitializeComponent();
        }
        private void Init()
        {
            var protacols = CallerContext.ECOLABIOTBurnSNAndPSKService.GetTransportProtocol();
            this.comboBox_TransportProtocol.Items.AddRange(protacols);
            comboBox_TransportProtocol.SelectedItem = Enum.GetName(TransportProtocol.Xmodem);
        }

        private void FormFileSend_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void button_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_ChooseFile.Text = openFileDialog.FileName;
            }
        }
    }
}
