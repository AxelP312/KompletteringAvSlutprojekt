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
                //stats
                Console.WriteLine("Player hp: " + player.Hitpoints);
                Console.WriteLine(enemyList[enemyNumber].Name + " hitpoints: " + enemyList[enemyNumber].Hitpoints);

                //spelare attackerar

                enemyList[enemyNumber].Hurt(player.Attack());


                //Spelare blir attackerad

                player.Hurt(enemyList[enemyNumber].Attack());

                Console.WriteLine("Next round! (Press enter)");
                Console.ReadLine();
                Console.Clear();

                if(enemyList[enemyNumber].Hitpoints < 0)
                {
                    enemyNumber++;
                }
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
