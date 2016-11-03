using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using carRental.Models;

namespace carRental.DAL
{
    public class CarInitializer : DropCreateDatabaseIfModelChanges<CarContext>
    {
       
        protected override void Seed(CarContext context)
        {
            var customers = new List<Customer>
            {
                new Customer { FirstName="Carson", LastName="Alexander", Address="183 Court Road", ZipCode="T7D 0C1", City="Toronto" },
                new Customer { FirstName="Meredith", LastName="Alonso", Address="101 Baseline Rd", ZipCode="V4D 0G2", City="Vancouver" },
                new Customer { FirstName="Arturo", LastName="Brand", Address="1043 34st", ZipCode="T5Z 3P1", City="Calgary" }
            };

            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();

            var cars = new List<Car>
            {
                new Car { Id=1033, Model="Corolla", Mark="Toyota", hasAC=true, rentalCost=65 }

            };
            cars.ForEach(ca => context.Cars.Add(ca));
            context.SaveChanges();
        }
    }
}