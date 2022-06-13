using System;
using System.Collections.Generic;
using System.Linq;
namespace NavalBattle
{
    public abstract class AbstractHandler : IHandler
    {

        protected IHandler nextHandler;

        protected string Command;

        public IHandler SetNext(IHandler handler)
        {
            this.nextHandler = handler;
            return handler;
        }

        public virtual bool InternalHandle(IMessage input, out string response)
        {
            throw new Exception();
        }

        protected virtual bool CanHandle(IMessage input)
        {
            if (this.Command == null || this.Command.Length == 0)
            {
                throw new InvalidOperationException("No hay palabras clave que puedan ser procesadas");
            }
            return this.Command.Equals(input.Text.ToLower().Trim());
        }

        public IHandler Handle(IMessage message, out string response)
        {
            if (this.InternalHandle(message, out response))
            {
                return this;
            }
            else if (this.nextHandler != null)
            {
                return this.nextHandler.Handle(message, out response);
            }
            else
            {
                return null;
            }
        }

        protected virtual void InternalCancel()
        {

        }
    }   
}