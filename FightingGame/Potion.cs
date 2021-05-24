using System;

namespace FightingGame
{
    public class Potion : Powerup
    {
        int hpBoost = 0;
        
        public virtual int HpBoost()
        {
            return hpBoost;
        }
    }
}
