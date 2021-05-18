using System;

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
            return base.Attack() * 4;
        }
    }
}
