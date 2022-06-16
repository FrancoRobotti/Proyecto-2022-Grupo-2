using System;

namespace NavalBattle
{
    public class Player   //Esta clase va a manejar el usuario y el tablero del jugador
    {
        //se crea la clase player  y se agregan lo atributos de User y GameBoard
       
        private Gameboard gameboard;

        public Player(int gameboardSide)
        {
            Gameboard gameboard = new Gameboard(gameboardSide);
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