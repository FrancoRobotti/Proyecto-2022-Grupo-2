namespace Proyecto
{
    public class Match
    {
        Player Player1;

        Player Player2;

        public Match(Player player1, Player player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
        }

        public void PlaceShip()
        {
            if (player1.Turn())
            {
                foreach (Ship ship in this.player1.Gameboard)
                {
                    this.matchLogic.PlaceShip();
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

        public void Surrender(Player player)
        {
            this.matchLogic.Surrender(player);
        }

    }
}