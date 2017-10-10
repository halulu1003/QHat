using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QHat.Models
{
    public enum Status {
        untreated,intransit,deliver
    }
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public Status? Status { get; set; }
        public double Subtotal { get; set; }
        public double GST { get; set; }
        public double Grandtotal { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Orderitem> Orderitems { get; set; }
    }
}
