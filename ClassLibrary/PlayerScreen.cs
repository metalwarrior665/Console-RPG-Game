using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public static class PlayerScreen
    {
        // INVENTORY
        public static void ShowInventory(Person person)
        {
            Console.Clear();
            Console.WriteLine("*** Information ***");
            Console.WriteLine();
            Console.WriteLine("You have " + person.Coins + " gold");
            Console.WriteLine("Your carrying capacity: " + person.ActualCarry + "/" + person.MaxCarry);
            Console.WriteLine();
            Console.WriteLine("*** Equipped armor ***");
            Console.WriteLine();
            var armor = person.EquippedArmor;
            if (person.EquippedArmor != null)
            {
                Console.WriteLine($"{armor.Name} - armor value: {armor.Defense}, dex penalty: {armor.DexterityPenalty}, weight: {armor.Weight}, price: {armor.Price}");
            }
            else
            {
                Console.WriteLine("You are unarmored!");
            }
            Console.WriteLine();
            Console.WriteLine("*** Equipped Weapon ***");
            Console.WriteLine();
            var weapon = person.EquippedWeapon;
            if(weapon != null)
            {
                Console.WriteLine($"{weapon.Name} - damage: {weapon.Damage}, accuracy: {weapon.Accuracy}, speed: {weapon.Speed}, twohanded: {weapon.IsTwoHanded}, type: {weapon.Type}, weight: {weapon.Weight}, price: {weapon.Price}");
            }
            else
            {
                Console.WriteLine("You are unarmed!");
            }
            Console.WriteLine();
            Console.WriteLine("*** Your backpack ***");
            Console.WriteLine();

            foreach (Item item in person.Inventory)
            {
                Console.Write(item.Name + " - ");
                if (item is Weapon)
                {
                     weapon = item as Weapon;
                    Console.Write($"damage: {weapon.Damage},  accuracy: {weapon.Accuracy}, speed: {weapon.Speed}, twohanded: {weapon.IsTwoHanded}, type: {weapon.Type}");
                }
                if (item is Armor)
                {
                    armor = item as Armor;
                    Console.Write($"armor: {armor.Defense}, dex penalty: {armor.DexterityPenalty}");
                }
                Console.WriteLine($", weight: {item.Weight}, price: {item.Price}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


        }

        public static void ShowCharacter(Person person)
        {
            Console.Clear();
            Console.WriteLine("*** Main Info ***");
            Console.WriteLine();
            Console.WriteLine("Name: "+ person.Name);
            Console.WriteLine("HP: "+ person.ActualHP+"/"+person.MaxHP);
            Console.WriteLine("Stamina: "+person.ActualStamina+"/"+person.MaxStamina);
            Console.WriteLine("Level: "+person.Level);
            Console.WriteLine("Experience: "+person.Experience);
            Console.WriteLine();

            Console.WriteLine("*** Attributes ***");
            Console.WriteLine();
            Console.WriteLine("Stregth: " + person.Strenght);
            Console.WriteLine("Dexterity: "+ person.Dexterity);
            Console.WriteLine("Intelligence: "+ person.Intelligence);
            Console.WriteLine();

            Console.WriteLine("*** Combat stats ***");
            Console.WriteLine();
            Console.WriteLine("Damage: " + person.Damage);
            Console.WriteLine("Accuracy: " + person.Accuracy);
            Console.WriteLine("Attack speed: " + person.AttackSpeed);
            Console.WriteLine("Armor: " + person.Armor);
            Console.WriteLine("Block chance: " + person.BlockChance);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void ShowNotepad(Person person)
        {
            Console.Clear();
            Console.WriteLine("*** Your map ***");
            Console.WriteLine();
            foreach(var map in person.Maps)
            {
                Console.WriteLine(map.Name);
            }
            Console.WriteLine();

            Console.WriteLine("*** Your Notice list ***");
            Console.WriteLine();
            foreach(var notice in person.NoticeList)
            {
                Console.WriteLine(notice.Name + ": " + notice.Text);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
