using B2CRestApi.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace B2CRestApi
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static string PublicClientId { get; private set; }

        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseBasicAuthentication("realm", ValidateClient);

            // Configure the db context and user manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseCookieAuthentication(new CookieAuthenticationOptions());
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);
            
        }

        private Task<IEnumerable<Claim>> ValidateClient(string clientId, string clientSecret)
        {
            if (string.Compare(clientId, Properties.Settings.Default.ClientId) == 0 &&
                string.Compare(clientSecret, Properties.Settings.Default.ClientSecret) == 0)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, clientId),
                    new Claim(ClaimTypes.Role, "client")
                };

                return Task.FromResult<IEnumerable<Claim>>(claims);
            }

            return Task.FromResult<IEnumerable<Claim>>(null);
        }
    }
}
