using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public static class CharacterCreation
    {
        public static void Creation (Person person)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("This is character creation. Be careful that your answers will shape who you are and how you will be able to play the game");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Old man: 'What's your name?'");    
            person.SetName(Console.ReadLine());
            Console.WriteLine();
            
                switch (DialogsManager.DialogThree("Old man: 'So " + person.Name + ", Tell me something about your childhood. How you interacted with others?'",
                "1 - 'I was playing with my dad and helping him with the work. I always tried to match his strenght and all kids were either afraid of me or followed me' ",
                "2 - 'I was climbing trees and exploring dangerous places. In conflict I either run away or wear out my opponent. Some boys got hurt by trying the stuff I did every day' ",
                "3 - 'I was collecting flowers and animals. I learned to read and count really early so other kids very either inspired by me or tried to bully me. Sometimes I talked them out, but few times I got beaten' "))
                {
                    case 1: person.SetAttribute(2, 0, 0); break;
                    case 2: person.SetAttribute(0, 2, 0); break;
                    case 3: person.SetAttribute(0, 0, 2); break;
                    default: break;

                }
            Console.WriteLine();

            switch (DialogsManager.DialogThree("Old man: 'Now, tell me more about your teen years'",
                "1 - 'Father used me for the harder work on a farm, carrying things, moving animals. I also got into fights rather easy and was winning most of the sports tournaments in our village' ",
                "2 - 'I would be crafting inside my fathers workshop most of the time or I would use my newly built machines to have fun and provoke our neighbors, then run away and hide in the wild' ",
                "3 - 'I read any book I could find, either fantastic, romantic or practical. I was always trying something new and different, never stayed too long with one thing. ' "))
            {
                case 1: person.SetAttribute(2, 0, 0); break;
                case 2: person.SetAttribute(0, 2, 0); break;
                case 3: person.SetAttribute(0, 0, 2); break;
                default: break;
            }

            Console.WriteLine();

            switch (DialogsManager.DialogThree("Old man: 'What else have you learned?'",
                "1 - 'I know most of herbs, shrubs, trees and animals and i know how to prepare them' ",
                "2 - 'When father was not watching, I was swordfighting with my friend. We also tried old axes and spears, which we found on the old battlefield' ",
                "3 - 'I was stuying the history and lot of 'secret' things. I was trying to scout few distant places or find people who know them. I love mysteries. ' "))
                    {
                        case 1: person.SetAttribute(2, 0, 0); break;
                        case 2: person.SetAttribute(0, 2, 0); break;
                        case 3: person.SetAttribute(0, 0, 2); break;
                        default: break;

                    }
        }
    }
}
