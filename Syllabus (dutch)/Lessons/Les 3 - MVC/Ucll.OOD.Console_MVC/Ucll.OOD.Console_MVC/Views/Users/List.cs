using Console_MVC.Models;

namespace Console_MVC.Views.Users;

internal class List : IView
{
    private readonly List<User> _users;

    public List(List<User> users)
    {
        _users = users;
    }

    public IModel RenderView()
    {
        Console.WriteLine("Overview users:");
        foreach (var user in _users)
        {
            Console.WriteLine($"{user.Id} - {user.Login}");
        }

        return null;
    }
}
