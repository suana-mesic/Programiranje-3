using DLWMS.Data;
using DLWMS.Data.IB230022;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace DLWMS.Infrastructure
{
    public class DLWMSContext : DbContext
    {
      
        private string konekcijskiString = ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(konekcijskiString);
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmet { get; set; }
        public DbSet<ProstorijeIB230022> Prostorije { get; set; }
        public DbSet<NastavaIB230022> Nastava { get; set; }
        public DbSet<PrisustvoIB230022> Prisustvo { get; set; }
    }
}
