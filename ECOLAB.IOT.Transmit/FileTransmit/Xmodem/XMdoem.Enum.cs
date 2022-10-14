namespace ECOLAB.IOT.Transmit.FileTransmit.Xmodem
{
    using System;
    using System.IO.Ports;
    using System.Runtime.Intrinsics.Arm;

    public enum XModemMessageType : byte
    {
        SOH = 0x01,
        SOX = 0x02,
        EOT = 0x04,
        ETB = 0x17,
        ACK = 0x06,
        NAK = 0x15,
        CAN = 0x18
    }
}
