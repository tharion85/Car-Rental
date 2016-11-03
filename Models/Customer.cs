﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace carRental.Models
{
    public class Customer
    {
       [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public string DrivingLicenseID { get; set; }

        public DateTime rentStart{ get; set; }
        public DateTime rentEnd { get; set; }

        public virtual Car Car { get; set; }
    }
}