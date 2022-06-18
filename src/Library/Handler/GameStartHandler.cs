using System;
using System.Text;
using Telegram.Bot.Types;

namespace NavalBattle
{
    /// <summary>
    /// Un "handler" del patrón Chain of Responsibility que implementa el comando "chau".
    /// </summary>
    public class GameStartHandler : BaseHandler
    {
        public GameStartState State;

        public GameStartData Data;

        public User User;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="GoodByeHandler"/>. Esta clase procesa el mensaje "chau"
        /// y el mensaje "adiós" -un ejemplo de cómo un "handler" puede procesar comandos con sinónimos.
        /// </summary>
        /// <param name="next">El próximo "handler".</param>
        public GameStartHandler(string[] keywords, BaseHandler next) : base(next)
        {
            this.Keywords = keywords;
            this.State = GameStartState.Start;
            this.User = null;
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
                if (this.State == GameStartState.Start)
                {
                    this.User = UserRegister.Instance.GetUserByNickName(message);
                    response = "Vuelva con vida capitán, es una orden.";

                    if (User.Gameboard.BombSwitch && User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 6)
                    {
                        WaitingList.BombsDoubleAttackSize6.Add(User);
                        this.State = GameStartState.BombsDoubleAttackSize6;
                        return true;
                    }
                    else if (User.Gameboard.BombSwitch && User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 7)
                    {
                        WaitingList.BombsDoubleAttackSize7.Add(User);
                        this.State = GameStartState.BombsDoubleAttackSize7;
                        return true;
                    }
                    else if (User.Gameboard.BombSwitch && User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 8)
                    {
                        WaitingList.BombsDoubleAttackSize8.Add(User);
                        this.State = GameStartState.BombsDoubleAttackSize8;
                        return true;
                    }
                    else if (!User.Gameboard.BombSwitch && User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 6)
                    {
                        WaitingList.NoBombsDoubleAttackSize6.Add(User);
                        this.State = GameStartState.NoBombsDoubleAttackSize6;
                        return true;
                    }
                    else if (!User.Gameboard.BombSwitch && User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 7)
                    {
                        WaitingList.NoBombsDoubleAttackSize7.Add(User);
                        this.State = GameStartState.NoBombsDoubleAttackSize7;
                        return true;
                    }
                    else if (!User.Gameboard.BombSwitch && User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 8)
                    {
                        WaitingList.NoBombsDoubleAttackSize8.Add(User);
                        this.State = GameStartState.NoBombsDoubleAttackSize8;
                        return true;
                    }
                    else if (User.Gameboard.BombSwitch && !User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 6)
                    {
                        WaitingList.BombsNoDoubleAttackSize6.Add(User);
                        this.State = GameStartState.BombsNoDoubleAttackSize6;
                        return true;
                    }
                    else if (User.Gameboard.BombSwitch && !User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 7)
                    {
                        WaitingList.BombsNoDoubleAttackSize7.Add(User);
                        this.State = GameStartState.BombsNoDoubleAttackSize7;
                        return true;
                    }
                    else if (User.Gameboard.BombSwitch && !User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 8)
                    {
                        WaitingList.BombsNoDoubleAttackSize8.Add(User);
                        this.State = GameStartState.BombsNoDoubleAttackSize8;
                        return true;
                    }
                    else if (!User.Gameboard.BombSwitch && !User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 6)
                    {
                        WaitingList.NoBombsNoDoubleAttackSize6.Add(User);
                        this.State = GameStartState.NoBombsNoDoubleAttackSize6;
                        return true;
                    }
                    else if (!User.Gameboard.BombSwitch && !User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 7)
                    {
                        WaitingList.NoBombsNoDoubleAttackSize7.Add(User);
                        this.State = GameStartState.NoBombsNoDoubleAttackSize7;
                        return true;
                    }
                    else if (!User.Gameboard.BombSwitch && !User.Gameboard.DoubleAttackSwitch && User.Gameboard.Side == 8)
                    {
                        WaitingList.NoBombsNoDoubleAttackSize8.Add(User);
                        this.State = GameStartState.NoBombsNoDoubleAttackSize8;
                        return true;
                    }
                    else if (this.State == GameStartState.BombsDoubleAttackSize6 && WaitingList.BombsDoubleAttackSize6.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.BombsDoubleAttackSize6[0], WaitingList.BombsDoubleAttackSize6[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.BombsDoubleAttackSize6.Remove(WaitingList.BombsDoubleAttackSize6[0]);
                        }
                        response = "";
                        return true;
                    }
                    else if (this.State == GameStartState.BombsDoubleAttackSize7 && WaitingList.BombsDoubleAttackSize7.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.BombsDoubleAttackSize7[0], WaitingList.BombsDoubleAttackSize7[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.BombsDoubleAttackSize7.Remove(WaitingList.BombsDoubleAttackSize7[0]);
                        }
                        response = "";
                        return true;
                    }
                    else if (this.State == GameStartState.BombsDoubleAttackSize8 && WaitingList.BombsDoubleAttackSize8.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.BombsDoubleAttackSize8[0], WaitingList.BombsDoubleAttackSize8[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.BombsDoubleAttackSize8.Remove(WaitingList.BombsDoubleAttackSize8[0]);
                        }
                        response = "";
                        return true;
                    }
                    else if (this.State == GameStartState.NoBombsDoubleAttackSize6 && WaitingList.NoBombsDoubleAttackSize6.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.NoBombsDoubleAttackSize6[0], WaitingList.NoBombsDoubleAttackSize6[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.NoBombsDoubleAttackSize6.Remove(WaitingList.NoBombsDoubleAttackSize6[0]);
                        }
                        response = "";
                        return true;
                    }
                    else if (this.State == GameStartState.NoBombsDoubleAttackSize7 && WaitingList.NoBombsDoubleAttackSize7.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.NoBombsDoubleAttackSize7[0], WaitingList.NoBombsDoubleAttackSize7[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.NoBombsDoubleAttackSize7.Remove(WaitingList.NoBombsDoubleAttackSize7[0]);
                        }
                        response = "";
                        return true;
                    }
                    else if (this.State == GameStartState.NoBombsDoubleAttackSize8 && WaitingList.NoBombsDoubleAttackSize8.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.NoBombsDoubleAttackSize8[0], WaitingList.NoBombsDoubleAttackSize8[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.NoBombsDoubleAttackSize8.Remove(WaitingList.NoBombsDoubleAttackSize8[0]);
                        }
                        response = "";
                        return true;
                    }
                    else if (this.State == GameStartState.BombsNoDoubleAttackSize6 && WaitingList.BombsNoDoubleAttackSize6.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.BombsNoDoubleAttackSize6[0], WaitingList.BombsNoDoubleAttackSize6[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.BombsNoDoubleAttackSize6.Remove(WaitingList.BombsNoDoubleAttackSize6[0]);
                        }
                        response = "";
                        return true;
                    }
                    else if (this.State == GameStartState.BombsNoDoubleAttackSize7 && WaitingList.BombsNoDoubleAttackSize7.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.BombsNoDoubleAttackSize7[0], WaitingList.BombsNoDoubleAttackSize7[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.BombsNoDoubleAttackSize7.Remove(WaitingList.BombsNoDoubleAttackSize7[0]);
                        }
                        response = "";
                        return true;
                    }
                    else if (this.State == GameStartState.BombsNoDoubleAttackSize8 && WaitingList.BombsNoDoubleAttackSize8.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.BombsNoDoubleAttackSize8[0], WaitingList.BombsNoDoubleAttackSize8[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.BombsNoDoubleAttackSize8.Remove(WaitingList.BombsNoDoubleAttackSize8[0]);
                        }
                        response = "";
                        return true;
                    }
                    else if (this.State == GameStartState.NoBombsNoDoubleAttackSize6 && WaitingList.NoBombsNoDoubleAttackSize6.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.NoBombsNoDoubleAttackSize6[0], WaitingList.NoBombsNoDoubleAttackSize6[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.NoBombsNoDoubleAttackSize6.Remove(WaitingList.NoBombsNoDoubleAttackSize6[0]);
                        }
                        response = "";
                        return true;
                    }
                    else if (this.State == GameStartState.NoBombsNoDoubleAttackSize7 && WaitingList.NoBombsNoDoubleAttackSize7.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.NoBombsNoDoubleAttackSize7[0], WaitingList.NoBombsNoDoubleAttackSize7[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.NoBombsNoDoubleAttackSize7.Remove(WaitingList.NoBombsNoDoubleAttackSize7[0]);
                        }
                        response = "";
                        return true;
                    }
                    else if (this.State == GameStartState.NoBombsNoDoubleAttackSize8 && WaitingList.NoBombsNoDoubleAttackSize8.Count > 1)
                    {
                        Admin.MatchPlayers(WaitingList.NoBombsNoDoubleAttackSize8[0], WaitingList.NoBombsNoDoubleAttackSize8[1]);
                        for (int i = 0; i < 1; i++)
                        {
                            WaitingList.NoBombsNoDoubleAttackSize8.Remove(WaitingList.NoBombsNoDoubleAttackSize8[0]);
                        }
                        response = "";
                        return true;
                    }
                }
                response = "";
                return false;
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
            this.State = GameStartState.Start;
            this.Data = new GameStartData();
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

        public enum GameStartState
        {
            Start,
            NoBombsNoDoubleAttackSize6,
            NoBombsNoDoubleAttackSize7,
            NoBombsNoDoubleAttackSize8,
            NoBombsDoubleAttackSize6,
            NoBombsDoubleAttackSize7,
            NoBombsDoubleAttackSize8,
            BombsNoDoubleAttackSize6,
            BombsNoDoubleAttackSize7,
            BombsNoDoubleAttackSize8,
            BombsDoubleAttackSize6,
            BombsDoubleAttackSize7,
            BombsDoubleAttackSize8,
        }

        public class GameStartData
        {
            public string NickName { get; set; }
        }
    }
}