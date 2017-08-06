using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public float Weight { get; set; }

        public Item (string name, int price, float weight)
        {
            Name = name; Price = price; Weight = weight;
        }
    }
}
