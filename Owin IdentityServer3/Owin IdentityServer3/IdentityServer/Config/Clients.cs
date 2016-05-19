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
                },


                // Add clients for B2C training
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/casamega.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/casamega.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/elmorro.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/elmorro.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/umami15.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/umami15.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/megatwo.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/megatwo.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/grupo7.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/grupo7.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/umami99.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/umami99.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/umami14.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/umami14.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/umami9.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/umami9.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/alphab2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/alphab2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/gammab2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/gammab2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/deltab2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/deltab2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/zetab2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/zetab2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/taub2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/taub2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/iotab2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/iotab2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/kappab2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/kappab2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/lambdab2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/lambdab2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/mub2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/mub2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/nub2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/nub2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/xib2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/xib2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/omicronb2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/omicronb2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/pib2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/pib2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/rhob2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/rhob2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/sigmab2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/sigmab2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/upsilonb2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/upsilonb2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/unifyb2cworkshop.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/unifyb2cworkshop.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/TestAADB2CDir.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/TestAADB2CDir.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/moogpartners.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/moogpartners.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/SteveOCG.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/SteveOCG.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/gregjab2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/gregjab2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/aceb2ctest.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/aceb2ctest.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/perseveranceprojectinc.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/perseveranceprojectinc.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/dmunnekeb2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/dmunnekeb2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/edgileb2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/edgileb2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/workstateconf.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/workstateconf.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/cocibolcab2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/cocibolcab2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/getmeeco.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/getmeeco.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/etacikb2c.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/etacikb2c.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
                    },           

                    // client secret
                    ClientSecrets = new List<Secret>()
                    {
                        new Secret("abcdef".Sha256())
                    }
                },
                new Client
                {
                     ClientId = "https://login.microsoftonline.com/te/MetaAwesome.onmicrosoft.com",
                     ClientName = "B2C Training (Authorization Code)",
                     Flow = Flows.AuthorizationCode,
                     AllowAccessToAllScopes = true,

                    // redirect = URI of the MVC application callback
                    RedirectUris = new List<string>
                    {
                        "https://login.microsoftonline.com/te/MetaAwesome.onmicrosoft.com/b2c_1a_base_extensions/oauth2/authresp"
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
