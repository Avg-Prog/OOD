namespace Factory;

public class DollarFactory : IAbstractFactory
{
    private static DollarFactory _instance = null;
    private static readonly object padLock = new object();

    public static DollarFactory Instance
    {
        get
        {
            if (_instance is null)
            {
                lock (padLock)
                {
                    if (_instance == null)
                    {
                        _instance = new DollarFactory();
                    }
                }
            }
            return _instance;
        }
    }

    private DollarFactory() { }
    public ITitleElement CreateTitle()
    {
        return new DollarTitle();
    }

    public IListElement CreateList()
    {
        return new DollarList();
    }
}
