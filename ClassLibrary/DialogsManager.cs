using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RpgGameska
{
    public class DialogsManager
    {
        public static void City(Person person, Market market)
        {
            Console.Clear();
            Console.WriteLine("What do you want to do? Enter a number \n 1 : Check your inventory and stats \n 2: Go talk with people \n 3: Go shopping \n 4: Go to the dungeon \n 5: Go to the arena");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("You have decided to wiev your character info");
                    break;
                case "2":
                    Console.WriteLine("You have decided to go talk with people");
                    break;
                case "3":
                    Console.WriteLine("You have decided to go shopping");
                    Console.WriteLine("Waiting...");
                    Thread.Sleep(2000);

                    MarketManager.Shop(person, market);

                    break;
                case "4":
                    Console.WriteLine("You have decided to go to the dungeon");
                    break;
                case "5":
                    Console.WriteLine("You have decided to go to the arena");
                    break;
                default:
                    Console.WriteLine("Not a valid decision");
                    Console.WriteLine("Waiting...");
                    Thread.Sleep(2000);

                    City(person, market);
                    break;
            }
        }
        

        public static int DialogOne(string openMessage, string decision1)
        {
            bool validChoice;
            do
            {
                validChoice = true;
                Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;  
            Console.WriteLine(openMessage);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(decision1);
            Console.ForegroundColor = ConsoleColor.Gray;
            
            string input = Console.ReadLine();
            
                
                switch (input)
                {
                    case "1": return 1;
                    default:
                        Console.WriteLine("Not a valid decision");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                       
                        validChoice = false;
                        break;        
                }
            }
            while (!validChoice);
            return 0;
        }

        public static int DialogTwo(string openMessage, string decision1, string decision2)
        {
            bool validChoice;
            do
            {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(openMessage);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(decision1);
            Console.WriteLine(decision2);
            Console.ForegroundColor = ConsoleColor.Gray;
            
            string input = Console.ReadLine();
            
                validChoice = true;
                switch (input)
                {
                    case "1": return 1;
                    case "2": return 2;
                    default:
                        Console.WriteLine("Not a valid decision");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                        validChoice = false;
                        break;
                }
            }
            while (!validChoice);
            return 0;
        }

        public static int DialogThree(string openMessage, string decision1, string decision2, string decision3)
        {
            bool validChoice;
            do
            {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(openMessage);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(decision1);
            Console.WriteLine(decision2);
            Console.WriteLine(decision3);
            Console.ForegroundColor = ConsoleColor.Gray;
           
            string input = Console.ReadLine();
            
                validChoice = true;
                switch (input)
                {
                    case "1": return 1;
                    case "2": return 2;
                    case "3": return 3;
                    default:
                        validChoice = false;
                        Console.WriteLine("Not a valid decision");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            while (!validChoice);
            return 0;
        }

        public static int DialogFour(string openMessage, string decision1, string decision2, string decision3, string decision4)
        {
            bool validChoice;
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(openMessage);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(decision1);
                Console.WriteLine(decision2);
                Console.WriteLine(decision3);
                Console.ForegroundColor = ConsoleColor.Gray;

                string input = Console.ReadLine();

                validChoice = true;
                switch (input)
                {
                    case "1": return 1;
                    case "2": return 2;
                    case "3": return 3;
                    case "4": return 4;
                    default:
                        validChoice = false;
                        Console.WriteLine("Not a valid decision");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            while (!validChoice);
            return 0;
        }

        public static int DialogFive(string openMessage, string decision1, string decision2, string decision3, string decision4, string decision5)
        {
            bool validChoice;
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(openMessage);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(decision1);
                Console.WriteLine(decision2);
                Console.WriteLine(decision3);
                Console.ForegroundColor = ConsoleColor.Gray;

                string input = Console.ReadLine();

                validChoice = true;
                switch (input)
                {
                    case "1": return 1;
                    case "2": return 2;
                    case "3": return 3;
                    case "4": return 4;
                    case "5": return 5;

                    default:
                        validChoice = false;
                        Console.WriteLine("Not a valid decision");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            while (!validChoice);
            return 0;
        }

        public static int DialogSix(string openMessage, string decision1, string decision2, string decision3, string decision4, string decision5, string decision6)
        {
            bool validChoice;
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(openMessage);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(decision1);
                Console.WriteLine(decision2);
                Console.WriteLine(decision3);
                Console.ForegroundColor = ConsoleColor.Gray;

                string input = Console.ReadLine();

                validChoice = true;
                switch (input)
                {
                    case "1": return 1;
                    case "2": return 2;
                    case "3": return 3;
                    case "4": return 4;
                    case "5": return 5;
                    case "6": return 6;

                    default:
                        validChoice = false;
                        Console.WriteLine("Not a valid decision");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            while (!validChoice);
            return 0;
        }

    }

}
