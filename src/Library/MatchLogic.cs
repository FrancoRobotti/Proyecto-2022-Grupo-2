using System.Collections.Generic;

namespace NavalBattle
{
    public class MatchLogic : Match
    {
        public void Attack(Coords coords)
        {
            if (!coords.HasBeenAttacked)
            {
                coords.HasBeenAttacked = true;
            }
        }

        public void PlaceShip(string initialCoords, string direction)
        {
            for (int i = 2; i < 4; i++)
            {
                if (i <= 4 || players[0].Turn)
                {
                    players[0].Gameboard.addShip(i, direction, initialCoords);

                    players[0].Turn = false;
                    players[1].Turn = true;
                }
                else if (i <= 4 || players[1].Turn)
                {
                    players[1].Gameboard.addShip(i, direction, initialCoords);

                    players[1].Turn = false;
                    players[0].Turn = true;
                }
            }
        }

        public void Surrender(Player player)
        {
            foreach (Ship ship in player.Gameboard.Ships)
            {
                ship.ShipState = Ship.State.Sunk;
            }
        }
    }
}