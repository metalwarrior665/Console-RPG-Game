using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public class Market
    {
        public int Coins { get; private set; }
        public List<Weapon> WeaponInventory { get; private set; } = new List<Weapon>();
        public List<Armor> ArmorInventory { get; private set; } = new List<Armor>();

         Weapon dagger = new Weapon("dagger", 2, 5, 1, "piercing", false, 0.5f, 3);
         Weapon sword = new Weapon("sword", 5, 7, 0.6f, "slashing", true, 1.2f, 10);
         Weapon spear = new Weapon("spear", 7, 6, 0.4f, "piercing", true, 3f, 12);
         Weapon battleAxe = new Weapon("battleAxe", 8, 5, 0.5f, "slashing", true, 2f, 9);
         
         Armor gambesonLight = new Armor("gambesonLight", 1, 0, 1, 5);
         Armor gambesonThick = new Armor("gambesonThick", 3, 1, 3, 12);
         Armor chainmail = new Armor("chainmail", 5, 2, 5, 20);
         Armor platemail = new Armor("platemail", 8, 3, 10, 40);

        public Market()
        {
            ArmorInventory.Add(gambesonLight);
            ArmorInventory.Add(gambesonThick);
            ArmorInventory.Add(chainmail);
            ArmorInventory.Add(platemail);
            WeaponInventory.Add(dagger);
            WeaponInventory.Add(sword);
            WeaponInventory.Add(spear);
            WeaponInventory.Add(battleAxe);
        }

        public void ShowWeapons ()
        {
            foreach (Weapon weapon in WeaponInventory)
            {
                Console.WriteLine("{0} - damage = {1}, accuracy = {2}, speed = {3}, type = {4}, twohanded = {5}, weight {6}",
                      weapon.Name, weapon.Damage, weapon.Accuracy, weapon.Speed, weapon.Type, weapon.IsTwoHanded, weapon.Weight);
                Console.WriteLine("Price = " + weapon.Price  );
                Console.WriteLine("**************************");
            }
        }

        public void ShowArmor()
        {
            foreach (Armor armor in ArmorInventory)
            {
                Console.WriteLine("{0} - armor = {1}, dexterity penalty = {2}, Weight ={3}",
                      armor.Name, armor.Defense, armor.DexterityPenalty, armor.Weight);
                Console.WriteLine("Price = " + armor.Price);
                Console.WriteLine("**************************");
            }
        }
        public void Buy (Person person, Item item)
        {
            person.TakeItem(item);
            person.GainGold(-item.Price);
        }

        public void Sell(Person person, Item item)
        {
            person.DropItem(item);
            person.GainGold(item.Price/2);
        }
    }
}
