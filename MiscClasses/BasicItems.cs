using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public class BasicItems
    {
       public List<Item> CreateItems()
        {
            List<Item> items  = new List<Item>();
            Weapon dagger = new Weapon("dagger",2, 5, 1, "piercing", false, 0.5f, 3);
            items.Add(dagger);
            Armor gambesonLight = new Armor("gambesonLight",1, 0, 1, 5);
            items.Add(gambesonLight);
            return items;
        }

        
        

    }
}
