using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSim
{
    class Program
    {
        static void Main(string[] args)
        {
            CombatSim();
            Console.ReadKey();
        }

        static void CombatSim()
        {
            //declare variables for the game
            int playerHP = 100;
            int enemyHP = 200;
            Random randomNumberGenerator = new Random();

            //start the main game loop
            // combat continues until one player is dead
            while (playerHP > 0 && enemyHP > 0)
            {
                //display round info
                Console.WriteLine("Player HP: " + playerHP);
                Console.WriteLine("Enemy HP: " + enemyHP);

                //ask user to make an attack
                string attackChoice = GetUserAttackChoice();
                //do the user attack
                if (attackChoice == "1")
                {
                    //we are attack with a sword
                    // 70% chance to hit, 15-20 damage
                    if (randomNumberGenerator.Next(1, 11) > 3)
                    {
                        //its a hit, calculate damage
                        int damage = randomNumberGenerator.Next(15, 21);
                        Console.WriteLine("You hit the enemy for: " + damage);
                        enemyHP -= damage;
                    }
                    else
                    {
                        Console.WriteLine("You missed!");
                    }
                }
                else if (attackChoice == "2")
                {
                    // planting magic beans
                    // always hits, for 10-15
                    int damage = randomNumberGenerator.Next(10, 16);
                    Console.WriteLine("You planted a magic bean, that quickly sprouted into one \n of those toothy plants from Mario and it takes a bite out of the enemy for " + damage + " damage.");
                    enemyHP -= damage;
                }
                else
                {
                    //drink a potion
                    //restores player hp by 10-15
                    int heal = randomNumberGenerator.Next(10, 16);
                    Console.WriteLine("You drank a mystical potion called Monster energy drink, and it gives you wings for " + heal);
                    playerHP += heal;
                }


                //enemy does its attack
                // 80% chance to hit, for 10-15 damage
                if (randomNumberGenerator.Next(1, 5) > 1)
                {
                    //its a hit
                    int damage = randomNumberGenerator.Next(10, 16);
                    Console.WriteLine("The enemy took a bite out of your butt for " + damage);
                    playerHP -= damage;
                }
            }

            //outside of the loop, say congrats or better luck next time
            if (playerHP > 0)
            {
                //player won
                Console.WriteLine("Thou hast slain thy enemy, huzzah!");
            }
            else
            {
                //lost
                Console.WriteLine("You aren't very good at this game.  Better luck next time. Plant more magic beans.");
            }
        }
        static string GetUserAttackChoice()
        {
            Console.WriteLine(@"Choose your attack:
1. Sword
2. Magic Beans
3. Drink a potion.");
            string input;
            do
            {
                //get user input
                input = Console.ReadLine();
            } while (input != "1" && input != "2" && input != "3");
            //have valid input
            return input;
        }
    }
}
