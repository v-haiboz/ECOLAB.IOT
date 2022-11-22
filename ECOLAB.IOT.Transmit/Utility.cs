
namespace ECOLAB.IOT.Transmit
{
    using ECOLAB.IOT.Service;
    using System.Text;

    public class Utility
    {
        static Utility()
        {
            if (!Directory.Exists("Log"))
            {
                Directory.CreateDirectory("Log");
            }
        }


        public static void Track(string messageInfo,bool isLogDateTime=false)
        {
            if (CallerContext.ECOLABIOTLogSettingService.GetLogSetting().Enable)
            {
                if (isLogDateTime)
                {
                    messageInfo = $"{messageInfo}->{DateTime.Now}";
                }

                File.AppendAllText(@"Log/track.txt", $"{messageInfo}" , Encoding.UTF8);
            }
        }
    }
}
