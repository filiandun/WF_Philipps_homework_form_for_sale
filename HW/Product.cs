using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Product
    {
        private string name;
        private string description;
        private double price;

        public Product()
        {
            this.name = "unknow";
            this.description = "unknow";
            this.price = 0;
        }

        public Product(string name, string description, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price > 0 ? price : 0;
        }

        public string Name { get => this.name; }
        public string Description { get => this.description; }
        public double Price { get => this.price; }

        public override string ToString()
        {
            return $"{this.Name} ({this.description})";
        }
    }
}
