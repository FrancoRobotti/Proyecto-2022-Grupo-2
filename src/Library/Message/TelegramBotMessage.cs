namespace NavalBattle
{
    public class TelegramBotMessage : IMessage
    {
        public int Id { get; }

        private string text;

        public string Text{
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
            }
        }

        public TelegramBotMessage(int id, string text)
        {
            this.Id = id;
            this.Text = text;
        }
    }

}