namespace Singleton;

sealed class OnlyOneDatabase
{
    private static OnlyOneDatabase? instance = null;
    private static readonly object padlock = new();

    public int TestValue { get; set; }

    public static OnlyOneDatabase Instance
    {
        get
        {
            if (instance is null)
            {
                lock (padlock)
                {
                    instance = new OnlyOneDatabase();
                }
            }
            return instance;
        }
    }

    private OnlyOneDatabase() { }
}
