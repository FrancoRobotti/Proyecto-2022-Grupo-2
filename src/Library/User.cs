using System;

namespace NavalBattle
{
    public class User   //Esta clase va a manejar un nickname del usuario y la funcionalidad de MatchMaking
    {
        private string nickName;
        //se crea la clase User, se agrega el atributo de NickName y el metodo MatchMaking
        public Player player {get; set;}

        public User(string aNickName)
        {
            this.nickName = aNickName;
        }

        public void SearchGame(User user1, User user2, int boardSide) 
        {
            Admin.getAdmin().CreateMatch(user1, user2, boardSide);
        }
    }
}