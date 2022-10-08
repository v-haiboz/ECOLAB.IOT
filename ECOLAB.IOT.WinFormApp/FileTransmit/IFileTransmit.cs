namespace ECOLAB.IOT.WinFormApp.FileTransmit
{
    using System;

    public enum TransmitMode
    {
        Receive,
        Send
    }

    internal delegate void PacketEventHandler(object sender, PacketEventArgs e);

    internal interface IFileTransmit:ITransmitUart
    {
        event PacketEventHandler ReceivedPacket;

        event EventHandler StartSend;
        event EventHandler StartReceive;
        event EventHandler SendNextPacket;
        event EventHandler ReSendPacket;
        event EventHandler AbortTransmit;
        event EventHandler TransmitTimeOut;
        event EventHandler EndOfTransmit;
    }

    internal class PacketEventArgs : EventArgs
    {
        private readonly int _PacketNo;
        private readonly int _PacketLen;
        private readonly byte[] _Packet;

        public PacketEventArgs(int packetNo, byte[] packet):this(packetNo,packet,packet.Length)
        {
            
        }

        public PacketEventArgs(int packetNo, byte[] packet, int packetLen)
        {
            _PacketNo = packetNo;

            if (packet != null)
            {
                if (packet.Length <= packetLen) { 
                 _PacketLen = packetLen;
                }

                _Packet =new byte[_PacketLen];
                Array.Copy(packet,0,_Packet,0,_PacketLen);
            }
        }

        public int PacketNo => _PacketNo;
        
        public byte[] Packet => _Packet;

        public int PacketLen => _PacketLen;

    }
}
