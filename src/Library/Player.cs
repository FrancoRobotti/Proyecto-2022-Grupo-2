namespace Proyecto;
public class Player     //Esta clase va a manejar el usuario y el tablero del jugador
{
    //se crea la clase player  y se agregan lo atributos de User y GameBoard
    private User user {get; set;}
    private GameBoard gameBoard {get; set;}


    public User()
    {
        this.user = user;
    }


    public string Player
    {
        get
        {
            return this.player;
        }
        private set
        {
            this.player = Player != null ? Player : value;
        }
    }
}