using Console_MVC.Models;
using Console_MVC.Views;
using Console_MVC.Views.Users;

namespace Console_MVC.Controllers;

public class UserController : IController
{
    public IView Create()
    {
        return new Create();
    }

    public IView Create(object toCreate)
    {
        var user = (User)toCreate;
        UserRepository.Instance.AddUser(user);
        return new Create(user);
    }

    public IView List()
    {
        return new List(UserRepository.Instance.GetUsers());
    }

    public IView Details(int id)
    {
        var user = UserRepository.Instance.GetUser(id);
        return new Details(user);
    }
}
