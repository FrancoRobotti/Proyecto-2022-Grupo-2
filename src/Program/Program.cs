using System;

namespace NavalBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User user1 = new User("juan1");

            User user2 = new User("juan2");

            //User user3 = new User("juan3");

            //User user4 = new User("juan4");

            user1.SearchGame(7, false, false);

            
            user2.SearchGame(7, false, false);

            //user3.SearchGame(6, true, false);

            //user4.SearchGame(6, true, false);


            Console.WriteLine(Admin.getAdmin().MatchList.Count);
            
            Console.WriteLine(user1.player.Gameboard.Side);

            /*
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
            */
        }
    }
}
