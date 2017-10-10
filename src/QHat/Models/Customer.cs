using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QHat.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [StringLength(10, ErrorMessage = "no longer than 10 characters.")]
        public string Name { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Home { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Work { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
