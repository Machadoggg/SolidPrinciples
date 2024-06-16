

using SolidPrinciples.LiskovSubstitution;

static void AccessSystem(User user)
{
    user.AccessDashboard();
	try
	{
		user.AccessAdminPanel();
	}
	catch (InvalidOperationException ex)
	{

		Console.WriteLine(ex.Message);
	}
}



User regularUser = new User();
User adminUser = new AdminUser();
User guestUser = new GuestUser();


Console.WriteLine("- Regular User");
AccessSystem(regularUser);

Console.WriteLine("- Admin User");
AccessSystem(adminUser);

Console.WriteLine("- Guest User");
AccessSystem(guestUser);
