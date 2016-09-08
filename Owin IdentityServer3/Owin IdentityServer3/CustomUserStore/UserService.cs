using System.Linq;
using System.Threading.Tasks;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services.Default;

namespace CustomUserStore
{
        public class UserService : UserServiceBase
        {
            public override Task AuthenticateExternalAsync(ExternalAuthenticationContext context)
            {
                var externalAuth = context.ExternalIdentity;
                var auth = new AuthenticateResult(externalAuth.ProviderId, "ronny", externalAuth.Claims, externalAuth.Provider);
                context.AuthenticateResult = auth;
                return Task.FromResult(0);
            }
        }
}
