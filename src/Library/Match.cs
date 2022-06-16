namespace NavalBattle
{
    public class Match
    { 
        protected internal Player[] players = new Player[2];

        private bool turn = true;

        public bool Turn
        {
            get
            {
                return turn;
            }

            set
            {
                turn = value;
            }
        }
        private int id;

        public int Id
        {
            get
            {
                return id;
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
        }
    }
}

