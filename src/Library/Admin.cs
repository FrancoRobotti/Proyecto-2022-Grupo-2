using System.Collections.Generic;


namespace NavalBattle
{
    public class Admin
    {
        List<Match> matchList = new List<Match>();

        List<string> usersRegister = new List<string>();

        //List<User> matchmaking = new List<User>();

        /// <summary>
        /// Ser utiliza singleton para admin.
        /// </summary>
        static private Admin admin = null;

        private Admin() { }
        static public Admin getAdmin() 
        {
            if (admin == null)
            {
                admin = new Admin();
            }
            return admin;
        }

        public void UserRegister(string nickname)
        {
            usersRegister.Add(nickname);
        }
    
        public void CreateMatch(User user1, User user2, int gameboardSide)
        {
            Match match = new Match(user1, user2, gameboardSide); 
            MatchLogic matchLogic = new MatchLogic(match);
            this.matchList.Add(match);
            
            Console.WriteLine("Partida creada correctamente");
        }
    

        public void AttackInfo()
        {
          
        }

        //Una vez que todos los barcos de un jugador han sido hundidos, finaliza el juego.
        public void EndGame()
        {
          
        }
    }
}