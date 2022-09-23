using ECOLAB.IOT.Common.Utilities;
using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class BurnSNAndPSK : Form
    {
        System.Threading.SynchronizationContext m_SyncContext = null;
        SerialPort serialPort = null;
        private COMSetting setting = CallerContext.ECOLABIOTBurnSNAndPSKService.GetDefaultCOMSetting();
        public BurnSNAndPSK()
        {
            InitializeComponent();
            m_SyncContext = SynchronizationContext.Current;
        }
        private void BurnSNAndPSK_Load(object sender, EventArgs e)
        {
            Init();
        }

        #region init
        private void Init()
        {
            
            BandDingSerialPort();
            BandDingBaudRate();
            BandDingParityBit();
            BandDingDataBit();
            BandDingStopBit();
            SettDefault();
            serialPort = new SerialPort();
        }
        private void BandDingSerialPort()
        {
            var ports = CallerContext.ECOLABIOTBurnSNAndPSKService.GetPortNames();
            this.comboBox_SerialPort.Items.AddRange(ports);
        }

        private void BandDingBaudRate()
        {
            var array = CallerContext.ECOLABIOTBurnSNAndPSKService.GetBaudRate();
            this.comboBox_BaudRate.Items.AddRange(array);
        }

        private void BandDingParityBit()
        {
            var array = CallerContext.ECOLABIOTBurnSNAndPSKService.GetParityBit();
            this.comboBox_ParityBit.Items.AddRange(array);
        }
        private void BandDingDataBit()
        {
            var array = CallerContext.ECOLABIOTBurnSNAndPSKService.GetDataBit();
            this.comboBox_DataBit.Items.AddRange(array);
        }
        private void BandDingStopBit()
        {
            var array = CallerContext.ECOLABIOTBurnSNAndPSKService.GetStopBit();
            this.comboBox_StopBit.Items.AddRange(array);
        }

        private void SettDefault()
        {
            comboBox_SerialPort.SelectedItem= setting.PortName;
            comboBox_BaudRate.SelectedItem = Enum.GetName(setting.BaudRate);
            comboBox_ParityBit.SelectedItem = Enum.GetName(setting.Parity);
            comboBox_DataBit.SelectedItem = Enum.GetName(setting.DataBit);
            comboBox_StopBit.SelectedItem = Enum.GetName(setting.StopBit);
        }

        private void EnableOrDisableSetting(bool bl = false)
        {
            comboBox_SerialPort.Enabled= bl;
            comboBox_BaudRate.Enabled = bl;
            comboBox_ParityBit.Enabled = bl;
            comboBox_DataBit.Enabled = bl;
            comboBox_StopBit.Enabled = bl;
            button_Reset.Enabled = bl;
        }
        #endregion

        private void textBox_SerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            var keyChar = e.KeyChar.ToString();
            ValidateSN(this.textBox_SerialNumber.Text + keyChar);
        }

        private bool ValidateSN(string sn)
        {
            var bl = true;
            if (!this.checkBox_ValidateSN.Checked)
            {
                this.label_SerualNubmer_Validate.Text = "";
                bl = true;
            }
            else if (string.IsNullOrEmpty(sn))
            {
                this.label_SerualNubmer_Validate.Text = "SN is Empty, pls input SN";
                bl = false;
            }
            else if(!Utilities.ValidateSN(sn, out string message))
            {
                this.label_SerualNubmer_Validate.Text = $"SN format is incorrect.\r\n{message}";
                bl = false;
            }
            else {
                this.label_SerualNubmer_Validate.Text = "";
            }

            DisableOrEnableGeneratePSKButton();
            return bl;
        }

        private void checkBox_ValidateSN_CheckedChanged(object sender, EventArgs e)
        {
            ValidateSN(this.textBox_SerialNumber.Text);
        }

        private  void button_GeneratePSK_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                return;
            }

            this.button_GeneratePSK.Enabled = false;
            Travel();
            this.button_GeneratePSK.Enabled = true;

        }
        private new bool Validate()
        {
            if (ValidateSN(this.textBox_SerialNumber.Text))
            {
                return false;
            }
            if (this.comboBox_SerialPort.SelectedItem.ToString() == null)
            {
                return false;
            }
            if (this.comboBox_BaudRate.SelectedItem.ToString() == null)
            {
                return false;
            }

            return true;
        }

        private void Travel()
        {
            SetSecret("deomkey", "asdc");
        }

        private void SetSecret(string key,string value)
        {
            CallerContext.ECOLABIOTSecretService.SetSecret(key,value);
        }
        private void DisableOrEnableGeneratePSKButton()
        {
            if (button_Connection.Text == "Disconnection" && string.IsNullOrEmpty(label_SerualNubmer_Validate.Text) && !string.IsNullOrEmpty(textBox_SerialNumber.Text))
            {
                button_GeneratePSK.BackColor = Color.FromArgb(0, 192, 0);
                button_GeneratePSK.Enabled = true;
            }
            else 
            {
                button_GeneratePSK.BackColor = SystemColors.AppWorkspace;
                button_GeneratePSK.Enabled = false;
            }
        }

        private void button_Connection_Click(object sender, EventArgs e)
        {
            Open();
            DisableOrEnableGeneratePSKButton();
        }

        private void Open()
        {
            string portName = comboBox_SerialPort.Text;
            var buadRate = comboBox_BaudRate.Text.GetEnumValue<BaudRates>();
            Parity parity = comboBox_ParityBit.Text.ToEnum<Parity>();
            int dataBit = comboBox_DataBit.Text.GetEnumValue<DataBits>();
            StopBits stopBits = comboBox_StopBit.Text.ToEnum<StopBits>();
            
            try
            {
                if (button_Connection.Text == "Connection")
                {
                    serialPort = new SerialPort(portName, buadRate, parity, dataBit, stopBits);
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close();
                    }
                    serialPort.Open();
                    EnableOrDisableSetting();
                    pictureBox_Connection.Image = Properties.Resources.connection_BurnSN;
                    button_Connection.BackColor = Color.DarkRed;
                    button_Connection.Text = "Disconnection";
                }
                else if (button_Connection.Text == "Disconnection")
                {
                    serialPort.Close();
                    EnableOrDisableSetting(true);
                    pictureBox_Connection.Image = Properties.Resources.breakoff_BurnSN;
                    button_Connection.BackColor = SystemColors.Highlight;
                    button_Connection.Text = "Connection";
                }
            }
            catch (Exception errror)
            {
                MessageBox.Show(errror.Message);
            }

            serialPort.DataReceived += onDataReceived;
        }
        private void onDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Byte[] bytes = new byte[serialPort.BytesToRead];
                serialPort.Read(bytes, 0, serialPort.BytesToRead);
                m_SyncContext.Post(new SendOrPostCallback((obj) =>
                {
                    richTextBox_Output.AppendText(Encoding.Default.GetString(bytes));
                }), bytes);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            SettDefault();
        }

        private void BurnSNAndPSK_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                serialPort = null;
            }
        }

        private void textBox_SerialNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateSN(this.textBox_SerialNumber.Text);
        }

        private void textBox_SerialNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateSN(this.textBox_SerialNumber.Text);
        }
    }
}
