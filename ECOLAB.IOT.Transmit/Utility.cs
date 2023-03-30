
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
            var fileNameSuffix= DateTime.Now.ToString("yyyy-MM-dd");
            if (CallerContext.ECOLABIOTLogSettingService.GetLogSetting().Enable)
            {
                if (isLogDateTime)
                {
                    messageInfo = $"{DateTime.Now}->{messageInfo}";
                }

                File.AppendAllText(@$"Log/track_{fileNameSuffix}.txt", $"{messageInfo}" , Encoding.UTF8);
            }
        }
    }
}
