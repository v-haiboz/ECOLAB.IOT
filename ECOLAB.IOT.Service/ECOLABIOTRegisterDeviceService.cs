namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Entity;

    public interface IECOLABIOTRegisterDeviceService
    {
        public Task<TData<string>> RegisterDevice(DeviceRegister deviceRegister);
    }
    public class ECOLABIOTRegisterDeviceService : IECOLABIOTRegisterDeviceService
    {
        public async Task<TData<string>> RegisterDevice(DeviceRegister deviceRegister)
        {
            var data = new TData<string>();
            try
            {
                var result = await CallerContext.ECOLABIOTRegisterDeviceProvider.RegisterDevice(deviceRegister, CallerContext.EnvironmentVariable).ConfigureAwait(false);
                data.Result = result;
            }
            catch (Exception ex)
            {
                data.Status = Status.Fail;
                data.Message = "Device registration failed, please check if the network is connected properly." + ex.Message;
            }

            return data;
        }
    }
}
