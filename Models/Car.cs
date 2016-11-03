using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace carRental.Models
{
    enum transmission { Autmotaic, Manual }
    public class Car
    {  
        [Key]
        public int Id { get; set; }

        public string Model { get; set; }
        public string Mark { get; set; }
        public int Year { get; set; }
        public Boolean hasAC { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public int rentalCost { get; set; }
        public byte[] carImage { get; set; }
        public enum Transmission { Automatic, Manual }
        public enum Type { Mini, Economy, Compact, Midsize, Standard, Premium, Luxury, SUV, Van, Other}
        public string Location { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID  { get; set; }

        public virtual Customer Customer { get; set; }


    }
}