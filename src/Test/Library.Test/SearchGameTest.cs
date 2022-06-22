using NUnit.Framework;

namespace NavalBattle
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //Testea que un jugador pueda buscar partida.
        [Test]
        public void SearchGameTest()
        {
            User user1 = new User("juan1");

            user1.SearchGame(7, false, false);

            Assert.AreEqual("juan1", WaitingList.waitingList[0].NickName);      
        }
    
        //Testea que dos jugadores se puedan emparejar en la misma partida.
        [Test]
        public void MatchmakingTest()
        {
            User user1 = new User("juan1");

            User user2 = new User("juan2");

            user1.SearchGame(7, false, false);

            Assert.IsNull(user1.player);
            
            user2.SearchGame(7, false, false);

            Assert.IsNotNull(user1.player);

            Assert.IsNotNull(user2.player);

            Assert.AreEqual(7, user1.player.Gameboard.Side);

            Assert.AreEqual(7, user2.player.Gameboard.Side);
        } 

        //Testea que se puedan almacenar varias partidas en simultaneo.
        [Test]
        public void MatchListTest()
        {
            User user1 = new User("juan1");

            User user2 = new User("juan2");

            User user3 = new User("juan3");

            User user4 = new User("juan4");

            user1.SearchGame(7, false, false);

            user2.SearchGame(7, false, false);

            user3.SearchGame(6, true, false);
                 
            user4.SearchGame(6, true, false);

            Assert.AreEqual(2, Admin.getAdmin().MatchList.Count);
        }
    }
}