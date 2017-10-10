using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QHat.Models
{
    public class Orderitem
    {
        public int OrderitemID { get; set; }
        public int HatID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<Hat> Hat { get; set; }
        public virtual Order Order { get; set; }
    }
}
