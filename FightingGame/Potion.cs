using System;

namespace FightingGame
{
    public class Potion : Store
    {
        int hpBoost = 0;
        
        public virtual int HpBoost()
        {
            return hpBoost;
        }
    }
}
