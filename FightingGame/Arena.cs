using System;
using System.Collections.Generic;

namespace FightingGame
{
    public class Arena
    {

        //För mycket metoder kopplade till instansen, lös det.

        public Arena()
        {
            //Skapar spelare
            Player player = new Player();
            
            //Skapar lista med motståndare
            List<Enemy> enemyList = new List<Enemy>();

            //lägger till motståndare till listan, 5x motståndare
            for (int z = 0; z < 5; z++)
            {
                enemyList.Add(EnemyType());
            }

        }

        public void ArenaFight(Player player, List<Enemy> enemyList, int enemyNumber)
        {
            bool FightActive = true;
            while (FightActive && enemyNumber < 5)
            {
                Console.WriteLine("Enemy hp: " + enemyList[enemyNumber].Hitpoints);
                enemyList[enemyNumber].Hitpoints -= player.Attack();

                Console.WriteLine("player hp: " + player.Hitpoints);
                player.Hitpoints -= enemyList[enemyNumber].Attack();

                //Rensar konsolen
                Console.Clear();

            }
        }


        private Enemy EnemyType()
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
