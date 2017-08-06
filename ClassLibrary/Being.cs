using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RpgGameska
{
    public  class Being
    {
        public string Name { get; protected set; }
        public int Strenght { get; protected set; }
        public int Dexterity { get; protected set; }
        public int Intelligence { get; protected set; }
        public int Level { get; protected set; }
        public float BlockChance { get; protected set; }
        public int Armor { get; protected set; }
        public int MaxHP { get; protected set; }
        public int ActualHP { get; protected set; }
        public int Damage { get; protected set; }
        public int Accuracy { get; protected set; }
        public float AttackSpeed { get; protected set; }
        public int Experience { get; protected set; }
        public int MaxStamina { get; protected set; }
        public int ActualStamina { get; set; }
        public Item BodyParts { get; set; }
        public List<Item> Inventory { get; set; }
// without body parts
        public Being(string name, int strenght, int dexterity, int intelligence, int level, int armor)
        {
            Name = name;
            Strenght = strenght; Dexterity = dexterity; Intelligence = intelligence; Level = level; Armor = armor;
            MaxHP = Strenght * 3 + Strenght * Level;
            Damage = Strenght / 4;
            Accuracy = Dexterity + Strenght / 2;
            ActualHP = MaxHP;
            AttackSpeed = Dexterity / 2;
            BlockChance = Dexterity;
            MaxStamina = 20 + strenght + dexterity;
            ActualStamina = MaxStamina;
        }
        // with body parts
        public Being (string name, int strenght, int dexterity, int intelligence, int level, int armor, Item bodyParts )
        {
            Name = name;
            Strenght = strenght; Dexterity = dexterity; Intelligence = intelligence; Level = level; Armor = armor;
            MaxHP = Strenght * 3 + Strenght * Level;
            Damage = Strenght / 4;
            Accuracy = Dexterity + Strenght / 2;
            ActualHP = MaxHP;
            AttackSpeed = Dexterity / 2;
            BlockChance = Dexterity;
            BodyParts = bodyParts;
            MaxStamina = 20 + strenght + dexterity;
            ActualStamina = MaxStamina;
        }

        // Death event
        public event EventHandler<NpcDeathEventArgs> NpcDeath;

        public virtual void OnNpcDeathPublisher(int exp, Item bodyParts, List<Item> inventory)
        {
            if (NpcDeath != null)
            {
                NpcDeath(this, new NpcDeathEventArgs() { Exp = this.Strenght + this.Dexterity + this.Intelligence + this.Armor, BodyParts = bodyParts, Inventory = inventory});
            }
        }
        
        public void OnNpcDeathSubscriber(object source, NpcDeathEventArgs e)
        {
            this.GainExperience(e.Exp);
            
            if (source is Person)
            {
                foreach (Item item in e.Inventory)
                {
                    (this as Person).TakeItem(item);
                }
            }
            else
            {
                (this as Person).TakeItem(e.BodyParts);
            }
           

        }
        // Attack
        public void AttackOn (Being opponent)
        {
            Thread.Sleep(50);
            Dice dice = new Dice();
            float hit = (this.Accuracy + dice.Roll()) - (opponent.BlockChance + dice.Roll());
           
            if (hit >= 0)
            {
                float attackDamage = this.Damage + hit / 3 - opponent.Armor;
                if (attackDamage < 0)
                {
                    attackDamage = 0;
                }
                opponent.LooseHp((int)attackDamage);
                Console.WriteLine("{0} did {1} damage to {2} \n His actual HP is {3}",
                    this.Name, attackDamage, opponent.Name, opponent.ActualHP);
            }  
        }
        // Loose Hp
        public void LooseHp (int hp)
        {
            ActualHP -= hp;
            if (ActualHP < 0)
            {
                ActualHP = 0;
            }
        }
        // Heal
        public void HealHP (int hp)
        {
            ActualHP += hp;
            if (ActualHP > MaxHP)
            {
                ActualHP = MaxHP;
            }
        }

        // Getting Tired
        public void GettingTired()
        {
            ActualStamina -= 1;
        }
        // Gain Exp
        public void GainExperience(int experience)
        {
            Experience += experience;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** Gained: " + experience + " xp ***");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
