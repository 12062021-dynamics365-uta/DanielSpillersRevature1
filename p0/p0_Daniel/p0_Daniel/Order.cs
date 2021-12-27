using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p0_Daniel
{
    public class Order
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public Order() { }
    }

}
