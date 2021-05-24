using System;
using System.Collections.Generic;

namespace FightingGame
{
    public class Character 
    {
        protected int hp = 50;
        protected int damage = 0;
        protected string name = "";
        protected bool alive = true;

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
            set //Ändra hitpoints
            {
                hp +=(value-hp);
            }
        }

        public void Heal(int amount)
        {
            hp += amount;
        }

        public void Hurt(int amount)
        {
            hp -= amount;
        }
    }
}
