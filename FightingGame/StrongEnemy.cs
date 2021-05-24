using System;
using System.Collections.Generic;

namespace FightingGame
{
    public class StrongEnemy : Enemy
    {
        public StrongEnemy()
        {
            hp = 150;
        }

        public override int Attack()
        {
            //40 dmg
            
            Console.WriteLine("Enemy dealt 40 dmg");
            return base.Attack() * 4;
        }
    }
}
