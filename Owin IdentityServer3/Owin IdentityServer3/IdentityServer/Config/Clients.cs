using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer3.Core.Models;

namespace IdentityServer.Config
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
             {
                new Client
                {
                     ClientId = "https://op.certification.openid.net:60591/authz_cb",
                     ClientName = "Openid connect certification",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://op.certification.openid.net:60591/authz_cb"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                }
                ,
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/b2ccharm",
                     ClientName = "B2CCharm (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/b2ccharm.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp",
                        "https://te.cpim.localhost.net/b2ccharm.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                }
             };
        }
    }
}
