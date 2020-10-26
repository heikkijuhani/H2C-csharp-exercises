using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_098
{
    public class Product
    {
        double price;
        string name;
        int quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{name}: price {price}: {quantity} pcs");
        }

    }
}
