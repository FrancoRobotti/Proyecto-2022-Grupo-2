using System;

namespace NavalBattle
{
    public class Player   //Esta clase va a manejar el usuario y el tablero del jugador
    {
        //se crea la clase player  y se agregan lo atributos de User y GameBoard
       
        private Gameboard gameboard;
        private bool turn;
        public Player(int gameboardSide)
        {
            Gameboard gameboard = new Gameboard(gameboardSide);
            this.turn = false;
        }

        public void AttckPlayer(string coordStr)
        {
            if (this.turn == true)
            {
                Coords coord = new Coords(coordStr);
                //MatchLogic.Attack(coord);
                this.turn = false;
            }
            else
            {
                Console.WriteLine("Espere su turno");
            }
        }
        public bool Turn
        {
            get
            {
                return this.turn;
            }
            set
            {
                this.turn = value;
            }
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