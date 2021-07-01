using CRUD_In_Dotnet_Core_WebApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_In_Dotnet_Core_WebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblColdDrinks>()
                .HasKey(c => new { c.intColdDrinksId });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<tblColdDrinks> tblColdDrinks { get; set; }

    }
}
