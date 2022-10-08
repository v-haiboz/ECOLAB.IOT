namespace ECOLAB.IOT.WinFormApp.FileTransmit
{
    using System;

    internal delegate void SendToUartEventHandler(object sender, SendToUartEventArgs sendToUartEventArgs);
    internal interface ITransmitUart
    {
        event SendToUartEventHandler SendToUartEvent;
        void ReceivedFromUart(byte[] data);
    }

    public class SendToUartEventArgs : EventArgs
    {
        private readonly byte[] _Data;

        public SendToUartEventArgs(byte[] data)
        {
            _Data = data;
        }

        public byte[] Data => _Data;
    }
}
