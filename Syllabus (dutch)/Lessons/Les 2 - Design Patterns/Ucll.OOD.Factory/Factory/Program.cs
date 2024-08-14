using Factory;

string input = "";
IAbstractFactory factory = StarFactory.Instance;

do
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Choose layout");
    Console.WriteLine("2. Show title");
    Console.WriteLine("3. Show list");
    Console.WriteLine("4. Quit");
    Console.Write(">");
    input = Console.ReadLine();

    switch (input)
    {
        case "1":
            factory = ChooseLayoutMenu();
            break;
        case "2":
            ShowTitle(factory);
            break;
        case "3":
            ShowList(factory);
            break;
        default:
            break;
    }
    Console.Clear();

} while (input != "4");

void ShowList(IAbstractFactory factory)
{
    var elements = new List<string>();
    Console.WriteLine("Enter list elements (-1 to quit):");
    var input = "";
    do
    {
        Console.Write(">");
        input = Console.ReadLine();
        if (input != "-1") { elements.Add(input); }
    } while (input != "-1");

    IListElement listElement = factory.CreateList();
    listElement.PrintList(elements);
    Console.WriteLine("Press key to continue");
    Console.Read();
}

void ShowTitle(IAbstractFactory factory)
{
    Console.WriteLine("Enter the title:");
    Console.Write(">");
    var title = Console.ReadLine();
    ITitleElement titleElement = factory.CreateTitle();
    titleElement.PrintTitle(title);
    Console.WriteLine("Press key to continue");
    Console.Read();
}

IAbstractFactory ChooseLayoutMenu()
{
    string layoutOption;
    Console.WriteLine("Choose layout");
    Console.WriteLine("1. * layout");
    Console.WriteLine("2. $ layout");
    Console.Write(">");
    layoutOption = Console.ReadLine();

    switch (layoutOption)
    {
        case "1":
            return StarFactory.Instance;
        case "2":
            return DollarFactory.Instance;
        default:
            return StarFactory.Instance;
            break;
    }
}