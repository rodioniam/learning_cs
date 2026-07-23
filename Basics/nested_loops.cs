namespace Learning_C_;

public static class Nested_Loops
{
    public static void Test()
    {
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("Level 1, iteration: " + i);

            for (int j = 0; j < 5; j++)
            {
                // \t это табуляция
                Console.WriteLine("\tLevel 2, iteration: " + j);
            }
        }
    }
}