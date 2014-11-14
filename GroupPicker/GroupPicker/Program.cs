using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            CombatSimulator2();
        }

        static void CombatSimulator2()
        {
            bool playing = true;
            bool playAgain = true;

            do
            {
                char input = ' ';
                int intInput =0;
                //generate random events
                Random rng = new Random();
                bool attacksBegin = true;

                //commencing cat and mouse game
                int beginGame = 0;
                int randomDamage = 0;
                int randomMove = 0;
                int counter = 0;
                var kittyWeapons = 0;

                string mouseyMessage = string.Empty;
                string kittyMessage = string.Empty;

                bool inputCorrect = false;

                //weapons of choice for mouse
                string hamstersBall = "You've chosen Henry the Hamster's Ball!";
                string catNip = "The evil Dr. Meow Meow's only vice.";
                string teddyTheDog = "The connosseiur of pain's archnemesis";

                //weapons of choice for kitty
                string kittyPounce = "Lookout! The kitty is preparing to pounce!";
                string kittyClaws = "You poor little mouse! Kitty claws are the absolute worst";
                string kittyTeeth = "Hang onto your tail! The connosseiur of pain is trying to eat you!";

                //player health/hit points
                int mouseHitPoints = 100;
                int kittyHitPoints = 200;

                int kittyMissChance = 15;

                //game loop
                while (playing)
                {
                    Console.Clear();
                    input = ' ';
                    Console.WriteLine();

                    switch (beginGame)
                    {
                        case 0:
                            Console.WriteLine("Life is hard being a mouse, but this fact becomes all the more painfully apparent when you've got to pick up cheese for your mouse family. Why must it always be on the table at eye level with the evil Dr. Meow Meow's favorite scratching post? There's no doubt about it however, you need that cheese. So what do you do? \n\n1 You borrow Henry's hamster ball\n\n2 You reach for the catnip -- the only vice of the evil connosseiur of pain.\n\n3 Or you call Teddy the dog to the rescue. He's been yearning for vengeance for years.");
                            
                            do 
                            {

                            
                            input = Console.ReadKey().KeyChar;

                             switch (input)
                             {
                             case '1':
                                    mouseyMessage = "What a sensible mouse you are. You decide to go with Henry's Hamster ball.";

                                    beginGame = 1;
                                    break;

                                case '2':
                                    mouseyMessage = "You decide to go with the catnip. That should get the evil Dr. Meow Meow out of your way";
                                    beginGame = 2;
                                    break;

                                case '3':

                                    mouseyMessage = "Excellent choice. Teddy the dog will be most pleased, that noble knave.";
                                    beginGame = 3;
                                    break;
                            }

                            break;
                            
                            randomMove = rng.Next(1, 4);

                            //kitty attacks                 
                            if (randomMove == 1)
                            {
                               mouseyMessage = "You've been kitty pounced. You take " + mouseHitPoints + " in damage. Being pounced on is no fun. Press any key to continue.";
                               mouseHitPoints -= randomDamage;

                                Console.ReadKey();
                            }
                            else if (randomMove == 2)
                            {
                                mouseyMessage = "Kitty claws are the worst. Go find a spot to clean out your wounds. You take " + mouseHitPoints + " in damage and vow revenge.";
                                mouseHitPoints -= randomDamage;
                                Console.ReadKey();
                            }
                            else if (randomMove == 3)
                            {

                                mouseyMessage = "You're getting munched on. You take " + mouseHitPoints + " in damage. Scurry up and get out of there before you get eaten!";
                                mouseHitPoints -= randomDamage;
                                Console.ReadKey();
                            }
                            }//wh

                    }
                                

                      



                            }
                    }//wh
                    
                }

                

            }
           
        }
    }
}