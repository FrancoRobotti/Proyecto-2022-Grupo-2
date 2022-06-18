using System.Collections.Generic;

namespace NavalBattle
{
    public static class Admin
    {
        private static List<Match> matchList = new List<Match>();

        private static void StartMatch(Match match)
        {
            matchList.Add(match);
        }

        public static void MatchPlayers(User user1, User user2)
        {
            Match match = new Match();
            match.AddPlayers(user1, user2);
            StartMatch(match);
        }

        //Una vez que todos los barcos de un jugador han sido hundidos, finaliza el juego.
        public static bool EndGame(Player[] players)
        {
            foreach (Player player in players)
            {
                foreach (Ship ship in player.Gameboard.Ships)
                {
                    if (ship.ShipState == Ship.State.Sunk)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
    }
}