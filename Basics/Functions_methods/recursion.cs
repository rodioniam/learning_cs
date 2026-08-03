namespace Learning_C_;


public static class Recursion
{
    public static void RenderResult()
    {
        Func();
    }


    public static void Func(int i = 0)
    {
        Console.WriteLine(i);
        if (i >= 4)
        {
            return; // способ выхода при помощи счетчика
        }

        i++;
        Func(i);
    }


}