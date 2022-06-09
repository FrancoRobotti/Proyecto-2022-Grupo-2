using System.Collections.Generic;

namespace Proyecto
{
    public class Admin
    {
        List<Match> matchList = new List<Match>();

        public void UserRegister(string nickname)
        {

        }

        public void MatchPlayers(User user1, User user2)
        {
            Player player1 = new Player(user1)
            Player player2 = new Player(user2);
            Match match = new Match(player1, player2);
            this.matchList.Add(match);
        }


        public string AttackInfo()
        {
            foreach (player.Attack)
            {
                
            }
        }

        //Una vez que todos los barcos de un jugador han sido hundidos, finaliza el juego.
        public bool EndGame()
        {
            foreach (player x in Match)
            {
                foreach (Ship y in player.gameboard.ship)
                {
                    if (y.Sunk)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}