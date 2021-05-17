using System;

namespace FightingGame
{
    public class Character
    {
        int hp;
        int damage;

        public int Attack()
        {
            return damage;
        }

        public int Hitpoints
        {
            get // cw(hitpoints) skriver ut hp
            {
                return hp;
            }
            set // hitpoints = Skadan från attack sänker hp
            {
                hp -= Math.Max(value, 0);
            }
        }
    }
}
