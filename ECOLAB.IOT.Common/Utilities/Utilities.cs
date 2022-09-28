using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace ECOLAB.IOT.Common.Utilities
{
    public class Utilities
    {
        private static List<string> strings = new List<string>(){
        "DMC","CON","INT","CWT"
       };

        private const string hex_reg = @"[0-9a-fA-F]";
        private const string stringOrNumber = @"^[a-zA-Z0-9]*$";  
        private const string url = @"^(https?|ftp|file|ws)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";

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

        /// <summary>
        /// Verify if it is a URL link
        /// </summary>
        /// <param name="str">Specify string</param>
        /// <returns></returns>
        public static bool IsURL(string str)
        {
            return IsMatch(url, str);
        }

        /// <summary>
        /// Verify if it is a URL link
        /// </summary>
        /// <param name="str">Specify string</param>
        /// <returns></returns>
        public static bool IsStringOrNumber(string str)
        {
            return IsMatch(stringOrNumber, str);
        }

        /// <summary>
        /// Verify if it is a GUID      
        /// </summary>
        /// <param name="str">Specify string</param>
        /// <returns></returns>
        public static bool IsGUID(string str)
        {
            string pattern = @"^(" + hex_reg + "{8}(-" + hex_reg + "{4}){3}-" + hex_reg + "{12})?$";
            return IsMatch(pattern, str);
        }

        /// <summary>
        /// Judge whether a string matches the specified expression (case sensitive).
        /// </summary>
        /// <param name="expression">regular expression</param>
        /// <param name="str">String to match</param>
        /// <returns></returns>
        private static bool IsMatch(string expression, string str)
        {
            Regex reg = new Regex(expression);
            if (string.IsNullOrEmpty(str))
                return false;
            return reg.IsMatch(str);
        }

        public static string RandomGenerateString(int length = 32)
        {
            var randomBytes = RandomNumberGenerator.GetBytes(length);
            var strBuilder = new StringBuilder();
            foreach(var randomByt in randomBytes)
                {
                strBuilder.Append(randomByt.ToString("X2"));
            }

            return strBuilder.ToString();
        }
    }
}
