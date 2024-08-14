namespace Console_MVC.Models;

sealed class UserRepository
{
    private List<User> users = new List<User>();


    private static UserRepository _instance = null;
    private static readonly object padlock = new object();

    public static UserRepository Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new UserRepository();
                    }
                }
            }
            return _instance;
        }
    }

    public void AddUser(User user)
    {
        user.Id = users.Count == 0 ? 1 : users.Max(u => u.Id) + 1;
        users.Add(user);
    }

    public User? GetUser(int id)
    {
        foreach (var user in users)
        {
            if (user.Id == id)
            {
                return user;
            }
        }
        return null;
    }

    public List<User> GetUsers()
    {
        return users;
    }
}
