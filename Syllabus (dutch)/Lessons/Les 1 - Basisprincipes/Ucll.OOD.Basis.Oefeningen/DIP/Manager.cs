namespace DIP;

internal class Manager
{
    private List<Developer> developers { get; set; }
    private List<Tester> testers { get; set; }

    public void AssignDeveloper(Developer dev)
    {
        developers.Add(dev);
    }

    public void AssignTester(Tester tester)
    {
        testers.Add(tester);
    }
}
