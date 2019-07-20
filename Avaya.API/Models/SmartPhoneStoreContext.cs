using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Avaya.API.Models
{
    public partial class SmartPhoneStoreContext : DbContext
    {
        public SmartPhoneStoreContext()
        {
        }

        public SmartPhoneStoreContext(DbContextOptions<SmartPhoneStoreContext> options)
            : base(options)
        {
        }

        // Unable to generate entity type for table 'dbo.Users'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Roles'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserRoles'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Brands'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cart'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CartStatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SellHistory'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=SmartPhoneStore;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");
        }
    }
}
