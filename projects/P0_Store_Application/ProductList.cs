using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0_Store_Application
{

    public class Inventory
    {
        ProductList product1;
        ProductList product2;
        ProductList product3;
        ProductList product4;
        ProductList product5;
        ProductList product6;
        ProductList product7;
        ProductList product8;
        ProductList product9;
        ProductList product10;

        public Inventory()
        {
            product1 = new ProductList()
            {
                stockUnit = 001,
                productName = "X-Box Series X Controller",
                price = 49.99
            };
            product2 = new ProductList()
            {
                stockUnit = 002,
                productName = "Playstation 5 Headset",
                price = 49.99
            };
            product3 = new ProductList()
            {
                stockUnit = 003,
                productName = "Blue Yeti USB Mic",
                price = 99.99
            };
            product4 = new ProductList()
            {
                stockUnit = 004,
                productName = "NBA 2K22 75th Anniversary",
                price = 99.99
            };
            product5 = new ProductList()
            {
                stockUnit = 005,
                productName = "Hardwood Classics Knicks Jersey",
                price = 129.99
            };
            product6 = new ProductList()
            {
                stockUnit = 006,
                productName = "Air Jordan Retro 12- Flu Game",
                price = 399.99
            };
            product7 = new ProductList()
            {
                stockUnit = 007,
                productName = "Apple Watch Series 6",
                price = 379.99
            };
            product8 = new ProductList()
            {
                stockUnit = 008,
                productName = "brilliant diamond and pearl double pack",
                price = 119.99
            };
            product9 = new ProductList()
            {
                stockUnit = 009,
                productName = "Rare Pokemon Shiny Mewtwo Trading Card",
                price = 74.98
            };
            product10 = new ProductList()
            {
                stockUnit = 010,
                productName = "Nintendo Switch OLED",
                price = 349.99
            };
        }

        public void ListInventory()
        {
            List<ProductList> products = new List<ProductList>();

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);
            products.Add(product6);
            products.Add(product7);
            products.Add(product8);
            products.Add(product9);
            products.Add(product10);

            foreach (var product in products)
            {
                Console.WriteLine
                    ($"{product.stockUnit}: {product.productName} - ${product.price}");
            }
        }

        public void ListOrder(int validInventoryItem)
        {
            List<ProductList> orderList = new List<ProductList>();

            if(validInventoryItem == 1)
            {
                orderList.Add(product1);
            }
            if (validInventoryItem == 2)
            {
                orderList.Add(product2);
            }
            if (validInventoryItem == 3)
            {
                orderList.Add(product3);
            }
            if (validInventoryItem == 4)
            {
                orderList.Add(product4);
            }
            if (validInventoryItem == 5)
            {
                orderList.Add(product5);
            }
            if (validInventoryItem == 6)
            {
                orderList.Add(product6);
            }
            if (validInventoryItem == 7)
            {
                orderList.Add(product7);
            }
            if (validInventoryItem == 8)
            {
                orderList.Add(product8);
            }
            if (validInventoryItem == 9)
            {
                orderList.Add(product9);
            }
            if (validInventoryItem == 10)
            {
                orderList.Add(product10);
            }
        }

    }

    public class ProductList
    {
        public int stockUnit { get; set; }
        public string productName { get; set; }
        public double price { get; set; }
    }
}
