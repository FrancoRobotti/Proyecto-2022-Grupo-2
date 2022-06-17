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

            //gameboard.AddBombs();

            Coords coord1 = new Coords("22");
            
            Coords coord2 = new Coords("00");

            Coords coord3 = new Coords("01");

            Coords coord4 = new Coords("43");

            Coords coord5 = new Coords("24");

            Coords coord6 = new Coords("14");


            gameboard.RecieveAttack(coord1);

            gameboard.RecieveAttack(coord2);

            //gameboard.RecieveAttack(coord3);

            //gameboard.RecieveAttack(coord4);

            //gameboard.RecieveAttack(coord5);

            //gameboard.RecieveAttack(coord6);
          

            IPrinter printer;
            
            printer =  new DefenseGameboardPrinter();

            printer.PrintGameboard(gameboard);

            printer = new AttackGameboardPrinter();

            printer.PrintGameboard(gameboard); 
            
        }
    }
}
