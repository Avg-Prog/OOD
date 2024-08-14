using Console_MVC.Models;

namespace Console_MVC.Views;

public interface IView
{
    IModel RenderView();
}
