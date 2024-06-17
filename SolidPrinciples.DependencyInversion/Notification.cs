namespace SolidPrinciples.DependencyInversion
{
    public class Notification
    {
        private readonly IMessageSender _messageSender;

        public Notification(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }


        public void Send(string message)
        {
            _messageSender.SendMessage(message);
        }
    }
}
