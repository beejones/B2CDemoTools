using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B2CAppMvc.Models
{
    public class ClientClaims
    {
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string Policy { get; set; }
    }
}