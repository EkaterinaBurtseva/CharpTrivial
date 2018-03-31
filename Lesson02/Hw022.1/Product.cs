using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw022._1
{
    class Product
    {
        private string name;
        private double price;


        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            string k = string.Format("{0:C}", price);
            return "Product: " + name + " " + k;
        }
    }
}
