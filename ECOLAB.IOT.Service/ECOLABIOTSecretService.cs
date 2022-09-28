namespace ECOLAB.IOT.Service
{
    using Azure;
    using Azure.Security.KeyVault.Secrets;
    using Microsoft.Identity.Client;
    using Microsoft.IdentityModel.Clients.ActiveDirectory;
    using AuthenticationResult = Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationResult;
    using ClientCredential = Microsoft.IdentityModel.Clients.ActiveDirectory.ClientCredential;

    public interface IECOLABIOTSecretService
    {
        string GetSecret(string key);

        string SetSecret(string key, string value);

        string DeleteSecret(string key);

        bool ExistSecret(string key);
    }

    public class ECOLABIOTSecretService : IECOLABIOTSecretService
    {
        public string DeleteSecret(string key)
        {
            var secret = CallerContext.ECOLABIOTSecretClient.GetSecret(key);
            return secret.Value.Value;
        }

        public string GetSecret(string key)
        {
            try
            {
                var secret = CallerContext.ECOLABIOTSecretClient.GetSecret(key);
                return secret.Value.Value;
            }
            catch (RequestFailedException ex)
            {
                if (string.Compare(ex.ErrorCode, "SecretNotFound", StringComparison.OrdinalIgnoreCase) != -1)
                    return string.Empty;
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public string SetSecret(string key, string value)
        {
            try
            {
                var secret = CallerContext.ECOLABIOTSecretClient.SetSecret(key, value);
                return secret.Value.Value;
            }
            catch (RequestFailedException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool ExistSecret(string key)
        {
            var bl = false;
            var secrect=GetSecret(key);
            if (!string.IsNullOrEmpty(secrect))
            {
                bl = true;
            }

            return bl;
        }
    }
}
