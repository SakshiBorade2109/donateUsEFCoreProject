using Microsoft.EntityFrameworkCore;

namespace DonateUsEfCore2.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LanguageLocalization>().HasData(
                new LanguageLocalization()
                {
                    id = 1278,
                    language = "en"
                }
               ,
               new LanguageLocalization()
               {
                   id = 78456,
                   language = "hindi"
               }
               );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Donation> Donations { get; set; }

        public DbSet<DonationArea> DonationsArea { get; set;}

        public DbSet<Charity> Charities { get; set; }

        public DbSet<LanguageLocalization> Languages { get; set; }
    }
}
