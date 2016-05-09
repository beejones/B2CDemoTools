using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B2CRestApi.Models
{
    public class EidModel
    {
        /// <summary>
        /// Gets or sets the National number of a citizen
        /// </summary>
        public string EidNumber { get; set; }

        /// <summary>
        /// Gets or sets the date of bird
        /// </summary>
        public DateTime Dob { get; set; }
    }
}