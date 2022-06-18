namespace NavalBattle
{
    public interface IMessageChannel
    {
        IMessage ReceiveMessage();

        void SendMessage(string message);
    }
}