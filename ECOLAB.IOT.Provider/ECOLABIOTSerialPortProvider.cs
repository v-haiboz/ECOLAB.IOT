namespace ECOLAB.IOT.Provider
{
    using System.IO.Ports;

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
