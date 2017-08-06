using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RpgGameska
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Person lukas = new Person("lks", 10, 10, 15, 1, 0, true, new Weapon("dagger", 2, 5, 1, "piercing", false, 0.5f, 3), new Armor("chainmail", 5, 2, 5, 20), 10, new List<Item> { new Armor("platemail", 20, 2, 5, 20), new Armor("chainmail", 5, 2, 7, 20), new Food("apples", 2, 1, 2), new Weapon("spear", 5, 5, 0.3f, "piercing", true, 3f, 10) });

                 
             Being ghoul = new Being("Ghoul", 5, 10, 7, 1, 1, new Item("Ghoul parts", 1, 0.5f));
            

            Person thief = new Person("Thief", 8, 10, 10, 1, 1, false, new Weapon("dagger", 2, 5, 1, "piercing", false, 0.5f, 3), new Armor("unarmored",0,0,0,0), 20, new List<Item> { new Item("secret letter", 0, 0.1f), new Item("blue gem", 50, 0.3f), new Weapon ("spear",5,5,0.3f,"piercing",true,3f,10),  });
            //  ChapterOne.OpeningDialog(lukas);
             // ChapterOne.DialogWithOldMan(lukas);
            // Market market = new Market();
            //   MarketManager.Shop(lukas, market);
              Console.WriteLine(Fight.Fight1v1(lukas, thief));
                Console.WriteLine(Fight.Fight1v1(lukas, ghoul));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            //   ChapterOne.ToTheVillage(lukas);
            //  PlayerScreen.ShowNotepad(lukas);
            //  lukas.EquipWeapon(lukas.Inventory.Find(a => a.Name == "spear"));
            ///  PlayerScreen.ShowInventory(lukas);
              PlayerScreen.ShowCharacter(lukas);
            // lukas.EatAndRest(Food)(lukas.Inventory.Find(a  => a.Name == "apples")) ;



            // PlayerScreen.ShowInventory(thief);



        }




    }
}
