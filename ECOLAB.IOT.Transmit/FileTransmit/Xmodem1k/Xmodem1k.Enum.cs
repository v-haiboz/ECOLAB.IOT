﻿namespace ECOLAB.IOT.Transmit.FileTransmit
{
    using System;
    using System.IO.Ports;
    using System.Runtime.Intrinsics.Arm;

    public enum XModem1KMessageType : byte
    {
        SOH = 0x01,
        SOX = 0x02,
        EOT = 0x04,
        ETB = 0x17,
        ACK = 0x06,
        NAK = 0x15,
        CAN = 0x18,
        CTRLZ = 0x1A
    }
}
