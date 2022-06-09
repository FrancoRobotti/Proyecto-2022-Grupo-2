using System;

namespace Proyecto;
public class Player     //Esta clase va a manejar el usuario y el tablero del jugador
{
    //se crea la clase player  y se agregan lo atributos de User y GameBoard
    private User user;
    private GameBoard gameBoard;
    public Player(User user)
    {
        this.user = user;
        GameBoard gameBoard = new GameBoard();
    }

    public bool Turn
    {
        get
        {
            return this.Turn;
        }
        set
        {
            this.Turn = Turn;
        }
    }

}