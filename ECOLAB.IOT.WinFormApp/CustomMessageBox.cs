using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using System.Data;

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

        private List<DGWModeConfig> dGWModeConfigs = new List<DGWModeConfig>();
        public CustomMessageBox()
        {
            Thread.CurrentThread.CurrentUICulture = CallerContext.currentCulture;
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            comboBox_TransportProtocol.Items.Clear();
            comboBox_ModeName.Items.Clear();
            comboBox_Version.Items.Clear();
            var protacols = CallerContext.ECOLABIOTBurnSNAndPSKService.GetTransportProtocol();
            this.comboBox_TransportProtocol.Items.AddRange(protacols);
            comboBox_TransportProtocol.SelectedItem = Enum.GetName(TransportProtocol.Xmodem1k);
            // comboBox_TransportProtocol.Enabled = false;
            dGWModeConfigs = CallerContext.ECOLABIOTDGWModeService.GetDGWMode();
            if (dGWModeConfigs == null || dGWModeConfigs.Count == 0)
            {
                return;
            }

            var modeNames = dGWModeConfigs?.Select(item => item.ModeName).Distinct()?.ToArray();
            if (modeNames == null && modeNames.Length == 0)
            {
                return;
            }
            comboBox_ModeName.Items.AddRange(modeNames);

            if (comboBox_ModeName.Items.Count == 0)
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

        private void ShowMode()
        {
            if (dgwMode.Checked)
            {
                if (!panel_ChooseFile.Visible)
                {
                    this.Size = new Size(this.Size.Width, this.Size.Height + panel_ChooseFile.Size.Height);
                }
                panel_ChooseFile.Visible = true;
            }
            else
            {
                if (panel_ChooseFile.Visible)
                {
                    this.Size = new Size(this.Size.Width, this.Size.Height - panel_ChooseFile.Size.Height);
                }
                panel_ChooseFile.Visible = false;
            }
        }


        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            //if (this._contentText.Trim() != "")
            //{
            //    this.lblTitleContent.Text = this._titleText;
            //}

            ShowMode();
        }

        private void dgwMode_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox_ModeName.Items.Count >= 0)
            {
                BandingVersion(comboBox_ModeName.Text);
            }
        }

        CustomMessageBoxDialogResult customMessageBoxDialogResult = new CustomMessageBoxDialogResult();
        public CustomMessageBoxDialogResult GetCustomMessageBoxDialogResult()
        {

            this.ShowDialog();
            return customMessageBoxDialogResult;
        }

        private void normalMode_Click(object sender, EventArgs e)
        {
            ShowMode();
        }

        private void dgwMode_Click(object sender, EventArgs e)
        {
            ShowMode();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            customMessageBoxDialogResult = GetDialogResult(DialogResult.Cancel);
            this.Close();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            customMessageBoxDialogResult = GetDialogResult(DialogResult.OK);
            if (customMessageBoxDialogResult.DialogResult == DialogResult.Ignore)
            {
                return;
            }
            this.Close();
        }

        private CustomMessageBoxDialogResult GetDialogResult(DialogResult dialogResult)
        {
            if (dgwMode.Checked)
            {
                var dgwModeConfig = comboBox_Version.SelectedItem as DGWModeConfig;
                if (dgwModeConfig == null || string.IsNullOrEmpty(dgwModeConfig.FilePath) || !File.Exists(dgwModeConfig.FilePath))
                {
                    return new CustomMessageBoxDialogResult()
                    {
                        ModeEnum = ModeEnum.DGWMode,
                        DialogResult = dialogResult== DialogResult.Cancel? DialogResult.Cancel: DialogResult.Ignore
                    };
                }

                return new CustomMessageBoxDialogResult()
                {
                    DialogResult = dialogResult,
                    ModeEnum = ModeEnum.DGWMode,
                    DGWModeConfig = dgwModeConfig,
                    TransportProtocol = comboBox_TransportProtocol.Text,
                    IsCRC = checkBox_isCRC.Checked
                };
            }

            return new CustomMessageBoxDialogResult()
            {
                DialogResult = dialogResult
            };
        }
    }
}
