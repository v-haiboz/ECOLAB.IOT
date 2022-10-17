namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Entity;

    public interface IECOLABIOTDeviceTypeService
    {
        DeviceTypMapping GetDeviceTypeMapping();

        bool? AddOrUpdateDeviceTypeMapping(DeviceTypMapping deviceTypMapping);

    }

    public class ECOLABIOTDeviceTypeService : IECOLABIOTDeviceTypeService
    {
        public DeviceTypMapping GetDeviceTypeMapping()
        {
            return CallerContext.ECOLABIOTDeviceTypeProvider.GetDeviceTypeMapping();
        }

        public bool? AddOrUpdateDeviceTypeMapping(DeviceTypMapping deviceTypMapping)
        {
            if (deviceTypMapping == null)
            {
                return false;
            }

            return CallerContext.ECOLABIOTDeviceTypeProvider.AddOrUpdateDeviceTypeMapping(deviceTypMapping);
        }
    }
}
