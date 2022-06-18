namespace NavalBattle
{
    public class Match
    {
        protected internal User[] users = new User[2];

        public void AddPlayers(User user1, User user2)
        {
            users[0] = user1;
            users[1] = user2;
        }
    }
}