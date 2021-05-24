using System.Drawing;
using System;

namespace FightingGame
{
    public class BigPotion : Potion
    {
        
        public BigPotion()
        {
            name = "Big Potion";
        }
        
        public override int HpBoost()
        {
            //50 hp
            return 50;
        }
    }
}
