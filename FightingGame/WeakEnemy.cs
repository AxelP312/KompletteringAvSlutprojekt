using System;
using System.Collections.Generic;

namespace FightingGame
{
    public class WeakEnemy : Enemy

    {
        public WeakEnemy()
        {
            hp = 50;
        }

        public override int Attack()
        {
            //20 dmg
            return base.Attack() * 2;
        }
    }
}
