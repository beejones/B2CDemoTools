using System;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNet.Identity;

namespace B2CAppMvc
{
    public static class IdentityExtensions
    {
        public static string GetAuthenticationClassReference(this IIdentity identity)
        {
            return GetClaimValue(identity, "http://schemas.microsoft.com/claims/authnclassreference");
        }

        public static string GetDisplayName(this IIdentity identity)
        {
            return GetClaimValue(identity, "name");
        }

        public static string GetEmailAddress(this IIdentity identity)
        {
            return GetClaimValue(identity, "emails");
        }

        public static string GetGamerTag(this IIdentity identity)
        {
            return GetClaimValue(identity, "extension_GamerTag");
        }

        public static string GetGamerZone(this IIdentity identity)
        {
            return GetClaimValue(identity, "extension_GamerZone");
        }

        public static string GetGivenName(this IIdentity identity)
        {
            return GetClaimValue(identity, ClaimTypes.GivenName);
        }

        public static string GetLoyaltyNumber(this IIdentity identity)
        {
            return GetClaimValue(identity, "Loyalty");
        }

        public static string GetSurname(this IIdentity identity)
        {
            return GetClaimValue(identity, ClaimTypes.Surname);
        }

        private static string GetClaimValue(IIdentity identity, string claimType)
        {
            if (identity == null)
            {
                throw new ArgumentNullException(nameof(identity));
            }

            var claimsIdentity = identity as ClaimsIdentity;
            return claimsIdentity?.FindFirstValue(claimType);
        }
    }
}
