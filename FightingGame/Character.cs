using System;
using System.Collections.Generic;

namespace FightingGame
{
    public class Character : Arena
    {
        protected int hp = 50;
        protected int damage = 0;
        protected string name = "";

        public virtual int Attack()
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

        public void Hurt(int amount)
        {
            hp -= amount;
        }
    }
}
