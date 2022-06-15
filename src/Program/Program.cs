using System;

namespace NavalBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Gameboard gameboard = new Gameboard(5);

            gameboard.addShip(3, "00", "S");

            gameboard.addShip(4, "34", "W");

            gameboard.addShip(2, "40", "E");

            Coords coord1 = new Coords("41");
            
            Coords coord2 = new Coords("12");


            gameboard.RecieveAttack(coord1);

            gameboard.RecieveAttack(coord2);

            gameboard.RecieveAttack(coord2);


            IPrinter printer;
            
            printer =  new DefenseGameboardPrinter();

            printer.PrintGameboard(gameboard);

            printer = new AttackGameboardPrinter();

            printer.PrintGameboard(gameboard); 
        }
    }
}
