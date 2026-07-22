namespace Learning_C_;

public static class Practice_4
{
    public static void Test()
    {
        int start, end, even_number, odd_number, even_number_sum, odd_number_sum, current_number;

        Console.WriteLine("Enter starting point as number: ");

        string? user_input = Console.ReadLine();

        Console.WriteLine("Enter end point as number: ");

        string? user_input2 = Console.ReadLine();

        bool result1, result2;

        result1 = int.TryParse(user_input, out start);
        result2 = int.TryParse(user_input2, out end);

        if (!result1 || !result2)
        {
            Console.WriteLine("Something wrong with the input.");
        }
        else
        {
            current_number = start;
            even_number = 0;
            odd_number = 0;
            even_number_sum = 0;
            odd_number_sum = 0;

            while (current_number <= end)
            {
                switch (current_number % 2)
                {
                    case 0:
                        {
                            even_number_sum += current_number;
                            even_number++;
                            current_number++;
                        }
                    break;

                    default:
                        {
                            odd_number_sum += current_number;
                            odd_number++;
                            current_number++;
                        }
                    break;
                }
            }

            Console.WriteLine("There are " + even_number + " even numbers and " + odd_number + " odd numbers.");
            Console.WriteLine("Sum of even numbers is: " + even_number_sum);
            Console.WriteLine("Sum of odd numbers is: " + odd_number_sum);
        }
        
    }
}