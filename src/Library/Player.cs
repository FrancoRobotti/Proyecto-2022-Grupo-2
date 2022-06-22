using System;

namespace NavalBattle
{
    public class Player   //Esta clase va a manejar el usuario y el tablero del jugador
    {  
        private Gameboard gameboard;

        public Player(int gameboardSide)
        {
            this.gameboard = new Gameboard(gameboardSide);
        }

        public Gameboard Gameboard
        {
            get
            {
                return this.gameboard;
            }   
        }
    }
}