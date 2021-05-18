using System;

namespace FightingGame
{
    public class Enemy : Character
    {
        public Enemy()
        {
            name = RandomizeName();
            damage = 10;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        
        protected string RandomizeName()
        {
            Random generator = new Random();

            int r = generator.Next(9);
            string[] nameArray = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            string name = nameArray[r];

            return name;
        }
    }
}
