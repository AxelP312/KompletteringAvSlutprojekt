using System;
using System.Collections.Generic;

namespace FightingGame
{
    public class Player : Character
    {
        public Player()
        {
            damage = 10;
            hp = 10000;
            name = "ok";
        }

        public override int Attack()
        {
            Console.WriteLine("What attack will you do?\n(Write the corresponding number)");
            System.Console.WriteLine("[1] Light attack\n[2] Heavy attack\n[3] Kick");
            string svar = playerInput(Console.ReadLine());
            if (svar == "1")
            {
                //20 dmg
                Console.WriteLine("You dealt 20 dmg");
                return base.Attack() * 2;

            }
            else if (svar == "2")
            {
                //30 dmg
                Console.WriteLine("You dealt 30 dmg");
                return base.Attack() * 3;
            }
            else if (svar == "3")
            {
                //40 dmg
                
                Console.WriteLine("You dealt 40 dmg");
                return base.Attack() * 4;
            }
            else
            { return 0; }
        }

        private string playerInput(string svar)
        {
            bool key = true;
            while (key == true)
            {
                if (svar == "1" || svar == "2" || svar == "3")
                {
                    key = false;
                }
                else
                {
                    System.Console.WriteLine("Write [1], [2] or [3]");
                    svar = Console.ReadLine();
                }
            }
            return svar;

        }

    }
}
