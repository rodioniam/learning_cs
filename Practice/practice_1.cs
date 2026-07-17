using System.Globalization;

namespace Learning_C_;

public static class Practice_1
{
    public static void Mean_finder()
    {
        string? input_1, input_2, input_3;
        double num1, num2, num3;
        double sum, mean;

        NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        {
            NumberDecimalSeparator = "."
        };

        Console.WriteLine("Enter first number: ");
        input_1 = Console.ReadLine();
        Console.WriteLine("Enter second number: ");
        input_2 = Console.ReadLine();
        Console.WriteLine("Enter third number: ");
        input_3 = Console.ReadLine();

        try
        {
            num1 = Convert.ToDouble(input_1, numberFormatInfo);
            num2 = Convert.ToDouble(input_2, numberFormatInfo);
            num3 = Convert.ToDouble(input_3, numberFormatInfo);
            sum = num1 + num2 + num3;
            mean = sum / 3;

            Console.WriteLine("Numbers sum is: " + sum);
            Console.WriteLine("Numbers mean is: " + mean);
        }
        catch (Exception)
        {
            Console.WriteLine("Not a number");
        }








    }
}