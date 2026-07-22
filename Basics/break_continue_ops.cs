namespace Learning_C_;

public static class Break_Continue
{
    public static void Test()
    {
        for (;;)
        {
            Console.WriteLine("Endless cycle");
            break; // данный break выводит меня из бесконечного цикла for
        }

        for (int i = 0; i < 100; i++)
        {   
            Console.WriteLine("Enter something to continue or type 'exit' to finish");
            string? msg = Console.ReadLine();

            if (msg == "exit")
            {
                break;
            }
        }

        for (int j = 0; j < 5; j++)
        {
            if (j == 2)
            {
                continue;
                // данный оператор пропустит итерацию когда j будет 5 и не напишет ее в консоль
            }

            Console.WriteLine(j);
        }
    }
}