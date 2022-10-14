namespace ECOLAB.IOT.Transmit.FileTransmit
{
    using System;
    public enum YModemCheckMode
    {
        CheckSum,
        CRC16
    }

    public enum YModemType
    {
        YModem,
        //YModem_1K
    }

    public enum YModemMessageType : byte
    {
        STX = 2,// Start of TeXt 
        EOT = 4,// End Of Transmission
        ACK = 6, // Positive ACknowledgement
        KEY_C = 67,// capital letter C
    }

    public enum InitialCrcValue
    {
        Zeros,
        NonZero1 = 0xffff,
        NonZero2 = 0x1D0F
    }
}
