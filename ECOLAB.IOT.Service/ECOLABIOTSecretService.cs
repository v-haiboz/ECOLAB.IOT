namespace ECOLAB.IOT.Service
{
    using Azure.Security.KeyVault.Secrets;

    public interface IECOLABIOTSecretService
    {
        string GetSecret(string key);

        string SetSecret(string key, string value);

        string DeleteSecret(string key);
    }

    public class ECOLABIOTSecretService: IECOLABIOTSecretService
    {
        public string DeleteSecret(string key)
        {
            var secret =  CallerContext.ECOLABIOTSecretClient.GetSecret(key);
            return secret.Value.Value;
        }

        public string GetSecret(string key)
        {
            var secret =  CallerContext.ECOLABIOTSecretClient.GetSecret(key);
            return secret.Value.Value;
        }

        public string SetSecret(string key, string value)
        {
            var secret = CallerContext.ECOLABIOTSecretClient.SetSecret(key, value);
            return secret.Value.Value;
        }
    }
}
