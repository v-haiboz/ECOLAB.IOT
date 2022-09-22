namespace ECOLAB.IOT.Provider
{
    using System.IO.Ports;
    using System.Text;

    public interface IECOLABIOTSerialPortProvider
    {
        public string[] GetPortNames();

    }

    public class ECOLABIOTSerialPortProvider : IECOLABIOTSerialPortProvider
    {
        private SerialPort serialPort = new SerialPort();

        public string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }
    }
}
