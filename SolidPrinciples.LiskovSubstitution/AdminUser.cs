namespace SolidPrinciples.LiskovSubstitution
{
    public class AdminUser : User
    {
        public override void AccessAdminPanel()
        {
            Console.WriteLine("Admin user accessing admin panel");
        }
    }
}
