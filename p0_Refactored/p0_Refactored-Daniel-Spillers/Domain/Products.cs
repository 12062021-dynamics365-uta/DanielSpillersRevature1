using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Products
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public double price { get; set; }

        public Products() { }

        public Products( int productId, string productName, string description, double price)
        {
            this.productId = productId;
             this.productName = productName;
            this.description = description;
            this.price = price;
        }
    }
}
