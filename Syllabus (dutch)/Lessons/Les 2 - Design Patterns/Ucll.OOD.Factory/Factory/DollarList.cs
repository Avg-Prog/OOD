using System.Text;

namespace Factory;

public class DollarList : IListElement
{
    public void PrintList(List<string> elements)
    {
        var output = new StringBuilder();
        foreach (string element in elements)
        {
            output.Append($"${element}");
        }

        Console.WriteLine(output.ToString());
    }
}
