namespace Learning_C_;


class Example
{
    public int x;
    private int y = 0;
    private void PrintX()
    {
        Console.WriteLine($"X: {x}");
    }

    public void PrintY()
    {
        Console.WriteLine($"Y: {y}");
    }

    public void PrintExample()
    {
        PrintX();
        PrintY();
    }
}

class Modifiers
{
    public static void Test()
    {
        Example example = new()
        {
            x = 1, // доступа к приватным полям у меня тут нет
        };

        example.PrintY(); // так же и с методами класса
        Console.WriteLine();
        example.PrintExample(); // выводит все методы класса - приватные и публичные
    }
}