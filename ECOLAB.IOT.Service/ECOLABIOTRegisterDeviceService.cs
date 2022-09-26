namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Entity;

    public interface IECOLABIOTRegisterDeviceService
    {
        public Task<bool> RegisterDevice(DeviceRegister deviceRegister);
    }
    public class ECOLABIOTRegisterDeviceService : IECOLABIOTRegisterDeviceService
    {
        public async Task<bool> RegisterDevice(DeviceRegister deviceRegister)
        {
            return await CallerContext.ECOLABIOTRegisterDeviceProvider.RegisterDevice(deviceRegister, CallerContext.EnvironmentVariable);
        }
    }
}
