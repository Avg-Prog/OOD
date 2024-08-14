namespace Factory;

public class DollarTitle : ITitleElement
{
    public void PrintTitle(string title)
    {
        Console.WriteLine($"$$$ {title} $$$");
    }
}
