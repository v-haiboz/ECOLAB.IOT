﻿namespace ECOLAB.IOT.Transmit
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ITransmitUart
    {
        public delegate void OutPutEventHandler(object sender, TrackerReceiveData e);
        public event OutPutEventHandler OutPutEvent;
        public delegate void MessageBoxEventHandler(object sender, TrackerMessageBox e);
        public event MessageBoxEventHandler MessageBoxEvent;
        public event EventHandler SendResultEvent;

        void Send();
        //void Stop();
        //void Abort();
    }
}