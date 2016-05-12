using CarPool.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Carpool.DAL
{
    public class CarpoolContext : DbContext
    {

        public CarpoolContext() : base("CarpoolContext")
        {
        }

        DbSet<Student> Students { get; set; }
        DbSet<Driver> Schools { get; set; }
        DbSet<School> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}