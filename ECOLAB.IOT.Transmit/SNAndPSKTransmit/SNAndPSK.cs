namespace ECOLAB.IOT.Transmit.SNAndPSKSend
{
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using ECOLAB.IOT.Service;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.IO.Ports;
    using System.Security.Policy;
    using System.Threading.Tasks;
    using static ECOLAB.IOT.Transmit.ITransmitUart;

    public class SNAndPSK : ITransmitUart
    {
        public SNAndPSK(SerialPort serialPort, string sn,string prefix, Func<string, string> transform)
        {
            this.serialPort = serialPort;
            this.sn = sn;
            this.prefix = prefix;
            this.TransForm = transform;

        }
        const string splitText = "==================================================================\r\n";
        private string prefix;
        private string Prefix
        {
            get { return prefix; }
            set
            {
                prefix = value;
            }
        }
        private SerialPort serialPort;
        public SerialPort SerialPort
        {
            get { return serialPort; }
        }

        private string sn;
        public string SN
        {
            get
            {
                return sn;
            }
            set
            {
                sn = value;
            }
        }
        private string psk;

        public event ITransmitUart.OutPutEventHandler OutPutEvent;
        public event EventHandler SendResultEvent;
        public event MessageBoxEventHandler MessageBoxEvent;
        public event Transforer OutTransforer;

        public Func<string, string> TransForm;

        public string PSK
        {
            get
            {
                return psk;
            }
            set
            {
                psk = value;
            }
        }

        public bool Send(bool isformNormal=true)
        {
            var bl = false;
            SendResultEvent(KeyValuePair.Create(true, isformNormal), null);
            try
            {
                if (!SetSecret($"{sn}PSK", Utilities.RandomGenerateString(), out string psk))
                {
                    return bl;
                }

                if (!SetupToIoTHub(sn, psk))
                {
                    return bl;
                }

                if (!isformNormal && !CheckDeviceConfig(sn, psk))
                {
                    return bl;
                }

                var result = RegisterDevice(sn, prefix).Result;
                if (result.Status == Status.OK)
                {
                    if (MessageBoxEvent != null && TransForm != null)
                    {
                        var text = TransForm("message_CommonSendPattern_suceess");
                        var caption = TransForm("message");
                        MessageBoxEvent(this, new TrackerMessageBox(text, caption));
                    }
                }
                else
                {
                    if (OutPutEvent != null && TransForm != null)
                    {
                        OutPutEvent(this, new TrackerReceiveData($"{TransForm("message_RegisterDevice_failed")}"));
                    }

                    if (MessageBoxEvent != null && TransForm != null)
                    {
                        var text = TransForm("message_RegisterDevice_failed");
                        var caption = TransForm("message");
                        MessageBoxEvent(this, new TrackerMessageBox(result.Message, caption));
                    }

                    if (OutPutEvent != null && TransForm != null)
                    {
                        OutPutEvent(this, new TrackerReceiveData($"{TransForm("message_CommonSendPattern_failed")}"));
                    }

                    return bl;
                }

                if (OutPutEvent != null && TransForm != null)
                {
                    OutPutEvent(this, new TrackerReceiveData($"{TransForm("message_CommonSendPattern_suceess1")}"));
                }

                return bl=true;
            }
            catch (Exception ex)
            {
                if (OutPutEvent != null && TransForm != null)
                {
                    OutPutEvent(this, new TrackerReceiveData($"{TransForm("message_Travel_failed")}"));
                }

                return false;
            }
            finally
            {
                if (isformNormal || !bl)
                {
                    SendResultEvent(KeyValuePair.Create(false, isformNormal), null);
                }
            }
        }

        #region Register Device
        private async Task<TData<string>> RegisterDevice(string sn,string prefix)
        {
            // TO DO: we will  config it on page of application
            var model = new DeviceRegister()
            {
                IsEnabled = "true",
                DeviceType = prefix,
                PlatformName = CallerContext.AppServiceOptions.PlatformName,
                SerialNumber = sn
            };

            var result = await CallerContext.ECOLABIOTRegisterDeviceService.RegisterDevice(model).ConfigureAwait(false);
            return result;
        }
        #endregion
        #region genereate psk, and then send to keyvalut.
        private bool SetSecret(string key, string value, out string psk)
        {
            psk = "";
            try
            {
                if (CallerContext.ECOLABIOTSecretService.ExistSecret(key))
                {
                    psk = CallerContext.ECOLABIOTSecretService.GetSecret(key);
                    return true;
                }

                psk = CallerContext.ECOLABIOTSecretService.SetSecret(key, value);
                return true;
            }
            catch (Exception ex)
            {
                if (OutPutEvent != null && TransForm != null)
                {
                    OutPutEvent(this, new TrackerReceiveData($"{splitText}{TransForm("message_SetSecret_error")}"));
                }

                if (MessageBoxEvent != null && TransForm != null)
                {
                    var message = TransForm("message_SetSecret_error");
                    MessageBoxEvent(this, new TrackerMessageBox($"{message} {ex}", null));
                }

                return false;
            }
        }
        #endregion
        #region setup To IoTHub
        private bool SetupToIoTHub(string sn, string psk)
        {
            try
            {
                if (MessageBoxEvent != null && TransForm != null)
                {
                    var text = TransForm("message_SetupToIoTHub_1");
                    var caption = TransForm("message_SetupToIoTHub_2");
                    MessageBoxEvent(this, new TrackerMessageBox(text, caption, ReceviedMessageBoxButtons.OK));
                }

                if (serialPort.IsOpen == false)
                {
                    serialPort.Open();
                }

                serialPort.WriteTimeout = 6000;
                serialPort.WriteLine("SN=" + sn);
                Thread.Sleep(2000);
                serialPort.WriteLine("PSK=" + psk);
                Thread.Sleep(500);
                return true;
            }
            catch (Exception ex)
            {
                if (MessageBoxEvent != null && TransForm != null)
                {
                    MessageBoxEvent(this, new TrackerMessageBox(TransForm("message_SetupToIoTHub_3"), "Message", ReceviedMessageBoxButtons.OK, ReceviedMessageBoxIcon.Error));
                }

                return false;
            }
        }
        #endregion

        #region Check that IoTHub is set successfully
        private bool CheckDeviceConfig(string sn, string psk)
        {
            serialPort.ReadTimeout = 9000;

            try
            {
                Thread.Sleep(2000);
                string cache = serialPort.ReadExisting();

                if (string.IsNullOrEmpty(cache))
                {
                    if (OutPutEvent != null && TransForm != null)
                    {
                        OutPutEvent(this, new TrackerReceiveData($"{splitText}{TransForm("message_SNAndPsk_failed_Timeout")}"));
                    }

                    if (MessageBoxEvent != null && TransForm != null)
                    {
                        MessageBoxEvent(this, new TrackerMessageBox($"\n\r {TransForm("message_SNAndPsk_failed_Timeout")}", "Message", ReceviedMessageBoxButtons.OK, ReceviedMessageBoxIcon.Error));
                    }

                    return false;
                }

                if (!cache.Contains(sn) || !cache.Contains(psk))
                {
                    if (OutPutEvent != null && TransForm != null)
                    {
                        OutPutEvent(this, new TrackerReceiveData($"{splitText}{TransForm("message_SNAndPsk_failed")} \n\r {cache}"));
                    }

                    if (MessageBoxEvent != null && TransForm != null)
                    {
                        MessageBoxEvent(this, new TrackerMessageBox($"\n\r {TransForm("message_SNAndPsk_failed")}", "Message", ReceviedMessageBoxButtons.OK, ReceviedMessageBoxIcon.Error));
                    }
                    return false;
                }
                else if (OutPutEvent != null)
                {
                    var show_Text = splitText +
                    $" SN={sn}\r" +
                    $" PSK={psk}\r";
                    OutPutEvent(this, new TrackerReceiveData(show_Text));
                }

            }
            catch (Exception e)
            {
                if (MessageBoxEvent != null && TransForm != null)
                {
                    MessageBoxEvent(this, new TrackerMessageBox(e.Message, "Message", ReceviedMessageBoxButtons.OK, ReceviedMessageBoxIcon.Error));
                }
                return false;
            }

            return true;
        }
        #endregion
    }
}
