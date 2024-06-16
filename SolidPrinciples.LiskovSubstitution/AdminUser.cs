namespace SolidPrinciples.LiskovSubstitution
{
    public class AdminUser : User
    {
        public override void AccessAdminPanel()
        {
            Console.WriteLine("\tAdmin user accessing admin panel");
        }
    }
}
