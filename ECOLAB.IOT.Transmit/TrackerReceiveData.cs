namespace ECOLAB.IOT.Transmit
{
    using System;
    using System.Text;

    public class TrackerReceiveData : EventArgs
    {
        private string receiveMessage;
        private TrackerType trackerType;
        private readonly DateTime receiveTime;
        private readonly int dataLen;
        private readonly bool transform = false;
        private readonly bool isWriteLine = true;
        private readonly string receiveMessageRelease = "";

        public TrackerReceiveData(string receiveMessage, bool transform = false, bool isWriteLine=true, string receiveMessageRelease = "")
        {
            this.receiveMessage = receiveMessage;
            dataLen = receiveMessage.Length;
            receiveTime = DateTime.Now;
            this.transform = transform;
            this.isWriteLine = isWriteLine;
            this.receiveMessageRelease = receiveMessageRelease;
        }

        public TrackerReceiveData(byte[] receiveData, bool transform = false)
        {
            var sb = new StringBuilder();
            foreach (var b in receiveData)
            {
                sb.AppendLine($"{Convert.ToInt32(b)}");
            }

            receiveMessage = sb.ToString();
            dataLen = receiveMessage.Length;
            receiveTime = DateTime.Now;
            this.transform = transform;
        }

        public bool IsWriteLine
        {
            get { return isWriteLine; }
        }
        public bool TransForm
        {
            get { return transform; }
        }

        public string ReceiveMessageRelease
        {
            get { return receiveMessageRelease; }
        }

        public string ReceiveMessage
        {
            get
            {
                return receiveMessage;
            }
            set
            {
                receiveMessage = value;
            }
        }

        public int DataLen
        {
            get
            {
                return dataLen;
            }
        }

        public DateTime ReceiveTime
        {
            get { return DateTime.Now; }
        }

        public TrackerType TrackerType
        {
            get { return trackerType; }
        }

        public string TimeString
        {
            get
            {
                return $"{receiveTime.ToString("yyyy-MM-dd HH:mm:ss")}.{receiveTime.Millisecond}";
            }
        }

    }
    public enum TrackerType
    {
        YModem,
        XModem,
    }
}
