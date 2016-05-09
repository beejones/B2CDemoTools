using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsProviderOwinAuth
{
    public static class ClaimsProviderAuthenticationExtensions
    {
        public static IAppBuilder UseClaimsProviderAuthentication(this IAppBuilder app, ClaimsProviderAuthenticationOptions options)
        {
            return app.Use(typeof(ClaimsProviderAuthenticationMiddleware), app, options);
        }
    }
}
