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
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<SemestriIB230022> Semestri { get; set; }
        public DbSet<UlogaIB230022> Uloge { get; set; }
        public DbSet<StudentiUlogeIB230022> StudentiUloge { get; set; }
        public DbSet<StudentiPorukeIB230022> StudentiPoruke { get; set; }
        public DbSet<StudentiPredmetiIB230022> StudentiPredmeti { get; set; }
    }
}
