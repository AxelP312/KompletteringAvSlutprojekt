using System;

namespace FightingGame
{
    public class SmallPotion : Potion
    {
        public SmallPotion()
        {
            name = "Small Potion";
        }
        public override int HpBoost()
        {
            //25 hp
            return 25;
        }
    }
}
