namespace ECOLAB.IOT.Transmit
{
    using System;

    public interface IFileTransmit 
    {
        public delegate void OutPutEventHandler(object sender, TrackerReceiveData e);
        public event OutPutEventHandler OutPutEvent;
        public delegate void MessageBoxEventHandler(object sender, TrackerMessageBox e);
        public event MessageBoxEventHandler MessageBoxEvent;
        public event EventHandler SendResultEvent;
        public delegate string Transforer(string strkey);
        public event Transforer OutTransforer;

        public void Send();
    }

}
