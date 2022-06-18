using Telegram.Bot.Types;
using System.Text;
using System;


namespace NavalBattle
{
    /// <summary>
    /// Un "handler" del patrón Chain of Responsibility que implementa el comando "chau".
    /// </summary>
    public class GameboardSizeHandler : BaseHandler
    {
        public GameboardSizeState State;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="GoodByeHandler"/>. Esta clase procesa el mensaje "chau"
        /// y el mensaje "adiós" -un ejemplo de cómo un "handler" puede procesar comandos con sinónimos.
        /// </summary>
        /// <param name="next">El próximo "handler".</param>
        public GameboardSizeHandler(BaseHandler next) : base(next)
        {
            this.Keywords = Keywords;
            this.State = GameboardSizeState.Start;
        }

        /// <summary>
        /// Procesa el mensaje "chau" y retorna true; retorna false en caso contrario.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado.</param>
        /// <returns>true si el mensaje fue procesado; false en caso contrario.</returns>
        protected override bool InternalHandle(Message message, out string response)
        {
            try
            {
                if (this.CanHandle(message))
                {
                    StringBuilder gameboardSizeResponse = new StringBuilder ("-> 6 \n -> 7 \n -> 8");
                    if (message.Text.Contains("6") && message.Text.Length == 1)
                    {
                        gameboardSizeResponse.Append("Tablero cambiado a 6");
                        int gameboardsize = (int)Char.GetNumericValue(Convert.ToChar(message));
                        response = gameboardSizeResponse.ToString();
                        return true;
                    }
                    else if (message.Text.Contains("7") && message.Text.Length == 1)
                    {
                        gameboardSizeResponse.Append("Tablero cambiado a 7");
                        int gameboardsize = (int)Char.GetNumericValue(Convert.ToChar(message));
                        response = gameboardSizeResponse.ToString();
                        return true;
                    }
                    else if (message.Text.Contains("8") && message.Text.Length == 1)
                    {
                        gameboardSizeResponse.Append("Tablero cambiado a 8");
                        int gameboardsize = (int)Char.GetNumericValue(Convert.ToChar(message));
                        response = gameboardSizeResponse.ToString();
                        return true;
                    }
                }
            }
            catch(Exception e)
            {
                this.Cancel();
                response = e.Message;
                return true;
            }
        }

        protected override void InternalCancel()
        {
            this.State = GameboardSizeState.Start;
        }

        /// <summary>
        /// Retorna este "handler" al estado inicial. En los "handler" sin estado no hace nada. Los "handlers" que
        /// procesan varios mensajes cambiando de estado entre mensajes deben sobreescribir este método para volver al
        /// estado inicial.
        /// </summary>
        public override void Cancel()
        {
            this.InternalCancel();
            if (this.Next != null)
            {
                this.Next.Cancel();
            }
        }

        public enum GameboardSizeState
        {
            Start,

        }
    }
}