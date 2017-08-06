using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public static class ChapterOne
    {

        public static void OpeningDialog(Person person)
        {
            Console.Write("You are a so-called hero. Abandoning your past life as your heart got broken, you became a traveller. ");
            Console.Write("You grew up on a farm like most of your past friends. You learned farming practices as you were to replace your father as owner of your small farm sometimes in the future. ");
            Console.Write("Life of a farmer isn't really exciting one, but its quite safe and that counts too. ");
            Console.Write("You would spend your life working on the field, caring of and breeding (and killing) animals, handling with traders and few times a year you may visit nearby villages on some event. ");
            Console.Write("You were expected to marry some girl from the village, have children and maybe become a little bit richer if you would be hard working (and lucky). ");
            Console.WriteLine("There was nothing else too choose from. Yes, you could try to 'find your luck' in the city, but you are not that kind of man. ");
            Console.WriteLine();
            
            Notice homeVillage = new Notice("homeVillage", "Place where you were born adn where you lived most of your life. Not very rich, but not very poor. quite boring, but you still like it");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            

            Console.Write("It all changed few weeks after you turned 18. Ann was beatiful. Not like Theresa, your village primadona who was trying everyone out just to say she can get anything. ");
            Console.Write("Ann was a pretty nice girl, but more so in the inside. She was intelligent, charismatic, entertaining, curious and pashionate. ");
            Console.Write("That night you spent together hanging around the village, while chased by her furioes father, was the most exciting thing happened to you ever by far. ");
            Console.Write("She gave you so much insight and inspiration, but she also learned something from you as there was something similiar in you both even you come from very different background. ");
            Console.WriteLine("She was daughter of a noble and you just an ordinary farm boy. Once her father and his guards found you talking and laughing in the old barn, you got beaten and you should never see her anymore. ");
            Console.WriteLine();
            Notice ann = new Notice("Ann", "Unforgetable girl. Daughter of a noble, cunning and intelligent who changed your life");
            person.AddNotice(ann);
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            Console.Write("Even few months after that unforgetable night, your head was still full of her and her stories. You tried to forget, but you couldnt. ");
            Console.Write("Life on the farm seemed so empty. Your younger brother was making fun of you when you missed with hammer or axe, because you couldnt concentrate anymore. Your parents got anxious too. You should be head of the whole farm soon. ");
            Console.Write("That idea that there is more to life somewhere else just wouldnt let go. You were thinking of possibilities. Idea that you would chase after Ann was crazy. ");
            Console.Write("Her father would never let you come close to her and even if she run away from him, what could you offer her? ");
            Console.Write("But there was more to the story. The reason they were travelling south to the coastal city of Lysen was that something was happening north. ");
            Console.WriteLine();
            Notice lysen = new Notice("Lysen" , "Big and rich coastal city, which lives of naval trade");
            person.AddNotice(lysen);
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();


            Console.Write("She said last year things had gone wrong somehow. Animals started to be more agressive, wandering around villages and even cities and attacking people. Few people even said they saw walking dead. More people were found dead or missing with no apparent reason. ");
            Console.Write("Some say its God's revenge for people's sins. Some say its some dark forgotten magic. Some say its just smalltalk and nothing that unusual.");
            Console.Write("Ann's father didn't care so much, but once the familly was attacked by wild boars, he became anxious. As the crazy stories continued, he decided to move. He never saw the ocean and warm climate will be more comfortable for his old age. ");
            Console.Write("So he sold their small castle and lands around to buy some mansion in Lysen and have enough money for retirement. ");
            Console.WriteLine();

            Console.WriteLine();
            Notice annsCastle = new Notice("AnnsCastle", "Some small castle in the north");
            person.AddNotice(annsCastle);
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            Console.Write("So you finally decided. You will travel north and try to find out what is really happening here. At least you have some reason to wander around and try to get more experience or earn some gold. ");
            Console.Write("Maybe its just all around crazy plan, but you feel like you have nothing to loose. There is still a chance that you can meet Ann again, but not if you stay here like uninteresting poor farm boy. ");
            Console.Write("You know it will hurt your parents who even though they are harsh and slow-witted sometimes, they still love you. At least they have your younger brother who can help them in the future. ");
            Console.Write("So you wrote your goodbye letter, took some coins you earned, food for few days and headed north. ");
            Console.Write("With mixture of expectations and uneasiness you started your new life... ");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void DialogWithOldMan (Person person)
        {
            Console.Clear();

            Console.Write("After a week of walking north, your journey went alright so far. Nothing really interesting happened, but at least you are still on the way and have some food and coins. Your next task will be earning money, getting equipment and learning new things. ");
            Console.Write("Noone mentioned anything about strange things happening in the north, maybe the noble just doesn't want to talk about it. ");
            Console.Write("You are walking on a long trading way to another village, when your sight catches silhouette of a person sitting under old maple tree. A man. A particulary old man. As you come closer, he aproaches you. ");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();


            if (DialogsManager.DialogOne("Old man: 'Not so common to see a stranger who is not a trader or thief here nowaydays.'", " 1 - 'How do you know Im not one of them?' ") == 1)
            {
                bool ChoiceDone = true;
                do

                {
                    
                    switch (DialogsManager.DialogTwo("Old man: 'I have seen too many folks to not recognize a traveler.'", "1 - 'Who are you?'", "2 - 'Do you know anything about strange thing happening north?'"))
                    {
                        case 1: Console.WriteLine("Old man: 'I'm not interesting or important now, rather tell me about yourself. '");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            CharacterCreation.Creation(person);
                            break;
                        case 2:
                            if (DialogsManager.DialogOne("Old man: 'People talk about lot of strange things, most of them are nonsense, but anyone of them could be true. Have an open and critical mind and you will see. '", "1 - 'Who are you?'") == 1)
                            {
                                Console.WriteLine("Old man: 'I'm not interesting or important now, rather tell me about yourself");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                CharacterCreation.Creation(person);
                            }
                            break;
                        default: ChoiceDone = false; break;

                    }
                }
                while (!ChoiceDone);
                
                
            }

        }

        public static void ToTheVillage(Person person)
        {
            Console.Clear();
            switch(DialogsManager.DialogTwo("Old man: 'Talking with you really made my day, people today are bound to their property, so afraid to loose even the smallest things they gained. " +
                "We lived in a stable society for long time and people get used to it fast. Instead of courage and hard decisions, instead of joy from unknown, we care mostly about our social position. " +
                "But it will change, soon or later. I don't know if these rumors about north are true or just crazy talk, probably a combination, but time will come when people like you will be the most needed in this world. " +
                "Enough small talk. If you go straight this way, you come to Oldgrave, village where I live now. Don't be afraid of the name, it's because there is very old graveyard near which was used for nearby population in past. Now its kind of abbandoned. " +
                "Take this dagger. I'm getting too old and weak to protect myself so I may aswell just surrender instantly. Good luck boy, I wish I was in your shoes...","1 - Wait, at least one thing about you. What's your name?", "2 - Farewell."))
            {
                case 1: if (DialogsManager.DialogOne("Old man: 'Oh, pardon my rudeness. I'm Hrothgar, but don't mention my name in Oldgrave much, I'm still stranger to them. Just tell Sam, the shoplifter, that you met me, he is a great guy and may help you.'", "1 - Bye") == 1)
                    {
                        Console.WriteLine("Hrothgar: 'See you in another life, my friend...'");
                    };
                    Notice hrothgar = new Notice("Hrothgar", "Old man I met on the road to Oldgrave. He was a bit jealous that I'm young and may go adventuring.");
                    person.AddNotice(hrothgar);
                    break;
                case 2:
                    Console.WriteLine("Old man: 'See you in another life, my friend...'");
                    break;

            }
            Console.WriteLine();
           


            Notice oldgrave = new Notice("Oldgrave", "Small village, first on my way to north. It's named after big old graveyard near the village.");
            person.AddNotice(oldgrave);
            person.TakeItem(new Weapon("dagger", 2, 5, 1, "piercing", false, 0.5f, 3));
            person.GainExperience(10);
            person.GettingTired();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            /* Console.Clear();
             switch(DialogsManager.DialogFive("What do you want to do?","1 - Head to the Oldgrave", "2 - Try to hunt and forage", "3 - Check your character stats", "4 - Check your inventory", "5 - Check your notepad"))
             {
                // case 1: ChapterOne.NearOldgrave();
                 //    break;
                 //    case2 2: 

             }

             */
        }
      
    }
}
