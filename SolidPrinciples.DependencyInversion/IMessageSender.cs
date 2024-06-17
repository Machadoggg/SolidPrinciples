namespace SolidPrinciples.DependencyInversion
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }
}
