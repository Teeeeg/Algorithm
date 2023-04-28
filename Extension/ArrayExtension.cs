using System.Text;

namespace AlgorithmAD.Extension;

internal static class ArrayExtension
{
    public static void Print(this IEnumerable<int> array)
    {
        var printStringBuilder = new StringBuilder();
        foreach (var item in array)
        {
            printStringBuilder.Append(item);
            printStringBuilder.Append(' ');
        }

        Console.WriteLine(printStringBuilder.ToString());
    }
}