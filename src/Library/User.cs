using System;

namespace NavalBattle
{
    public class User   //Esta clase va a manejar un nickname del usuario y la funcionalidad de MatchMaking
    {
        private bool bombs;

        public bool Bombs
        {
            get
            {
                return bombs;
            }
        }

        private bool doubleAttack;

        public bool DoubleAttack
        {
            get
            {
                return doubleAttack;
            }
        }
        private int gameboardSide;

        public int GameboardSide
        {
            get
            {
                return gameboardSide;
            }
        }
        private string nickName;
        
        public string NickName
        {
            get
            {
                return nickName;
            }
        }
        public Player player {get; set;}

        public User(string aNickName)
        {
            this.nickName = aNickName;
        }

        public void SearchGame(int gameboardSide, bool bombs, bool doubleAttack) 
        {
            this.gameboardSide = gameboardSide;

            this.bombs = bombs;

            this.doubleAttack = doubleAttack;

            Admin.getAdmin().AddToWaitingList(this);
        }
    }
}