namespace Learning_C_;


public static class ProtectedModefier
{
    public static void Result()
    {
        A a = new();
        int aa = a.publicField; // вне класса доступ есть только к публичным полям

        B b = new();
        int bb = b.publicField;

        Console.WriteLine();
        b.Func(); // доступ ко всем полям родительского класса
    }
}

class A
{
    public int publicField = 1;
    private int privateField = 1;
    protected int protectedField = 1;

    public A()
    {
        Console.WriteLine(publicField);
        Console.WriteLine(privateField);
        Console.WriteLine(protectedField);
    }

    public void varAccess() // так можно обеспечить доступ к недоступным полям класса снаружи
    {
        Console.WriteLine(publicField);
        Console.WriteLine(privateField);
        Console.WriteLine(protectedField);
    }
}


class B : A
{
    public B()
    {
        Console.WriteLine(publicField);
        Console.WriteLine(protectedField);
    }

    public void Func()
    {
        varAccess(); // доступ и к приватному полю класса
    }
}