namespace ECOLAB.IOT.Provider
{
    using ECOLAB.IOT.Entity;
    using Newtonsoft.Json;
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Text;

    public interface IECOLABIOTRegisterDeviceProvider
    {
        public Task<bool> RegisterDevice(DeviceRegister deviceRegister, EnvironmentVariable environmentVariable);
    }

    public class ECOLABIOTRegisterDeviceProvider : IECOLABIOTRegisterDeviceProvider
    {
        public async Task<bool> RegisterDevice(DeviceRegister deviceRegister, EnvironmentVariable environmentVariable)
        {
            await Post(deviceRegister, environmentVariable);
            return true;
        }

        private async Task<bool> Post(DeviceRegister deviceRegister, EnvironmentVariable environmentVariable)
        {
            try
            {
                var httpClient = new HttpClient();
                var url = environmentVariable.AppServiceOption.DeviceRegisterUri;
                var response = await httpClient.PostAsync(url, new StringContent(
                                JsonConvert.SerializeObject(deviceRegister),
                                Encoding.UTF8,
                                "application/json")).ConfigureAwait(false);

                if (HttpStatusCode.OK== response.StatusCode)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
