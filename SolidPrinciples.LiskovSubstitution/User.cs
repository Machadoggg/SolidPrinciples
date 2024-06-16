namespace SolidPrinciples.LiskovSubstitution
{
    public class User
    {

        public virtual void AccessDashboard()
        {
            Console.WriteLine("User accessing dashboard");
        }

        public virtual void AccessAdminPanel()
        {
            throw new InvalidOperationException("User does not have access to the admin panel");
        }
    }
}
