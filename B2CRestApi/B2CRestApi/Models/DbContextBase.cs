using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace B2CRestApi.Models
{
    public class DbContextBase : DbContext
    {
        /// <summary>
        /// Gets or sets the loyalty database
        /// </summary>
        public DbSet<LoyaltyModel> Users { get; set; }

        /// <summary>
        /// Gets or sets the national id database
        /// </summary>
        public DbSet<EidModel> Citizens { get; set; }
    }
}