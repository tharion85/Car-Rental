using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using carRental.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace carRental.DAL

{
    public class CarContext : DbContext
    {
        public CarContext() : base("CarContext")
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Car>()
                .HasOptional(s => s.Customer)
                .WithRequired(ad => ad.Car);
        }

    }
}