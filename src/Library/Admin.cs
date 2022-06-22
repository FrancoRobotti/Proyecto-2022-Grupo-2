using System.Collections.Generic;


namespace NavalBattle
{
    public class Admin
    {
        List<Match> matchList = new List<Match>();

        public List<Match> MatchList
        {
            get
            {
                return matchList;
            }
        }

        List<string> usersRegister = new List<string>();

    
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
    
        public void AddToWaitingList(User user)
        {     
            if (WaitingList.waitingList.Count > 0)
            {
                int i = 0;
                while(i< WaitingList.waitingList.Count &&  WaitingList.waitingList[i].GameboardSide != user.GameboardSide && WaitingList.waitingList[i].Bombs != user.Bombs && WaitingList.waitingList[i].DoubleAttack != user.DoubleAttack)
                {
                    i++;
                }
                if (i < WaitingList.waitingList.Count)
                {
                    CreateMatch(user, WaitingList.waitingList[i]);
                    WaitingList.waitingList.Remove(user);
                    WaitingList.waitingList.Remove(WaitingList.waitingList[i]);
                }
                else
                {
                    WaitingList.waitingList.Add(user);
                }
            }
            else
            {
                WaitingList.waitingList.Add(user);
            }
        }
        
        public void CreateMatch(User user1, User user2)
        {
            Match match = new Match(user1, user2);

            matchList.Add(match);
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