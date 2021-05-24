using System;
using System.Collections.Generic;

namespace FightingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Powerup store = new Powerup();
            
            //skapar arena
            Arena arena = new Arena();

            //Skapar spelare
            Player player = new Player();

            //Skapar lista med motståndare
            List<Enemy> enemyList = new List<Enemy>();

            //Skapar bigPotion
            BigPotion bigPotion = new BigPotion();
            
            //Skapar SmallPotion
            SmallPotion smallPotion = new SmallPotion();

            player.Hitpoints += smallPotion.HpBoost();
            player.Hitpoints += bigPotion.HpBoost();

            //lägger till motståndare till listan, 5x motståndare, Lägg till i en arena metod istället?
            for (int z = 0; z < 5; z++)
            {
                enemyList.Add(arena.EnemyType());
            }
            
            arena.ArenaFight(player, enemyList, 0);

            Console.WriteLine("You won!");
            
            Console.ReadLine();
        }
    }
}
