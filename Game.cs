using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            Console.Write("What is your name traveler?");
            string name = Console.ReadLine();
            //This variable is for health
            float health = 100.0f;
            //This value is for how much a player regens
            float healthRegen = 20;
            //Role choices for start!
            Console.WriteLine("Ah so you are " + name + "! What will your class be?");
            Console.WriteLine("Here are your choices:");
            Console.WriteLine("Rogue, Druid, Knight, Wizard, Alchemist");
            string role = Console.ReadLine();

            //Starting and max level values
            bool maxLevelReached = false;
            int maxlevel = 100;
            int level = 1;
            bool ready = true;

            //The player stats, name, and role selected
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Level: " + level);

            
        
        }
    }
}
