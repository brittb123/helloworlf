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
            char PlayerChoices(char Choice1, char Choice2, char Choice3)
            {
               char playerChoice = Console.ReadKey().KeyChar;
                Console.WriteLine("Press 1 for " + Choice1);
                Console.WriteLine("Press 2 for " + Choice2);
                Console.WriteLine("Press 3 for " + Choice3);
                return playerChoice;
            }

            void PlayerStats(string name, string role, int level, float health, int armor, int magicMeter, int coins)
            {
                Console.WriteLine("Player Name: " + name);
                Console.WriteLine("Chosen Role: " + role);
                Console.WriteLine("Players Level: " + level);
                Console.WriteLine("Players health: " + health);
                Console.WriteLine("Players armor: " + armor);
                Console.WriteLine("Players Magic Meter: " + magicMeter);
                Console.WriteLine("Players Wealth: " + coins);
            }

            bool gameOver = false;

            while (gameOver = true)
            {

                //town names and syntaxes

                int Yolav = ' ';




                //items for adventure
                int lockpicks = ' ';





                //Weapon damge stats

                int damage = 15;
                int fireball = 20;
                int lightning = 25;
                int dagger = 15;
                int bow = 20;
                bool poisoned = false;
                int magicMeter = 100;


                //Enemies and battle commands
                int battle = ' ';
                bool BattleStarted = false;
                int goblin = ' ';
                int goblinHealth = 100;
                int SpellsToCast = ' ';



                //Starting and max level values and stats
                bool maxLevelReached = false;

                int maxlevel = 100;
                int level = 1;
                bool ready = true;
                string role = "none";
                int stealth = 10;
                int armor = 10;
                int coins = 150;
                int agility = 20;

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
                    magicMeter = 65;
                    agility = 50;
                }

                else if (input == '2')
                {
                    health = 90;
                    role = "Druid";
                    stealth = 35;
                    armor = 40;
                    damage = 15;
                    magicMeter = 70;
                    agility = 40;

                }

                else if (input == '3')
                {
                    health = 95;
                    role = "Alchemist";
                    stealth = 40;
                    armor = 30;
                    damage = 25;
                    magicMeter = 80;
                    agility = 35;
                }

                else if (input == '4')
                {
                    health = 110;
                    role = "Warrior";
                    stealth = 25;
                    armor = 50;
                    damage = 20;
                    magicMeter = 50;
                    agility = 30;
                }

                else if (input == '5')
                {
                    health = 80;
                    role = "Warlock";
                    stealth = 25;
                    armor = 15;
                    damage = 10;
                    magicMeter = 115;
                    agility = 20;
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
                        magicMeter += magicMeter + 25;
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
                  
                    Console.WriteLine("\nPlayer Health : " + health);
                    Console.WriteLine("Chosen Role: " + role);
                    Console.WriteLine("Players Stealth Ability: " + stealth);
                    Console.WriteLine("Players Armor: " + armor);
                    Console.WriteLine("Players Currency: " + coins);
                    Console.WriteLine("Are you ready for the adventure?");
                    Console.ReadLine();
                    Console.Clear();

                }

                // The Bounty Hunt Part 1 

                Console.WriteLine("As you leave town a man shouting about a high bounty is available.");
                Console.WriteLine("Do you approach and listen or ignore and walk away?");
                
                Console.WriteLine("Press 1 to approach and listen");
                Console.WriteLine("Press 2 to ignore and walk away");
                Console.WriteLine("Press 3 to go back to the Town");
                Console.WriteLine();
                char bountyone = ' ';
                Console.WriteLine();
                
                while (bountyone != '1' && bountyone != '2' && bountyone != '3')
                {
                     bountyone = Console.ReadKey().KeyChar;

                    if (bountyone == '1')
                    {
                        Console.WriteLine("You walk up and listen to a old man waving a flyer");
                        Console.WriteLine("He claims there is a dangerous Rogue that needs to be stopped");
                        Console.WriteLine("He hands you a bounty with a picture of a elf and a reward of 500 coins");
                        Console.WriteLine("\nThe last seen location was at Dry Rock a few miles from here! Better start" +
                            " moving!");
                    }
                    else if (bountyone == '2')
                    {
                        Console.WriteLine(" \nYou ignore the man and continue out of town on a dirt road");
                    }

                    // If the player decides to go back into Yolav
                    else if (bountyone == '3')
                    {

                        while (Yolav != '4') 
                        {
                            Console.Clear();
                            Console.WriteLine("You turn back and head into town square. You have may places you can visit in this town Yolav!");
                            Console.WriteLine("Press 1 for Shops around town!");
                            Console.WriteLine("Press 2 for Inns and Pubs around town!");
                            Console.WriteLine("Press 3 for Local Hotspots and other places!");
                            Console.WriteLine("Press 4 to exit the town!");
                            Yolav = Console.ReadKey().KeyChar;
                            if (Yolav == '1')
                            {
                                Console.WriteLine("\nYou walk to the shops center and see a blacksmith, alchemist, a magic shop, and a general stall");

                            }

                            else if (Yolav == '2')
                            {
                                Console.WriteLine("\nYou walk a little minute to where you see a Pub and a inn!");
                                Console.WriteLine("You can go to The Sleeping Weasel inn, BerryBriars Brewery");
                            }

                            else if (Yolav == '3')
                            {
                                Console.WriteLine(" \nYou walk around the sqaure to see a wishing well, a festival, and people sitting near a campfire cooking for people");
                            }

                            else if (Yolav == '4')
                            {
                                Console.WriteLine("Y\nou head back to the right gate and leave the town once more!");
                            }



                        }
                    }   
                }

                //First CrossRoad near Yolav
                Console.WriteLine();
                char goblinpath = ' ';
                Console.WriteLine("You approach a crossroad with a sign that says left is Dry Rock and Right is Fahal");
                Console.WriteLine("Which way would you like to go");
                Console.WriteLine("Press 1 to go right");
                Console.WriteLine("Press 2 to go left");
                Console.WriteLine("Press 3 to look around");
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
                            Console.Clear();

                            //Battle with first goblin
                            BattleStarted = true;
                            while (health > 0 && goblinHealth > 0)
                            {
                                Console.WriteLine("Players Healt: " + health);
                                Console.WriteLine("Player Armor: " + armor);
                                Console.WriteLine("Player Level: " + level);

                                Console.WriteLine("You have a chance to attack the goblin do you take the chance?");
                                Console.WriteLine("Press 1 for a attack with your starting weapon or Press 2 to try and escape");
                                battle = Console.ReadKey().KeyChar;
                                if (battle == '1')
                                {
                                    if (input == '1')
                                    {
                                        Console.WriteLine("\nYou swing the dagger and deal 15 damage to the goblin");
                                        goblinHealth -= dagger;
                                        Console.WriteLine("The goblin reacts and swings a club at you arm and hits for 5");
                                        health -= health - 5;
                                    }

                                    else if (input == '2')
                                    {
                                        Console.WriteLine("You knock an arrow and let it fly as it pierces the goblins stomach for 20");
                                        goblinHealth -= bow;
                                        Console.WriteLine("The goblin takes the arrow out and charges with it!");
                                        Console.WriteLine("The goblins pierces you in the leg with the arrow and deals 6 damage");
                                        health -= health - 6;
                                    }

                                    else if (input == 3)
                                    {
                                        Console.WriteLine("You reach in your satchel and throw a poison at the goblin");
                                        Console.WriteLine("The poison seeps into the goblin and deals 5 damage this round");

                                    }

                                    else if (input == '4')
                                    {
                                        Console.WriteLine(" You let out your warrior shout as you swing your sword dealing 20 damage");
                                        goblinHealth -= goblinHealth - 20;
                                    }

                                    else if (input == '5')
                                    {
                                        Console.WriteLine("Which spell would you like to cast on the target");
                                        Console.WriteLine("Press 1 for Flame, Press 2 for Icy Wind, Press 3 for Shock spray!");

                                        while (SpellsToCast != '1' && SpellsToCast != '2' && SpellsToCast != '3')
                                        {
                                            Console.Clear();
                                            
                                           

                                            SpellsToCast = Console.ReadKey().KeyChar;
                                            if (SpellsToCast == '1')
                                            {
                                                Console.WriteLine("\nYou chant your magical words and blast the goblin for 10 fire damgae!");
                                                Console.WriteLine("The goblins grabs you while on fire you take 5 fire damage!");
                                                goblinHealth -= goblinHealth - 20;
                                                health -= health - 5;
                                                magicMeter -= magicMeter - 5;
                                            }

                                            else if (SpellsToCast == '2')
                                            {
                                                Console.WriteLine("\nYou chant magical words as a icy wind shoots out at the goblina and deal 5 ice damage");

                                            }

                                            else if (SpellsToCast == '3')
                                            {
                                                Console.WriteLine("You chant more magical words as you hear crackling as the goblin gets shocked by electricity for 15 lightning damage");
                                                Console.WriteLine("The target lost magic and refilled yours by 2!");
                                                goblinHealth -= goblinHealth - 10;
                                                magicMeter += magicMeter + 2;
                                            }

                                            
                                            
                                            else
                                            {
                                                Console.WriteLine("Please make a choice");
                                            }
                                            Console.ReadKey();
                                        }
                                    }
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

                else if (firstcrossroad == '3')
                {
                    Console.WriteLine("A chest is near the crossroad sign under a tree");
                    Console.WriteLine("As you approach you see a word combinstion lock with a note");
                    Console.WriteLine("The note claims: What is the best sound to hear from a person?");
                    Console.WriteLine("Further inspection you see a skull and bones painting on the side with a lockpick painted in the key hole but its broken");
                    Console.WriteLine("Press 1 to try and lockpick it, Press 2 to enter the answer, Press 3 to leave the box for now");
                    int lockedweirdchest = ' ';
                    while (lockedweirdchest != '1' && lockedweirdchest != '2' && lockedweirdchest != '3')
                    {
                        if (lockedweirdchest == '1' && lockpicks > 0)
                        {
                            Console.WriteLine("Oddly enough this chest dont seem to be lockpickable must find the answer to it!");
                        }

                        else if (lockedweirdchest == '2')
                        {
                            Console.WriteLine("Please put in your answer : What is the best sound from a person?");
                           string Weirdchest1 = Console.ReadLine();
                            if (Weirdchest1 == "silence");
                            {
                                Console.WriteLine("The chest clicks loudly and swings opend and a dagger appears inside");
                                Console.WriteLine("If you achieved guessing or if you are with our dysfunctional family please have this dagger");

                            }

                        }
                    }
                }


            }
        }
    }
}
