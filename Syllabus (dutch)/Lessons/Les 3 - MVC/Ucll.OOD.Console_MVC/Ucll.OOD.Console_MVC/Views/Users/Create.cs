using Console_MVC.Models;

namespace Console_MVC.Views.Users;

public class Create : IView
{
    private readonly User _user = null;
    public Create() { }

    public Create(User user)
    {
        _user = user;
    }
    public IModel RenderView()
    {
        if (_user is null)
        {
            User user = new User();
            Console.Write("Enter login: ");
            user.Login = Console.ReadLine();

            Console.Write("Enter password: ");
            user.Password = Console.ReadLine();

            return user;
        }
        else
        {
            Console.WriteLine($"User {_user.Login} added");
            Console.WriteLine("Press key to continue...");
            Console.Read();
            Console.Clear();
            return _user;
        }
    }
}
