namespace Proyecto
{
    public class MatchLogic
    {
        Match match = new Match();

        public void Surrender(Player player)
        {
            
        }

        public void Attack(Coords coords)
        {
            
        }

        public void PlaceShip(initialCoords, direction, length)
        {
            if (player1.Turn())
            {
                foreach (Ship ship in this.player1.Gameboard)
                {
                    match.Player1.Gameboard.PlaceShip();
                }
                player1.Turn() = false;
                player2.Turn() = true;
            }
            else
            {
                foreach (Ship ship in this.player2.Gameboard)
                {
                    this.matchLogic.PlaceShip();
                }
                player2.Turn() = false;
                Player1.Turn() = true;
            }
        }

        public void Update()
        {
            
        }
    }
}