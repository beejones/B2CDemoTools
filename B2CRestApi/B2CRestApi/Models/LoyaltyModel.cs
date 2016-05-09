using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B2CRestApi.Models
{
    public class LoyaltyModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string LoyaltyNumber { get; set; }
    }
}