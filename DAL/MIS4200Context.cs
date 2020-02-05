using System;
using System.Collections.Generic;
using System.Data.Entity;
using ar259015MIS4200.Models;
using System.Linq;
using System.Web;

namespace ar259015MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context }
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, ar259015MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<customer> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<PetDetails> PetDetails { get; set; }

        // add this method it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}