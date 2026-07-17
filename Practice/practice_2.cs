using System.Globalization;

namespace Learning_C_;

public static class Practice_2
{
    public static void Test()
    {

        NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        {
            NumberDecimalSeparator = "."
        };

        Console.WriteLine("Enter any number: ");

        string? user_input = Console.ReadLine();

        double num;

        bool result = double.TryParse(user_input, numberFormatInfo, out num);

        if (result)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Number " + num + " is even");
            }
            else
            {
                Console.WriteLine("Number " + num + " is odd");
            }
        }
        else
        {
            Console.WriteLine("Not a number");
        }

    }
}