using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RpgGameska
{
    public static class MarketManager
    {

        public static void Shop (Person person, Market market)
        {
            Console.Clear();
            Console.WriteLine("***Welcome to the market, where you can buy whatever you want. You can also sell everything for half the buying price***");
            Console.WriteLine();
            Console.WriteLine("You have " + person.Coins + " gold");
            Console.Write("Your inventory: ");
            foreach (Item item in person.Inventory)
                Console.Write(item.Name + ", ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Weaponsmith: \n" );
            market.ShowWeapons();
            Console.WriteLine();

            Console.WriteLine("Armorsmith: \n");
            market.ShowArmor();
            Console.WriteLine();
            Console.WriteLine("**************************");
            Console.WriteLine("**************************");

            Console.WriteLine("To buy, write the name of the item");
            string input = Console.ReadLine();
            switch (input)
            {
                case "dagger": market.Buy(person, market.WeaponInventory.Find(a => a.Name == "dagger")); break;
                case "sword": market.Buy(person, market.WeaponInventory.Find(a => a.Name == "sword")); break;
                case "spear": market.Buy(person, market.WeaponInventory.Find(a => a.Name == "spear")); break;
                case "battleAxe": market.Buy(person, market.WeaponInventory.Find(a => a.Name == "battleAxe")); break;

                case "gambesonLight": market.Buy(person, market.ArmorInventory.Find(a => a.Name == "gambesonLight")); break;
                case "gambesonThick": market.Buy(person, market.ArmorInventory.Find(a => a.Name == "gambesonThick")); break;
                case "chainmail": market.Buy(person, market.ArmorInventory.Find(a => a.Name == "chainmail")); break;
                case "platemail": market.Buy(person, market.ArmorInventory.Find(a => a.Name == "platemail")); break;

                default: Console.WriteLine("invalid input"); break;
            }
            Console.WriteLine("Waiting...");
            Thread.Sleep(1000);
            
            Shop(person, market);
            

                





        }
    }
}
