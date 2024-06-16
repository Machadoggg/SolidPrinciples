namespace SolidPrinciples.LiskovSubstitution
{
    public class GuestUser : User
    {
        public override void AccessDashboard()
        {
            Console.WriteLine("Guest user accessing limited dashboard");
        }

        public override void AccessAdminPanel()
        {
            throw new InvalidOperationException("Guest user does not have access to the admin panel");
        }
    }
}
