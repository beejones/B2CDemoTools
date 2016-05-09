using Microsoft.Owin.Infrastructure;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsProviderOwinAuth
{
    // Created by the factory in the ClaimsProviderAuthenticationMiddleware class.
    class ClaimsProviderAuthenticationHandler : AuthenticationHandler<ClaimsProviderAuthenticationOptions>
    {
        protected override Task<AuthenticationTicket> AuthenticateCoreAsync()
        {
            // ASP.Net Identity requires the NameIdentitifer field to be set or it won't  
            // accept the external login (AuthenticationManagerExtensions.GetExternalLoginInfo)
            var identity = new ClaimsIdentity(Options.SignInAsAuthenticationType);
            // It is mandatory to add the NameIdentifier claim
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, "11111", null, Options.AuthenticationType));
            identity.AddClaim(new Claim(Constants.ClaimTypes.Id, "dc3152ae-7834-451c-b8a2-8b8f0e21fcdf", null, Options.AuthenticationType));
            identity.AddClaim(new Claim(Constants.ClaimTypes.Name, "Ronny Bjones"));
            identity.AddClaim(new Claim(Constants.ClaimTypes.GivenName, "Ronny"));
            identity.AddClaim(new Claim(Constants.ClaimTypes.FamilyName, "Bjones"));
            identity.AddClaim(new Claim(Constants.ClaimTypes.Email, "Ronny.Bjones@hotmail.com"));

            var properties = Options.StateDataFormat.Unprotect(Request.Query["state"]);

            return Task.FromResult(new AuthenticationTicket(identity, properties));
        }

        
        protected override Task ApplyResponseChallengeAsync()
        {
            if (Response.StatusCode == 401)
            {
                var challenge = Helper.LookupChallenge(Options.AuthenticationType, Options.AuthenticationMode);

                // Only react to 401 if there is an authentication challenge for the authentication 
                // type of this handler.
                if (challenge != null)
                {
                    var state = challenge.Properties;

                    if (string.IsNullOrEmpty(state.RedirectUri))
                    {
                        state.RedirectUri = Request.Uri.ToString();
                    }

                    var stateString = Options.StateDataFormat.Protect(state);
                    string uri = WebUtilities.AddQueryString("/identity" + Options.CallbackPath.Value, "state", stateString);
                    Response.Redirect(uri);
                }
            }

            return Task.FromResult<object>(null);
        }

        public override async Task<bool> InvokeAsync()
        {
            // This is always invoked on each request. For passive middleware, only do anything if this is
            // for our callback path when the user is redirected back from the authentication provider.
            Debug.WriteLine("Owin path: " + Request.Path);
            if (Options.CallbackPath.HasValue && Options.CallbackPath == Request.Path) // string.Compare("/external", Request.Path.ToString(), true) == 0)
            {
                var ticket = await AuthenticateAsync();

                if (ticket != null)
                {
                    Context.Authentication.SignIn(ticket.Properties, ticket.Identity);

                    Response.Redirect(ticket.Properties.RedirectUri);

                    // Prevent further processing by the owin pipeline.
                    return true;
                }
            }
            // Let the rest of the pipeline run.
            return false;
        }

    }
}
