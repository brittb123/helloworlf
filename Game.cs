using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            float health = 100.0f;
            float healthRegen = 20;
            Console.Write("What is your name traveler?");
            string name = Console.ReadLine();
            Console.WriteLine("Is this your name?");
            Console.ReadLine();
            bool maxLevelReached = false;
            int maxlevel = 100;
            maxlevel = 120;
            int level = maxlevel;
            bool ready = true;
            Console.WriteLine(health);
            health = health + healthRegen;
         
            Console.Write(name + " has healed " + healthRegen);
            
        
        }
    }
}
