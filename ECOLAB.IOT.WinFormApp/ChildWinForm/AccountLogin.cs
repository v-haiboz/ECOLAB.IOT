using ECOLAB.IOT.Entity;
using ECOLAB.IOT.Service;
using Microsoft.Identity.Client;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class AccountLogin : Form
    {
        public AccountLogin(Frm_Login frm_Login)
        {
            InitializeComponent();
            Frm_Login = frm_Login;
        }
        private Frm_Login Frm_Login;
        private void button_DMPAccountLogin_Click(object sender, EventArgs e)
        {
            if (Frm_Login != null)
            {
                var dmpAccountLogin = new DMPAccountLogin(Frm_Login);
                Frm_Login.OpenChildForm(dmpAccountLogin, null);
            }
        }
        private static bool loggeIn = false;
        private static readonly string[] scopes = { "user.read" };
        private async void button_ECOLABAcountLogin_Click(object sender, EventArgs e)
        {
            if (!loggeIn)
            {
                var authResult = await Login();
                Frm_Login.Login(new SysAdmin()
                {
                    UserName = authResult.Account.Username,
                }, null);
                loggeIn = true;
            }
        }
       
        private async Task<AuthenticationResult> Login()
        {
            AuthenticationResult authResult = null;
            var accounts = await CallerContext.PublicClientApplication.GetAccountsAsync();
            var firstAccount = accounts.FirstOrDefault();

            try
            {
                authResult = await CallerContext.PublicClientApplication.AcquireTokenSilent(scopes, firstAccount)
                    .ExecuteAsync().ConfigureAwait(false);
            }
            catch (MsalUiRequiredException ex)
            {
                // A MsalUiRequiredException happened on AcquireTokenSilent.
                // This indicates you need to call AcquireTokenInteractive to acquire a token
                System.Diagnostics.Debug.WriteLine($"MsalUiRequiredException: {ex.Message}");

                try
                {
                    authResult = await CallerContext.PublicClientApplication.AcquireTokenInteractive(scopes)
                        .WithAccount(accounts.FirstOrDefault())
                        .WithPrompt(Prompt.SelectAccount)
                        .ExecuteAsync().ConfigureAwait(false);
                }
                catch (MsalException msalex)
                {
                    throw new Exception($"Error Acquiring Token:{System.Environment.NewLine}{msalex}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Acquiring Token Silently:{System.Environment.NewLine}{ex}");
            }

            return authResult;
        }
    }
}
