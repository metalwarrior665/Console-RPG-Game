using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public class Armor : Item
    {
        public int Defense { get; set; }
        public int DexterityPenalty { get; set; }

        public Armor(string name, int defense, int dexterityPenalty, float weight, int price)
            : base (name, price, weight)
        {
            Name = name;
            Defense = defense; DexterityPenalty = dexterityPenalty; Price = price; Weight = weight;
        }
    }
}
