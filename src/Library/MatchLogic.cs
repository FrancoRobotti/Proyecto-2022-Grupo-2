using System;
using System.Collections.Generic;

namespace NavalBattle
{
    public class MatchLogic 
    {
        Match match;

        public MatchLogic(Match match)
        {
            this.match = match;
        }
        public void Attack(Coords coord)
        {   
            if (match.Turn == true)
            {   
                string res = match.players[1].Gameboard.RecieveAttack(coord);
                //match.players[0].Turn = false;
            }
            else
            {
                string res = match.players[0].Gameboard.RecieveAttack(coord);
                //match.players[1].Turn = false;
            }
        }
    
       /*
        public static void PlaceShip(string initialCoordsString, string direction)
        {
            //Coords initialCoords = new Coords(initialCoordsString);
            for (int i = 2; i < 4; i++)
            {
                if (i <= 4 || match.players[0].Turn)
                {
                    match.players[0].Gameboard.addShip(i, initialCoordsString, direction);

                    match.players[0].Turn = false;
                    match.players[1].Turn = true;
                }
                else if (i <= 4 || match.players[1].Turn)
                {
                    match.players[1].Gameboard.addShip(i, initialCoordsString, direction);

                    match.players[1].Turn = false;
                    match.players[0].Turn = true;
                }
            }
        }*/
        /*
        public void Surrender(Player player)
        {
            foreach (Ship ship in player.Gameboard.Ships)
            {
                ship.ShipState = Ship.State.Sunk;
            }
        }
        */
    }
}