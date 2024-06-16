namespace SolidPrinciples.LiskovSubstitution
{
    public class User
    {

        public virtual void AccessDashboard()
        {
            Console.WriteLine("\tUser accessing dashboard");
        }

        public virtual void AccessAdminPanel()
        {
            throw new InvalidOperationException("\tUser does not have access to the admin panel");
        }
    }
}
