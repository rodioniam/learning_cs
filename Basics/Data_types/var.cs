namespace Learning_C_;

public static class VarKeyword
{
    public static void RenderResult()
    {
        Func();
    }

    public static void Func()
    {
        var t = 5;

        Console.WriteLine(t.GetType());
    }
}