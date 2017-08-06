using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public class Food : Item
    {
        public int Calories { get; set; }
        public Food(string name,int calories, int price, float weight) : base(name, price, weight)
        {
            Name = name; Price = price; Weight = weight;
            Calories = calories;
        }
    }
}
