using System;
using System.Collections.Generic;

namespace FightingGame
{
    public class Arena
    {

        public void ArenaFight(Player player, List<Enemy> enemyList, int enemyNumber)
        {
            bool FightActive = true;
            while (FightActive == true && enemyNumber < 5)
            {
                //spelare attackerar
                Console.WriteLine(enemyList[enemyNumber].Name + " har " + enemyList[enemyNumber].Hitpoints + " hp!");

                enemyList[enemyNumber].Hurt(player.Attack());

                Console.WriteLine(enemyList[enemyNumber].Name + " har nu" + enemyList[enemyNumber].Hitpoints + " hp!");

                //Spelare blir attackerad
                Console.WriteLine(player + " har " + player.Hitpoints + " hp!");

                player.Hurt(enemyList[enemyNumber].Attack());

                Console.WriteLine(player + " har nu " + player.Hitpoints + " hp!");

                Console.ReadLine();
                // //Rensar konsolen
                // Console.Clear();

            }
        }

        

        public Enemy EnemyType()
        {

            Random generator = new Random();
            //1-3
            int r = generator.Next(1, 3);

            switch (r)
            {
                case 1:
                    return new WeakEnemy();
                case 2:
                    return new StrongEnemy();

                default:

                return new WeakEnemy();
            }
        }
    }
}
