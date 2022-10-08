

namespace ECOLAB.IOT.WinFormApp.FileTransmit
{
    using System;

    public enum YModemCheckMode { 
        CheckSum,
        CRC16
    }

    public enum YModemType
    { 
        YModem,
        YModem_1K
    }

    enum YModemMessageType : int { 
        KEY_C,
        ACK,
        NAK,
        EOT,
        PACKET,
        PACKET_ERROR,
        CAN
    }

    internal class YModemMessage 
    {
        private YModemMessageType _MessageType;
        private object _Value;

        internal YModemMessage(YModemMessageType type):this(type,null)
        { 
        }

        internal YModemMessage(YModemMessageType type, object value)
        {
            _MessageType = type;
            _Value = value;
        }

        internal YModemMessageType MessageType => _MessageType;
        internal object Value => _Value;
    }

    internal enum YModemSendStage : int { 
        WaitReceiveRequestFileInfo,
        WaitReceiveRequestFirstPacket,
        PacketSending,
        WaitReceiveAnswerEndTransmit,
        WaitReceiveNextFileReq,
    }

    internal enum YModemReceiveStage : int { 
        WaitForFileInfo,
        WaitForFirstPacket,
        PacketReceiving,
    }

    internal class YModemInfo {
        private YModemType _YModemType;
        private TransmitMode _TransMode;

        internal YModemInfo():this(YModemType.YModem, TransmitMode.Send)
        { 
        
        }
        internal YModemInfo(YModemType type, TransmitMode transMode) {
            _YModemType = type;
            _TransMode = transMode;
        }

        internal YModemType Type
        {
            get { return _YModemType; }
            set { _YModemType = value; }
        }
        internal TransmitMode TransMode
        {
            get { return _TransMode; }
            set { _TransMode = value; }
        }

    }

    internal class YModem : IFileTransmit, ITransmitUart
    {
        private readonly byte SOH = 0x01;
        private readonly byte STX = 0x02;
        private readonly byte EOT = 0x04;
        private readonly byte ACK = 0x06;
        private readonly byte NAK = 0x15;
        private readonly byte CAN = 0x18;
        private readonly byte KEY_C = 0x43;

        private int RetryMax = 6;

        YModemInfo ymodemInfo=new YModemInfo();

        private Thread TransThread;
        private bool IsStart = false;

        private int reTryCount;
        private ManualResetEvent waitReceiveEvent=new ManualResetEvent(false);
        private YModemReceiveStage ReceiveStage;
        private YModemSendStage SendStage;
        private Queue<YModemMessage> msgQueue = new Queue<YModemMessage>();

        internal YModem(TransmitMode transmit, YModemType ymodemType, int reTryCount)
        {
            RetryMax = reTryCount;

            ymodemInfo.Type = ymodemType;
            ymodemInfo.TransMode = transmit;

        }

        internal void Start()
        {
            //IsStart = true;
            //reTryCount = 0;

            //ReceiveStage = YModemReceiveStage.WaitForFileInfo;
            //SendStage = YModemSendStage.WaitReceiveRequestFileInfo;

            //TransThread = new Thread(new ThreadStart(TransThreadHandler));
            //TransThread.IsBackground = true;
            //TransThread.Name = "YModemTransThread";
            //TransThread.Start();

            //if (ymodemInfo.TransMode == TransmitMode.Receive) {
            //    if (StartReceive != null)
            //    {
            //        StartReceive(ymodemInfo,null);
            //    }
            //}

        }

        internal void Stop()
        {
            if (ymodemInfo.TransMode == TransmitMode.Receive)
            {
                Abort();
            }
            else {
                //SendEOT();
            }
        }

        internal void Abort()
        {
            IsStart = false;
            //SendCAN();

            if (EndOfTransmit != null)
            {
                EndOfTransmit(ymodemInfo,null);
            }
        }

        private void ParseReceiveMessage(byte[] data) {
            YModemMessage ReceivedMessage = null;

            if (data == null)
            {
                ReceivedMessage = null;
            }
            else { 
               //if()
            }
        }

        public event PacketEventHandler ReceivedPacket;
        public event EventHandler StartSend;
        public event EventHandler StartReceive;
        public event EventHandler SendNextPacket;
        public event EventHandler ReSendPacket;
        public event EventHandler AbortTransmit;
        public event EventHandler TransmitTimeOut;
        public event EventHandler EndOfTransmit;
        public event SendToUartEventHandler SendToUartEvent;

        public void ReceivedFromUart(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
