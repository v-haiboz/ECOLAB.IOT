namespace ECOLAB.IOT.Provider
{
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using System;
    using System.Net;
    using System.Net.Http;

    public interface IECOLABIOTRegisterDeviceProvider
    {
        public Task<string> RegisterDevice(DeviceRegister deviceRegister, EnvironmentVariable environmentVariable);
    }

    public class ECOLABIOTRegisterDeviceProvider : IECOLABIOTRegisterDeviceProvider
    {
        private static HttpClient _httpClient;
        static ECOLABIOTRegisterDeviceProvider()
        {
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };

            _httpClient = new HttpClient(handler);
        }

        public async Task<string> RegisterDevice(DeviceRegister deviceRegister, EnvironmentVariable environmentVariable)
        {
            return await Post(deviceRegister, environmentVariable);
        }

        private async Task<string> Post(DeviceRegister deviceRegister, EnvironmentVariable environmentVariable)
        {

            var url = environmentVariable.AppServiceOption.DeviceRegisterUrl;
            using (var content = new StringContent(deviceRegister.ToJson(), System.Text.Encoding.UTF8, "application/json"))
            {
                HttpResponseMessage result = await _httpClient.PostAsync(url, content);
                string returnValue = await result.Content.ReadAsStringAsync();
                if (result.StatusCode == HttpStatusCode.OK)
                    return returnValue;
                throw new Exception($"RegisterDevice=false: ({result.StatusCode}): {returnValue}");
            }
        }
    }
}
