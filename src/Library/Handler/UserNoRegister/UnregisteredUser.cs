using System;
using System.Collections.Generic;
using System.Text;

namespace NavalBattle
{
    /// <summary>
    /// Un handler del patrón Chain Of Responsability que implementa el comando "/emprendedornoregistrado".
    /// Handler encargado de crear un usuario emprendedor.
    /// </summary>
    public class UnregisteredUserHandler : AbstractHandler
    {   

        public UnregisteredUserState State { get; set; }

        public UnregisteredUserData Data{ get; set; }
        public UnregisteredUserHandler()
        {
            this.Command = "/UsuarioNoRegistrado";
            this.State = UnregisteredUserState.Start;
            this.Data = new UnregisteredUserData();
        }

        public override bool InternalHandle(IMessage input, out string response)
        {
            try
            {
                if ((this.State == UnregisteredUserState.Start) && (CanHandle(input)))
                {
                    StringBuilder datos = new StringBuilder("Bienvendido nuevo Jugador!\n")
                                                    .Append("Para poder registrarte vamos a necesitar que ingreses un apodo.\n");
                    this.State = UnregisteredUserState.NickName;
                    response = datos.ToString();
                    return true;
                }

                else if (this.State == UnregisteredUserState.NickName)
                {
                    this.State = UnregisteredUserState.Start;
                    UserRegister.Instance.CreateUser(input.Id,this.Data.NickName);
                    response = "Muchas gracias, su usuario ha sido creado\n";
                    return true;

                }
                response = "";
                return false;
            }
            catch(Exception e)
            {
                response = e.Message;
                return true;
            }
        }
        protected override void InternalCancel()
        {
            this.State = UnregisteredUserState.Start;
            this.Data = new UnregisteredUserData();
        }

        /// <summary>
        /// Estados para el handler de un emprendedor no registrado
        /// </summary>
        public enum UnregisteredUserState
        {
            Start,
            NickName,
        }
        public class UnregisteredUserData
        {
            public string NickName { get; set; }
        }
    }
}