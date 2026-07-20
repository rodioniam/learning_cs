namespace Learning_C_;

public static class Practice_3
{
    public static void Test()
    {
        double num1, num2;
        string? operation;

        Console.WriteLine("Enter first number: ");
        bool result1 = double.TryParse(Console.ReadLine(), out num1);

        Console.WriteLine("Enter second number: ");
        bool result2 = double.TryParse(Console.ReadLine(), out num2);

        Console.WriteLine("Enter operation symbol: ");
        operation = Console.ReadLine();

        if (result1 && result2)
        {
            switch (operation)
            {
                case "+":
                    {
                        double output = num1 + num2;
                        Console.WriteLine("Result is: " + output);
                    }
                    break;
                case "-":
                    {
                        double output = num1 - num2;
                        Console.WriteLine("Result is: " + output);
                    }
                    break;
                case "*":
                    {
                        double output = num1 * num2;
                        Console.WriteLine("Result is: " + output);
                    }
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        double output = num1 / num2;
                        Console.WriteLine("Result is: " + output);
                    }
                    else
                    {
                        Console.WriteLine("Cant divide by zero!");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Sonething went wrong...");
                    }
                    break;
            }
        }
        else
            // если в блоке if...else только одна строчка, то скобочки можно не использовать
            Console.WriteLine("Something happend...");
    }
}