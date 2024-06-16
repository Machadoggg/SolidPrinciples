namespace SolidPrinciples.LiskovSubstitution
{
    public class GuestUser : User
    {
        public override void AccessDashboard()
        {
            Console.WriteLine("\tGuest user accessing limited dashboard");
        }

        public override void AccessAdminPanel()
        {
            throw new InvalidOperationException("\tGuest user does not have access to the admin panel");
        }
    }
}
