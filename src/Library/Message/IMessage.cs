namespace NavalBattle
{
    public interface IMessage
    {
        int Id { get; }

        string Text { get; set; }
    }
}