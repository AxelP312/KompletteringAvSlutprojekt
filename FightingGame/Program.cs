using System;

namespace FightingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Skriver ut weakenemys attack
            // WeakEnemy weakEnemy = new WeakEnemy();
            // Console.WriteLine(weakEnemy.Attack());
            
            // //Skriver ut Strongenemy attack
            // StrongEnemy strongEnemy = new StrongEnemy();
            // Console.WriteLine(strongEnemy.Attack());

            // //Testar om name fungerar
            // Enemy enemy = new Enemy();
            // Console.WriteLine(enemy.Name);

            // Player player = new Player();
            // //attacker fungerar
            // Console.WriteLine(player.Attack());

            Arena arena = new Arena();



            Console.ReadLine();
        }
    }
}
