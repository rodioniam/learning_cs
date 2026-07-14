namespace Learning_C_;

public static class Variables
{
    public static void Test()
    {
        int variable;

        variable = 10;

        Console.WriteLine(variable);

        // так-же можно сразу при объявлении присваивать значения

        string hello = "Hello world!";

        Console.WriteLine(hello);

        // можно объявить сразу несколько переменных с одним типом

        int a, b;

        a = 10;
        b = 5;

        Console.WriteLine(a+b);
    }
}
