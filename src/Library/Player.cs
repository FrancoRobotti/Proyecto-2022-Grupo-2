namespace Proyecto;
public class Player     //Esta clase va a manejar el usuario y el tablero del jugador
{
    //se crea la clase player  y se agregan lo atributos de User y GameBoard
    public User user {get; set;}
    private GameBoard gameBoard {get; set;}

    public Player(User user, GameBoard gameBoard)
    {
        this.user = user;
        this.gameBoard = gameBoard;
    }
}