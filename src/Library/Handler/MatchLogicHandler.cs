using System;
using System.Text;
using Telegram.Bot.Types;

namespace NavalBattle
{
    /// <summary>
    /// Un "handler" del patrón Chain of Responsibility que implementa el comando "chau".
    /// </summary>
    public class MatchLogicHandler : BaseHandler
    {
        public MatchLogicState State;

        public MatchLogicData Data;

        public MatchLogicHandler(string[] keywords, BaseHandler next) : base(next)
        {
            this.Keywords = keywords;
            this.State = MatchLogicState.Start;
            this.Next = next;
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
                if (this.State == MatchLogicState.Start)
                {
                    
                }
            }
            
            catch (Exception e)
            {
                Cancel();
                response = e.Message;
                return true;
            }
        }

        public IHandler Handle(Message message, out string response)
        {
            if (this.CanHandle(message))
            {
                this.InternalHandle(message, out response);
                return this;
            }
            else if (this.Next != null)
            {
                return this.Next.Handle(message, out response);
            }
            else
            {
                response = string.Empty;
                return null;
            }
        }

        protected override void InternalCancel()
        {
            this.State = MatchLogicState.Start;
            this.Data = new MatchLogicData();
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

        public enum MatchLogicState
        {
            Start,
            PlayerOneTurn,
            PlayerTwoTurn,
        }

        public class MatchLogicData
        {

        }
    }
}