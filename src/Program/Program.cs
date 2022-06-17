using System;

namespace NavalBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Admin admin = new Admin();

            //User user1 = new User("pj1");

            //User user2 = new User("pj2");

            //user1.SearchGame(user1, user2, 6);

            //user1.player.Attack("03");

            //Match match = admin.GetMatch(12);

            
            Gameboard gameboard = new Gameboard(5);

            gameboard.addShip(3, "00", "S");

            gameboard.addShip(4, "34", "W");

            gameboard.addShip(2, "40", "E");

            gameboard.AddBomb("22");

            gameboard.AddBomb("32");

            Coords coord1 = new Coords("22");
            
            //Coords coord2 = new Coords("32");


            gameboard.RecieveAttack(coord1);

            //gameboard.RecieveAttack(coord2);

            //gameboard.RecieveAttack(coord2);


            IPrinter printer;
            
            printer =  new DefenseGameboardPrinter();

            printer.PrintGameboard(gameboard);

            printer = new AttackGameboardPrinter();

            printer.PrintGameboard(gameboard); 
            
        }
    }
}
