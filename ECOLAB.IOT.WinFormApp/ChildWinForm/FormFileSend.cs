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
using YamlDotNet.Core;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class FormFileSend : Form
    {
        public FormFileSend()
        {
            InitializeComponent();
        }

        private List<DGWModeConfig> dGWModeConfigs = new List<DGWModeConfig>();
        public void Init()
        {
            comboBox_TransportProtocol.Items.Clear();
            comboBox_ModeName.Items.Clear();
            comboBox_Version.Items.Clear();
            var protacols = CallerContext.ECOLABIOTBurnSNAndPSKService.GetTransportProtocol();
            this.comboBox_TransportProtocol.Items.AddRange(protacols);
            comboBox_TransportProtocol.SelectedItem = Enum.GetName(TransportProtocol.Xmodem1k);
            //comboBox_TransportProtocol.Enabled = false;
            dGWModeConfigs = CallerContext.ECOLABIOTDGWModeService.GetDGWMode();
            if (dGWModeConfigs == null || dGWModeConfigs.Count == 0)
            {
                return;
            }

            var modeNames = dGWModeConfigs?.Select(item => item.ModeName).Distinct()?.ToArray();
            if (modeNames == null && modeNames.Length ==0)
            {
                return;
            }
            comboBox_ModeName.Items.AddRange(modeNames);

            if (comboBox_ModeName.Items.Count ==0)
            {
                return;
            }

            comboBox_ModeName.SelectedIndex = 0;
            BandingVersion(comboBox_ModeName.Text);
        }

        private void BandingVersion(string modeName)
        {
            comboBox_Version.Items.Clear();
            var versions = dGWModeConfigs.Where(m => m.ModeName == modeName).ToArray();
            comboBox_Version.DisplayMember = "Version";
            comboBox_Version.ValueMember = "FilePath";
            comboBox_Version.Items.AddRange(versions);
            if (comboBox_Version.Items.Count >= 0)
            {
                comboBox_Version.SelectedIndex = 0;
            }
        }

        private void FormFileSend_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void button_ChooseFile_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    textBox_ChooseFile.Text = openFileDialog.FileName;
            //}
        }

        private void comboBox_ModeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ModeName.Items.Count >= 0)
            {
                BandingVersion(comboBox_ModeName.Text);
            }
        }
    }
}
