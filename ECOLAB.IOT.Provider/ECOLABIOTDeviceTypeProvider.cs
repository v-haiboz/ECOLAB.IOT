namespace ECOLAB.IOT.Provider
{
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using Newtonsoft.Json;
    using System.Text;

    public interface IECOLABIOTDeviceTypeProvider
    {
        DeviceTypMapping GetDeviceTypeMapping();

        bool? AddOrUpdateDeviceTypeMapping(DeviceTypMapping deviceTypMapping);

    }
    public class ECOLABIOTDeviceTypeProvider : IECOLABIOTDeviceTypeProvider
    {
        public DeviceTypMapping GetDeviceTypeMapping()
        {
            return YamlDotNetExtesions.deserializer.Deserialize<DeviceTypMapping>(File.ReadAllText("Appsetting/devicetypemapping.yaml"));
        }

        public bool? AddOrUpdateDeviceTypeMapping(DeviceTypMapping deviceTypMapping)
        {
            if (deviceTypMapping ==null)
            {
                return false;
            }
            var deviceTypeMapping = YamlDotNetExtesions.serializer.Serialize(deviceTypMapping);
            File.WriteAllText("Appsetting/devicetypemapping.yaml", deviceTypeMapping, Encoding.UTF8);
            return true;
        }
    }
}
