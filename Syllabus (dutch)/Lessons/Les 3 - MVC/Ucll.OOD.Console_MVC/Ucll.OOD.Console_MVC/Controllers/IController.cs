using Console_MVC.Views;

namespace Console_MVC.Controllers;

public interface IController
{
    public IView Create();
    public IView Create(object model);
    public IView Details(int id);
    public IView List();
}
