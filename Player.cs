using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerFile
{
    public class Player
    {
        private int health;

        public Player(int health)
        {
            Health = health;
        }
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 100)
                {
                    value = 100;
                }
                else
                    health = value;

            }
        }
        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health == 0)
            {
                Console.WriteLine("Player takes " + amount + " damage.");
                Console.WriteLine("Player Defeated");
            }
            else
            {
                Console.WriteLine("Player takes " + amount + " damage.");
            }
        }
        public void Heal(int amount)
        {
            if (Health == 100)
            { 
                Console.WriteLine("Player is already healed");
            }
            else
            {
                Health += amount;
                Console.WriteLine("Player heals " + amount);
            }
        }
    }
}
