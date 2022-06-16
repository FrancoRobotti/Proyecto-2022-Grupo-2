namespace NavalBattle
{
    public class Match
    {
        
        protected internal Player[] players = new Player[2];

        protected bool matchEnded;

        private int id;

        public int Id
        {
            get
            {
                return id;
            }
        }
        
        public bool MatchEnded
        {
            get
            {
                return matchEnded;
            }
        }

        public Match(User user1, User user2, int gameboardSide)
        { 
            Player player1 = new Player(gameboardSide);
            Player player2 = new Player(gameboardSide);

            user1.player = player1;
            user2.player = player2;

            players[0] = player1;
            players[1] = player2;

            matchEnded = false;
        }

    }
}