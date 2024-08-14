namespace Factory;
public interface IAbstractFactory
{
    public ITitleElement CreateTitle();
    public IListElement CreateList();
}
