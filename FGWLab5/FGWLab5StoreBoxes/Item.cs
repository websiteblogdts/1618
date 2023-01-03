using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab5StoreBoxes
{
    public class Item
    {
        private string name;
        private double price;
        public string Name { get; set; }
        public double Price { get; set; }
        public Item()
        {

        }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
