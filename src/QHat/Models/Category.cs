using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QHat.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [StringLength(10, ErrorMessage = "no longer than 10 characters.")]
        public string Name { get; set; }
    }
}
