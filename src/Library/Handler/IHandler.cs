using System;

namespace NavalBattle
{
    public interface IHandler
    {

        IHandler SetNext(IHandler handler);

        IHandler Handle(IMessage input, out string response);
        
        bool InternalHandle(IMessage input, out string response);
    }
}