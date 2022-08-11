using System;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress; Database=test; Trusted_Connection=True; MultipleActiveResultSets=true;");
            /*
             dotnet commands: (set default projects as DataAccess on package manager console before migrations process)
                if migrations exist -->  delete migrations folder
                if database exist --> drop-database 
                add-migration initialCreate 
                update-database
                
             */
        }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasKey(x => x.MyProperty);
            /*
             .................
            */
        }
    }
}
