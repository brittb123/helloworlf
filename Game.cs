using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {

            //Weapon damge stats
         
            int damage = 15;
            int fireball = 20;
            int lightning = 25;
            int dagger = 15;


            //Enemies and battle commands
            int battle = ' ';
            bool BattleStarted = false;
            int goblin = ' ';
            int goblinHealth = 100;



            //Starting and max level values and stats
            bool maxLevelReached = false;
            int maxlevel = 100;
            int level = 1;
            bool ready = true;
            string role = "none";
            int stealth = 10;
            int armor = 10;
            int coins = 150;
            int Magic = 50;

            //Name input for player
            Console.Write("What is your name traveler?");
            Console.WriteLine();
            string name = Console.ReadLine();

            //This variable is for health
            float health = 100.0f;
            //This value is for how much a player regens
            float healthRegen = 20;
            //Role choices for start!

            Console.WriteLine("Ah so you are " + name + "! What will your class be?");
            Console.WriteLine("Here are your choices:");
            Console.WriteLine("Rogue, Druid, Alchemist, Warrior, Warlock");
            Console.WriteLine("Press 1 for a Rogue");
            Console.WriteLine("Press 2 for a Druid");
            Console.WriteLine("Press 3 for a Alchemist");
            Console.WriteLine("Press 4 for a Warrior");
            Console.WriteLine("Press 5 for a Warlock");
            char input = Console.ReadKey().KeyChar;
            while (input != '1' && input != '2' && input != '3' && input != '4' && input != '5')
                input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                health = 80;
                role = "Rogue";
                stealth = 45;
                armor = 30;
                damage = 15;
            }

            else if (input == '2')
            {
                health = 90;
                role = "Druid";
                stealth = 35;
                armor = 40;
                damage = 15;

             }

            else if (input == '3')
            {
                health = 95;
                role = "Alchemist";
                stealth = 40;
                armor = 30;
                damage = 25;
            }
            
            else if (input == '4')
            {
                health = 110;
                role = "Warrior";
                stealth = 25;
                armor = 50;
                damage = 20;
            }
            else if (input == '5')
            {
                health = 80;
                role = "Warlock";
                stealth = 25;
                armor = 15;
                damage = 10;
            }

               else
            {
                Console.WriteLine("Invalid choice, using base stats!");
            }
            

            //The player stats, name, and role selected
            Console.WriteLine("\nPlayer Name: " + name);
            Console.WriteLine("Chosen Role: " + role);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Stealth Ability: " + stealth);
            Console.WriteLine("Armor Rating: " + armor);

            //Picking their starting story
            Console.WriteLine("Ahh so you are a " + role + "! So what is your background story?");
            Console.WriteLine("Press 1 if you are a thief chased out of town");
            Console.WriteLine("Press 2 if you are a healer from a Xerus");
            Console.WriteLine("Press 3 if you a guard from out of town");
            Console.WriteLine("Press 4 if you are a hunter from the wild");
            char backstory = ' ';
            while (backstory != '1' && backstory != '2' && backstory != '3' && backstory != '4')
            {
               backstory = Console.ReadKey().KeyChar;
                if (backstory == '1')
                {
                    stealth += stealth + 25;
                    coins += coins + 100;
                }

                else if (backstory == '2')
                {
                    Magic += Magic + 25;
                    coins += coins + 150;
                }

                else if (backstory == '3')
                {
                    armor += armor + 20;
                    coins += coins + 200;
                }

                else if (backstory == '4')
                {
                    health += health + 10;
                    coins += coins + 50;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Choice!");
                }
            }

            Console.WriteLine();

            //Prepared for the start and check stat chart
            Console.WriteLine("So " + name + ", Are you ready to start the adventure? ");
            Console.WriteLine(" Press Y for Yes, Press N for Stat chart");
            char readytostart = Console.ReadKey().KeyChar;
            if (readytostart == 'y')
            {
                Console.Clear();
            }
             else if (readytostart == 'n')
            {
                Console.WriteLine(health);
                Console.WriteLine(role);
                Console.WriteLine(stealth);
                Console.WriteLine(armor);
                Console.WriteLine(coins);
                Console.WriteLine("Are you ready for the adventure?");
                Console.ReadLine();
                Console.Clear();

            }

            // The Bounty Hunt Part 1 

            Console.WriteLine("As you leave town a man shouting about a high bounty is available.");
            Console.WriteLine("Do you approach and listen or ignore and walk away?");
            Console.WriteLine("Press 1 to approach and listen");
            Console.WriteLine("Press 2 to ignore and walk away");
            Console.WriteLine();
            char bountyone = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (bountyone == '1')
            {
                Console.WriteLine("You walk up and listen to a old man waving a flyer");
                Console.WriteLine("He claims there is a dangerous Rogue that needs to be stopped");
                Console.WriteLine("He hands you a bounty with a picture of a elf and a reward of 500 coins");
                Console.WriteLine("The last seen location was at Dry Rock a few miles from here! Better start" +
                    " moving!");
            }
             else 
            {
                Console.WriteLine(" You ignore the man and continue out of town on a dirt road");
            }


            //First CrossRoad near Yolav
            char goblinpath = ' ';
            Console.WriteLine("You approach a crossroad with a sign that says left is Dry Rock and Right is Fahal");
            Console.WriteLine("Which way would you like to go");
            Console.WriteLine("Press 1 to go right");
            Console.WriteLine("Press 2 to go left");
            char firstcrossroad = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (firstcrossroad == '1')
            {
                
                Console.WriteLine("You take a right turn and head to Fahal on a dirt road");
                Console.WriteLine("As you walking down the dirt path you see a goblin walk past");
                Console.WriteLine("The goblin turns to you and blows a giant horn as you see squads of goblins appear");
                Console.WriteLine("Do you want to turn around or attempt to fight the goblins");
                Console.WriteLine("Press 1 to fight the goblins or Press 2 to turn and leave");
                
                while (goblinpath != '1' && goblinpath != '2')
                {
                   goblinpath = Console.ReadKey().KeyChar;
                   
                    if (goblinpath == '1')
                    {
                        Console.WriteLine("You ready your weapon as you approach the road");
                        Console.WriteLine("A goblin turns to you and moves in to battle");
                        BattleStarted = true;
                        while (health > 0 && goblinHealth > 0)
                        {
                            Console.WriteLine("You have a chance to attack one of the goblins do you take the chance");
                            Console.WriteLine("Press 1 for a attack with your starting weapon or Press 2 to try and escape");
                            battle = Console.ReadKey().KeyChar;
                            if (battle == '1')
                            {
                                Console.WriteLine("You swing and deal 15 damage to the goblin");
                                goblinHealth -= dagger;
                                Console.WriteLine("The goblin turns in anger and swings a club ad hits for 5");
                                health -= 5;


                            }
                        }
                       
                       

                    }

                    else if (goblinpath == '2')
                    {
                        Console.WriteLine(" You think their is to many and turn around to the other path");
                    }
                }

                
            }
             else if (firstcrossroad == '2')
            {
                Console.WriteLine("You look right and head down a cobblestone pathway");
            }

        }
    }
}
