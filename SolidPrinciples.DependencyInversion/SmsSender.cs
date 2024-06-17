namespace SolidPrinciples.DependencyInversion
{
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Send SMS: {message}");
        }
    }
}
