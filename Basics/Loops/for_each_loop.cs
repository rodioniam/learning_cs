using System.Globalization;

namespace Learning_C_;

public static class ForEachLoop
{
    public static void Test()
    {
        int[] myArray = {45, 3, 32, 16, 8, 5};

        // более подробно будет позже

        foreach (var item in myArray)
        {
            Console.WriteLine($"{item} ");
        }
    }
}