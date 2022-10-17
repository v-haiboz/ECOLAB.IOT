namespace ECOLAB.IOT.Common.Utilities
{
    using ECOLAB.IOT.Entity;
    using Newtonsoft.Json;
    using System;
    using System.Collections;
    using System.IO.Ports;
    using System.Runtime.InteropServices;

    public static class Extensions
    {
        public static int GetEnumValue<T>(this string enumName) where T : Enum
        {
            try
            {
                var enumType = typeof(T);
                var values = Enum.GetValues(enumType);
                var ht = new Hashtable();
                foreach (var val in values)
                {
                    ht.Add(Enum.GetName(enumType, val), val);
                }

                return (int)ht[enumName];
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static T ToEnum<T>(this string enumName) where T : Enum
        {
            if (string.IsNullOrEmpty(enumName))
            {
                throw new Exception($"{enumName} To Enum fail");
            }

            var type = (T)Enum.Parse(typeof(T), enumName);

            return type;
        }

        public static bool IsNull(this EnvironmentVariable environmentVariable)
        {
            if (environmentVariable == null
                 || environmentVariable.AppServiceOption == null
                 || string.IsNullOrEmpty(environmentVariable.FileName)
                 || string.IsNullOrEmpty(environmentVariable.Name))
            {
                return true;
            }

            return false;
        }

        public static string ToJson(this DeviceRegister deviceRegister)
        {
            if (deviceRegister == null)
                return string.Empty;

            var obj = new
            {
                DeviceAppId = $"{deviceRegister.DeviceType}-{deviceRegister.SerialNumber}",
                DeviceSerialNumber = deviceRegister.SerialNumber,
                IsEnabled = deviceRegister.IsEnabled,
                PlatformName = deviceRegister.PlatformName
            };
            return JsonConvert.SerializeObject(obj);
        }

        public static int SubStringCount(this string str, string subStr)
        {
            if (str.Contains(subStr))
            {
                var replaceStr = str.Replace(subStr, "");
                return (str.Length - replaceStr.Length) / subStr.Length;
            }

            return 0;
        }

        /// <summary>
        /// Get Device Type Prefix. // DMC|CON=DMC,COM=OPS
        /// </summary>
        /// <param name="appServiceOption"></param>
        /// <returns>Prefix</returns>
        public static string GetDeviceTypePrefix(this DeviceTypMapping deviceTypMapping, string sourcePrefix,bool isEnableValidate=true)
        {
            var dic = GetDeviceTypePrefixs(deviceTypMapping);
            if (isEnableValidate)
            {
                if (dic.TryGetValue(sourcePrefix, out string? targetPrefix))
                {
                    return targetPrefix;
                }
            }

            if (sourcePrefix == "DMC" || sourcePrefix == "CON")
            {
                sourcePrefix = "DMC";
            }

            return sourcePrefix;
        }

        private static IDictionary<string, string> GetDeviceTypePrefixs(DeviceTypMapping deviceTypMapping)
        {
            var dic = new Dictionary<string, string>();
            if (deviceTypMapping == null)
                return dic;

            foreach (var item in deviceTypMapping.List)
            {
                foreach (var child in item.SourceNameList)
                {
                    dic[child] = item.TargetName;
                }
            }

            return dic;
        }


       
        public static string ToStopBitName(this StopBits stopBits)
        {

            if (stopBits == StopBits.One)
            {
                return "1";
            }
            else if (stopBits == StopBits.OnePointFive)
            {
                return "1.5";
            }
            else if (stopBits == StopBits.Two)
            {
                return "2";
            }

            return null;
        }

        public static List<DeviceTypeMappingDisplay> ToDeviceTypeMappingDisplay(this DeviceTypMapping deviceTypMapping)
        {
            if (deviceTypMapping == null)
                return null;


            var list = new List<DeviceTypeMappingDisplay>();
            foreach (var item in deviceTypMapping.List)
            {
                var deviceTypeMappingDisplay = new DeviceTypeMappingDisplay();
                deviceTypeMappingDisplay.TargetPrefix = item.TargetName;
                deviceTypeMappingDisplay.SourcePrefixs = string.Join(";", item.SourceNameList);
                list.Add(deviceTypeMappingDisplay);
            }

            return list;
        }
    }
}
