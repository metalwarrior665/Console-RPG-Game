using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public class Person : Being
    {
        // field
        public bool IsPlayer { get; private set; }

        public List<Item> Inventory { get; private set; } = new List<Item>();
        public List<Map> Maps { get; set; } = new List<Map>();
        public List<Notice> NoticeList { get; private set; } = new List<Notice>();


        public int Coins { get; private set; } = 50;

        public Weapon EquippedWeapon { get; private set; }
        public Armor EquippedArmor { get; private set; }

        public float MaxCarry { get; private set; }
        public float ActualCarry { get; private set; }

        

        // constructor
        public Person(string name, int strenght, int dexterity, int intelligence, int level, int armor, bool isPlayer)
            : base(name, strenght, dexterity, intelligence, level, armor)
        {
            Name = name;
            Strenght = strenght; Dexterity = dexterity; Intelligence = intelligence; Level = level; Armor = armor;
            MaxHP = Strenght * 3 + Strenght * Level;
            Damage = Strenght / 4;
            Accuracy = Dexterity + Strenght / 2;
            ActualHP = MaxHP;
            AttackSpeed = Dexterity / 2;
            BlockChance = Dexterity;
            IsPlayer = isPlayer;
            MaxCarry = 15f + strenght * 3;
            ActualCarry = 0;
            MaxStamina = 20 + strenght + dexterity;
            ActualStamina = MaxStamina;
        }
// with weapon and armor
        public Person(string name, int strenght, int dexterity, int intelligence, int level, int armor, bool isPlayer, Weapon equippedWeapon, Armor equippedArmor)
            : base(name, strenght, dexterity, intelligence, level, armor)
        {
            Name = name;
            Strenght = strenght; Dexterity = dexterity; Intelligence = intelligence; Level = level; Armor = armor;
            MaxHP = Strenght * 3 + Strenght * Level;
            Damage = Strenght / 4;
            Accuracy = Dexterity + Strenght / 2;
            ActualHP = MaxHP;
            AttackSpeed = Dexterity / 2;
            BlockChance = Dexterity;
            EquipWeapon(equippedWeapon);
            EquipArmor(equippedArmor);
            IsPlayer = isPlayer;
            MaxCarry = 15f + strenght * 3;
            ActualCarry = equippedArmor.Weight + equippedWeapon.Weight;
            MaxStamina = 20 + strenght + dexterity;
            ActualStamina = MaxStamina;
        }
// with coins and inventory
        public Person(string name, int strenght, int dexterity, int intelligence, int level, int armor, bool isPlayer, Weapon equippedWeapon, Armor equippedArmor, int coins, List<Item> inventory)
            : base(name, strenght, dexterity, intelligence, level, armor)
        {
            Name = name;
            Strenght = strenght; Dexterity = dexterity; Intelligence = intelligence; Level = level; Armor = armor;
            MaxHP = Strenght * 3 + Strenght * Level;
            Damage = Strenght / 4;
            Accuracy = Dexterity + Strenght / 2;
            ActualHP = MaxHP;
            AttackSpeed = Dexterity / 2;
            BlockChance = Dexterity;
            EquipWeapon(equippedWeapon); 
            EquipArmor(equippedArmor);
            Coins = coins;
            IsPlayer = isPlayer;
            MaxCarry = 15f + strenght * 3;
            ActualCarry = equippedArmor.Weight + equippedWeapon.Weight;

            foreach (Item item in inventory)
            {
                TakeItem(item);
            }
            MaxStamina = 20 + strenght + dexterity;
            ActualStamina = MaxStamina;
        }
        // Set name
        public void SetName (string name)
        {
            Name += name;
        }

        //
        public void SetAttribute (int plusStr, int plusDex, int plusInt)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Strenght += plusStr; Console.WriteLine("You gained {0} strenght", plusStr);
            Dexterity += plusDex; Console.WriteLine("You gained {0} dexterity", plusDex);
            Intelligence += plusInt; Console.WriteLine("You gained {0} intelligence", plusInt);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Item methods
        public void TakeItem(Item item)
        {
            if(MaxCarry >= ActualCarry + item.Weight)
            {
                Inventory.Add(item);
                ActualCarry += item.Weight;
                if (IsPlayer)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("*** Item acquired: " + item.Name + " ***");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            else
            {
                if (IsPlayer)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*** You cannot carry more weight! ***");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }

        public void DropItem(Item item)
        {
            Inventory.Remove(item);
            ActualCarry -= item.Weight;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*** Item dropped: " + item.Name + " ***");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        

        // Eat and rest
        public void EatAndRest(Food food)
        {
            Inventory.Remove(food);
            ActualStamina += food.Calories;
            if(ActualStamina > MaxStamina)
            {
                ActualStamina = MaxStamina;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** You rested and ate: " + food.Name + " ***");
            Console.WriteLine("Your stamina: " + ActualStamina + "/" + MaxStamina);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Equip methods
        public void EquipWeapon (Weapon weapon)
        {       
                if (EquippedWeapon != null)
                {
                UnequipWeapon();
                }   
            EquippedWeapon = weapon;
            Damage += weapon.Damage;
            Accuracy += weapon.Accuracy;
            AttackSpeed = AttackSpeed * weapon.Speed;
            Inventory.Remove(weapon);
        }

        public void EquipArmor(Armor armor)
        {
                if (EquippedArmor != null)
                {
                UnequipArmor();
                }
            EquippedArmor = armor;
            Armor += armor.Defense;
            Dexterity -= armor.DexterityPenalty;
            Inventory.Remove(armor);
        }

        public void UnequipWeapon ()
        {
            if (EquippedWeapon != null)
            {
                Damage -= EquippedWeapon.Damage;
                Accuracy -= EquippedWeapon.Accuracy;
                AttackSpeed = AttackSpeed * EquippedWeapon.Speed;
                Inventory.Add(EquippedWeapon);
                EquippedWeapon = null;     
            }
        }

        public void UnequipArmor()
        {
            if (EquippedArmor != null)
            {
                Armor -= EquippedArmor.Defense;
                Dexterity += EquippedArmor.DexterityPenalty;
                Inventory.Add(EquippedArmor);
                EquippedArmor = null; 
            }
        }
        // Gold and xo methods
        

        public void GainGold (int coins)
        {
            Coins += coins; 
        }

        public void AddNotice (Notice notice)
        {
            NoticeList.Add(notice);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*** Notice added: " + notice.Name + " ***");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void ShowNoticeList ()
        {
            foreach (var notice in NoticeList)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(notice.Name);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(notice.Text);
            }
        }

        // death
        public void Die()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("I'm sorry, but you died. Your journey in this life ends here. Lets look at your final stats.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            PlayerScreen.ShowCharacter(this);
        }

        

        


        
            
    }
}
