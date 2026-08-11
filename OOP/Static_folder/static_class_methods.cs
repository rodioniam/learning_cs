using System.Runtime.Versioning;

namespace Learning_C_;


public static class StaticClassMethods
{
    public static void Result()
    {
        MyClass myClass = new();

        MyClass.Func(); // могу вызвать его на уровне класса
        myClass.Func2(); // я не могу вызвать статичный метод данного класса
        MyClass.C = 400; // static свойства тоже доступны только на уровне класса
        ExampleStaticMethod ex1 = new();
        ExampleStaticMethod ex2 = new();
        Console.WriteLine("\nExample of static properties: " + ExampleStaticMethod.Counter);

        ExampleStaticMethod ex3 = new();
        Console.WriteLine("\nExample of static properties: " + ExampleStaticMethod.Counter);
        
    }

}


class MyClass
{
    private static int a; // статичный метод может использовать только статичные переменные
    private int b;

    private static int c;
    public static int C
    {
        get { return c; }
        set { c = value; }
    }
    

    public static void Func()
    {
        Console.WriteLine("This is static method");
        a = 10;
        Console.WriteLine(a);

    }

    public void Func2()
    {
        Console.WriteLine("This is not static method");
        b = 34;
        Console.WriteLine(b);
        Console.WriteLine(a); // не статичные методы могут использовать статичные и не статичные переменные

    }
}

class ExampleStaticMethod
{
    // будет иметь встроенный счетчик, который покажет сколько раз были созданы экземпляры данного класса

    // кастомный конструктор класса, при создании экземпляра крутит счетчик
    public ExampleStaticMethod()
    {
        counter++;
    }
    private static int counter; // так как это поле static, то оно будет доступно всем экземплярам класса.
    public static int Counter
    {
        get { return counter; }
        private set { counter = value; } // обязательно сделать сеттер недоступным снаружи
    }
    
}