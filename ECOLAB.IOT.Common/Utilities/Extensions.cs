namespace ECOLAB.IOT.Common.Utilities
{
    using ECOLAB.IOT.Entity;
    using Newtonsoft.Json;
    using System;
    using System.Collections;

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
        public static string GetDeviceTypePrefix(this AppServiceOption appServiceOption, string sourcePrefix)
        {
            var dic = GetDeviceTypePrefixs(appServiceOption);

            if (dic.TryGetValue(sourcePrefix, out string? targetPrefix))
            {
                return targetPrefix;
            }

            if (sourcePrefix == "DMC" || sourcePrefix == "CON")
            {
                sourcePrefix = "DMC";
            }

            return sourcePrefix;
        }

        private static IDictionary<string, string> GetDeviceTypePrefixs(AppServiceOption appServiceOption)
        {
            var dic = new Dictionary<string, string>();
            if (appServiceOption == null || string.IsNullOrEmpty(appServiceOption.DeviceType))
                return dic;

            var list = appServiceOption.DeviceType.Split(',');
            if (list.Count() == 0)
            {
                return dic;
            }

            foreach (var item in list)
            {
                if (item.SubStringCount("=") == 1)
                {
                    var keyValue = item.Split("=");
                    if (keyValue.Length == 2)
                    {
                        var keys = keyValue[0];
                        var value = keyValue[1];
                        if (!string.IsNullOrEmpty(keys) && !string.IsNullOrEmpty(value))
                        {
                            foreach (var key in keys.Split("|"))
                            {
                                dic.Add(key, value);
                            }
                        }
                    }
                }
            }

            return dic;
        }
    }
}
