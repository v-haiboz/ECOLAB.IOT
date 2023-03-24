using ECOLAB.IOT.Entity;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class FormFileSend : Form
    {
        private CustomMessageBoxDialogResult customMessageBoxDialogResult;
        private string sourceString = string.Empty;
        public FormFileSend(CustomMessageBoxDialogResult customMessageBoxDialogResult)
        {
            this.customMessageBoxDialogResult = customMessageBoxDialogResult;
            InitializeComponent();
        }

        private List<DGWModeConfig> dGWModeConfigs = new List<DGWModeConfig>();
        public void Init()
        {
            sourceString = textBox_SerialNumber.Text;
        }


        private void FormFileSend_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void linkLabel_ClearSerialNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_SerialNumber.Text = "DGW";
        }

        

        private void textBox_SerialNumber_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox_SerialNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue == (char)Keys.Delete || e.KeyValue == (char)Keys.Back) && !textBox_SerialNumber.Text.Contains("DGW"))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                textBox_SerialNumber.Text = sourceString;
                return;
            }

            sourceString = textBox_SerialNumber.Text;
        }
    }
}
