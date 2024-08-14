namespace Console_MVC.Models;

public class User : IModel
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}
