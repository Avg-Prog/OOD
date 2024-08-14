namespace Factory;

public sealed class StarFactory : IAbstractFactory
{
    private static StarFactory _instance = null;
    private static readonly object padLock = new object();

    public static StarFactory Instance
    {
        get
        {
            if (_instance is null)
            {
                lock (padLock)
                {
                    if (_instance == null)
                    {
                        _instance = new StarFactory();
                    }
                }
            }
            return _instance;
        }
    }

    private StarFactory() { }
    public ITitleElement CreateTitle()
    {
        return new StarTitle();
    }

    public IListElement CreateList()
    {
        return new StarList();
    }
}
