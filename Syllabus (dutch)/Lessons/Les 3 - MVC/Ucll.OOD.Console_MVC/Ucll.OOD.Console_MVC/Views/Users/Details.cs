
using Console_MVC.Models;

namespace Console_MVC.Views.Users;

public class Details : IView
{
    private readonly User _user;
    public Details(User user)
    {
        _user = user;
    }
    public IModel RenderView()
    {
        if (_user is null)
        {
            Console.WriteLine("User not found");
        }
        else
        {
            Console.WriteLine("Details user:");
            Console.WriteLine($"Login: {_user.Login}");
            Console.WriteLine($"Password: {_user.Password}");
        }

        Console.WriteLine("Press key to continue...");
        Console.Read();
        Console.Clear();
        return _user;
    }
}
