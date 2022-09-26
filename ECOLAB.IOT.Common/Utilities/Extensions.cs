namespace ECOLAB.IOT.Common.Utilities
{
    using ECOLAB.IOT.Entity;
    using Newtonsoft.Json;
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;

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
                DeviceAppId = $"{deviceRegister.DeviceType}{deviceRegister.SerialNumber}",
                DeviceSerialNumber = deviceRegister.SerialNumber,
                IsEnabled = deviceRegister.IsEnabled,
                PlatformName = deviceRegister.PlatformName
            };
            return JsonConvert.SerializeObject(obj);
        }
    }
}
