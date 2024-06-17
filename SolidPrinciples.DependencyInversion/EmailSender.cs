namespace SolidPrinciples.DependencyInversion
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Send Email: {message}");
        }
    }
}
