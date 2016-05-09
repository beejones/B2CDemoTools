using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsProviderOwinAuth
{
    internal static class Constants
    {
        internal const string DefaultAuthenticationType = "ClaimsProvider";

        public static class ClaimTypes
        {
            public const string Email = "email";
            public const string Id = "id";
            public const string GivenName = "given_name";
            public const string FamilyName = "family_name";
            public const string Name = "name";
            public const string ObjectId = "objectId";
            public const string SurName = "surname";
            public const string Emails = "emails";
        }
    }
}
