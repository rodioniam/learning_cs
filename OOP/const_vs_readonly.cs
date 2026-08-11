namespace Learning_C_;

public static class ConstVsReadOnly
{
    public static void Result()
    {
        Const c = new Const("BIG PROBLEM!");

        Console.WriteLine(c.errorMessage);
        Console.WriteLine(Const.greetingMessage);
    }
}


class Const
{
    public const int MAX_VALUE = 10;
    private const int MIN_VALUE = 5;

    public readonly string errorMessage = "ERROR!"; // можно не присваивать значение

    public static readonly string greetingMessage;

    static Const()
    {
        greetingMessage = "Hello, world!";
    }

    public Const(string message)
    {
        errorMessage = message;
    }

    public void Func()
    {

    }
}