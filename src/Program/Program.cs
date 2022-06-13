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

            gameboard.RecieveAttack("32");

            IPrinter printer;
            
            printer =  new DefenseGameboardPrinter();

            printer.PrintGameboard(gameboard);

            printer = new AttackGameboardPrinter();

            printer.PrintGameboard(gameboard);
        }
    }
}
