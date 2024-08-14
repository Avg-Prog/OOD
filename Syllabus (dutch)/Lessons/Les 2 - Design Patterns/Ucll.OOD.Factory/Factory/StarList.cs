using System.Text;

namespace Factory;

public class StarList : IListElement
{
    public void PrintList(List<string> elements)
    {
        var output = new StringBuilder();

        foreach (string element in elements)
        {
            output.AppendLine($"* {element}");
        }

        Console.WriteLine(output.ToString());
    }
}
