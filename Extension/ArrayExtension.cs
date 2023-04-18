using System.Text;

namespace Algorithm;

static class ArrayExtension
{
    public static void Print(this int[] array)
    {
        var printStringBuilder = new StringBuilder();
        foreach (var item in array)
        {
            printStringBuilder.Append(item);
            printStringBuilder.Append(" ");
        }

        System.Console.WriteLine(printStringBuilder.ToString());
    }
}