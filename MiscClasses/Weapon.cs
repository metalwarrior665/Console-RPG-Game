using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public int Accuracy { get; set; }
        public float Speed { get; set; }
        public string Type { get; set; }
        public bool IsTwoHanded { get; set; }


        public Weapon(string name, int damage, int accuracy, float speed, string type, bool isTwoHanded, float weight, int price)
             : base(name, price, weight)
        {
            Name = name;
            Damage = damage; Accuracy = accuracy; Speed = speed; Type = type; IsTwoHanded = isTwoHanded;
            Price = price; Weight = weight;
        }
    }
}
