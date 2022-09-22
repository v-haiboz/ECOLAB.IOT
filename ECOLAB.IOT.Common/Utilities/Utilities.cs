namespace ECOLAB.IOT.Common.Utilities
{
    public class Utilities
    {
        private static List<string> strings = new List<string>(){
        "DMC","CON","INT","CWT"
       };
        public static bool ValidateSN(string serial_num, out string message)
        {
            //return Regex.IsMatch(serial_num, @"^(DMC|CON|INT|CWT)[1-9]\d{8}$");
            if (string.IsNullOrEmpty(serial_num) || serial_num.Length != 12)
            {
                message = "SN length should be 12.";
                return false;
            }

            var temp = serial_num.Substring(0, 3);

            if (!strings.Any(item => string.Compare(item, temp) != -1))
            {
                message = "{1-3} should be one of them(DMC|CON|INT|CWT).";
                return false;
            }
            serial_num = serial_num.Substring(3);
            temp = serial_num.Substring(0, 2);
            if (!int.TryParse(temp, out _))
            {
                message = "{4-5} should be a number";
                return false;
            }
            serial_num = serial_num.Substring(2);
            temp = serial_num.Substring(0, 2);
            if (!int.TryParse(temp, out int month) || month>12)
            {
                message = "{6-7} should be a number,it should be less than or equal to 12";
                return false;
            }
            serial_num = serial_num.Substring(2);
            temp = serial_num.Substring(0, 2);
            if (!int.TryParse(temp, out int day))
            {
                message = "{8-9} should be a number";
                return false;
            }

            if (month == 02 && day > 29)
            {
                message = "If {6-7} is 02,{8-9} it should be less than or equal to 29.";
                return false;
            }

            if ((month == 04
               || month == 06
               || month == 09
               || month == 11) && day > 30)
            {
                message = "If {6-7} it is a leap month,{8-9} should be less than or equal to 31.";
                return false;
            }

            if ((month == 01
                || month == 03
                || month == 05
                || month == 07
                || month == 08
                || month == 10
                || month == 12) && day > 31)
            {
                message = "If {6-7} it is a non-leap month,{8-9} should be less than or equal to 30.";
                return false;
            }

            serial_num = serial_num.Substring(2);
            if (!int.TryParse(serial_num, out _))
            {
                message = "{10-12} should be a number";
                return false;
            }
            message = "";
            return true;
        }
    }
}
