namespace ECOLAB.IOT.Transmit.SNAndPSKSend
{
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using ECOLAB.IOT.Service;
    using System;
    using System.IO.Ports;
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
        public void Send()
        {
            SendResultEvent(true, null);
            try
            {
                if (!SetSecret($"{sn}PSK", Utilities.RandomGenerateString(), out string psk))
                {
                    return;
                }

                if (!SetupToIoTHub(sn, psk))
                {
                    return;
                }

                if (!CheckDeviceConfig(sn, psk))
                {
                    if (OutPutEvent != null && TransForm != null)
                    {
                        OutPutEvent(this, new TrackerReceiveData($"\n\r {TransForm("message_CommonSendPattern_failed")}"));
                    }
                    return;
                }

                var result = RegisterDevice(sn,prefix).Result;
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
                    if (MessageBoxEvent != null && TransForm != null)
                    {
                        var caption = TransForm("message");
                        MessageBoxEvent(this, new TrackerMessageBox(result.Message, caption));
                    }
                }

                if (OutPutEvent != null && TransForm != null)
                {
                    OutPutEvent(this, new TrackerReceiveData($"\n\r {TransForm("message_CommonSendPattern_suceess1")}"));
                }
            }
            catch (Exception ex)
            {
                if (OutPutEvent != null && TransForm != null)
                {
                    OutPutEvent(this, new TrackerReceiveData($"\n\r {TransForm("message_Travel_failed")}"));
                }
            }
            finally
            {
                SendResultEvent(false, null);
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

                Thread.Sleep(3000);
                if (serialPort.IsOpen == false)
                {
                    serialPort.Open();
                }

                serialPort.WriteLine("SN=");
                Thread.Sleep(500);
                serialPort.WriteLine("PSK=");
                Thread.Sleep(500);
                //string cache = serialPort.ReadExisting();
                //Console.Write(cache);
                serialPort.WriteLine("SN=" + sn);
                Thread.Sleep(2000);
                serialPort.WriteLine("PSK=" + psk);
                Thread.Sleep(4000);
                return true;
            }
            catch (Exception ex)
            {
                if (MessageBoxEvent != null && TransForm != null)
                {
                    MessageBoxEvent(this, new TrackerMessageBox(ex.Message, "Message", ReceviedMessageBoxButtons.OKCancel, ReceviedMessageBoxIcon.Error));
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
                if (OutPutEvent != null)
                {
                    OutPutEvent(this, new TrackerReceiveData("======================================================================\r\n" +
                    $"{cache}\r\n\r\n "));
                }

                if (!cache.Contains(sn) || !cache.Contains(psk))
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                if (MessageBoxEvent != null && TransForm != null)
                {
                    MessageBoxEvent(this, new TrackerMessageBox(e.Message, "Message", ReceviedMessageBoxButtons.OKCancel, ReceviedMessageBoxIcon.Error));
                }
                return false;
            }

            return true;
        }
        #endregion
    }
}
