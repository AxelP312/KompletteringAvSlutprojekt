using System;
using System.Collections.Generic;

namespace FightingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapar arena
            Arena arena = new Arena();

            //Skapar spelare
            Player player = new Player();

            //Skapar lista med motståndare
            List<Enemy> enemyList = new List<Enemy>();

            //lägger till motståndare till listan, 5x motståndare, Lägg till i en arena metod istället?
            for (int z = 0; z < 5; z++)
            {
                enemyList.Add(arena.EnemyType());
                Console.WriteLine("Motståndare har hp: " + enemyList[z].Hitpoints);
            }

            Console.WriteLine("Startar arenan!");
            arena.ArenaFight(player, enemyList, 0);



            Console.ReadLine();
        }
    }
}
