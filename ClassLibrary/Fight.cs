using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public static class Fight
    {
        
        public static bool FightOn (Being being1, Being being2)
        {
            Dice dice = new Dice();
            Console.WriteLine($"{being2.Name} is trying to attack you. Do you want to run away? \n 1. Fight \n 2. Run \n 3. Talk yourself out of fight");
            string input = Console.ReadLine();
            if (input == "1")
            {
                return true;
            }
            else if (input == "2")
            {
                if (being1.Dexterity + dice.Roll() > being2.Dexterity + dice.Roll())
                {
                    Console.WriteLine("You run away successfully.");
                    return false;    
                }

                else
                {
                    Console.WriteLine("You have been dragged to another round of fighting. ");
                    return true;
                }

            }

            else if (input == "3")
            {
                if (being2.Intelligence > 5)
                {
                    if (being1.Intelligence + dice.Roll() > being2.Intelligence +dice.Roll())
                    {
                        Console.WriteLine("You convinced him/her not to fight. ");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("You enraged him/her even more. ");
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("You cannot talk out of this");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("You couldnt decide, so you were attacked");
                return true;
            }
        }

        public static string Fight1v1(Being being1, Being being2)
        {

            // Round of fight
            float roundAS1 = 0;
            float roundAS2 = 0;
            while (FightOn(being1, being2))
                {
               
                roundAS1 += being1.AttackSpeed;
                roundAS2 += being2.AttackSpeed;
                    while (roundAS1 > 0 && roundAS2 > 0)
                    {
                        if (roundAS1 > roundAS2)
                        {
                            being1.AttackOn(being2);
                            roundAS1 -= 1;
                        }
                        else
                        {
                            being2.AttackOn(being1);
                            roundAS2 -= 1;
                        }
                    if (being2.ActualHP <= 0 || being2.ActualStamina <= 0)
                    {    
                        being2.NpcDeath += being1.OnNpcDeathSubscriber;
                        if (being2 is Person)
                        {
                            being2.OnNpcDeathPublisher(being2.Strenght + being2.Dexterity + being2.Intelligence + being2.Armor, being2.BodyParts, (being2 as Person).Inventory);
                        }
                        else
                        {
                            being2.OnNpcDeathPublisher(being2.Strenght + being2.Dexterity + being2.Intelligence + being2.Armor, being2.BodyParts, being2.Inventory);
                        }
                        
                        return ("Winner is " + being1.Name);
                    }
                    else if (being1.ActualHP <= 0 || being2.ActualStamina <=0)
                    {
                        if(being1 is Person)
                        {
                            var player = being1 as Person;
                            if (player.IsPlayer)
                            {
                                player.Die();
                            }
                        }
                        return ("Winner is " + being2.Name); 
                    } 
                    
                }
                being1.GettingTired();
                being2.GettingTired();
                Console.WriteLine();
                Console.WriteLine("*** Round ended ***");
                Console.WriteLine();
                Console.WriteLine($"{being1.Name} - HP: {being1.ActualHP}/{being1.MaxHP}, Stamina: {being1.ActualStamina}/{being1.MaxStamina}" );
                Console.WriteLine($"{being2.Name} - HP: {being2.ActualHP}/{being2.MaxHP}, Stamina: {being2.ActualStamina}/{being2.MaxStamina}");
            }
            return "No winner";
        }

    }
}
