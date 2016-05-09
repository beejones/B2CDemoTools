using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IdentityServer3.Core.Configuration;
using IdentityServer.Config;
using Microsoft.Owin.Security.OpenIdConnect;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Owin.Security.Google;
using IdentityServer.Properties;
using IdentityServer3.Core;
using System.Security.Claims;
using Thinktecture.IdentityModel.Client;
using Microsoft.Owin.Security;

namespace IdentityServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        { 
            app.Map("/identity", idsrvApp =>
            {
                var idServerServiceFactory = new IdentityServerServiceFactory()
                                .UseInMemoryClients(Clients.Get())
                                .UseInMemoryScopes(Scopes.Get())
                                .UseInMemoryUsers(Users.Get());

                var options = new IdentityServerOptions
                {
                    Factory = idServerServiceFactory,
                    SiteName = Settings.Default.SiteName,
                    IssuerUri = "https://b2cauth.azurewebsites.net/identity",
                    PublicOrigin = "https://b2cauth.azurewebsites.net",
                    SigningCertificate = LoadCertificate(),
                    RequireSsl = false,
                    AuthenticationOptions = new IdentityServer3.Core.Configuration.AuthenticationOptions
                    {
                        IdentityProviders = ConfigureIdentityProviders,
                    },                     
                };

                idsrvApp.UseIdentityServer(options);
            });                      
        }

        public static void ConfigureIdentityProviders(IAppBuilder app, string signInAsType)
        {
            var oidc = new OpenIdConnectAuthenticationOptions
            {
                Notifications = new OpenIdConnectAuthenticationNotifications()
                {
                    RedirectToIdentityProvider = (context) =>
                    {
                        // The open id class can't deal with authorization uri which already contain '?'
                        // We need this work around to cover it in the request
                        var parts = context.ProtocolMessage.IssuerAddress.Split(new[] { '?' });
                        context.ProtocolMessage.IssuerAddress = parts[0];
                        if (parts.Length > 1)
                        {
                            context.ProtocolMessage.Parameters.Add("p", Settings.Default.B2CPolicy);
                        }

                        return Task.FromResult(0);
                    },
                    
                    SecurityTokenValidated = context =>
                    {
                        return Task.FromResult(0);
                    },
                },
                RedirectUri = Settings.Default.IdentityServerRedirectUri,
                Scope = "openid",
                ResponseType= "id_token",
                Caption = Settings.Default.B2CAuthProviderName,
                SignInAsAuthenticationType = signInAsType,
                ClientId = Settings.Default.B2CClientId,
                MetadataAddress = string.Format(Settings.Default.B2CMetadata, Settings.Default.B2CTenant, Settings.Default.B2CPolicy),             
                ClientSecret = @Settings.Default.B2CClientSecret
            };
            app.UseOpenIdConnectAuthentication(oidc);
        }

        X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2(
                string.Format(@"{0}\certificates\idsrv3test.pfx",
                AppDomain.CurrentDomain.BaseDirectory), "idsrv3test");
        }
    }
}
