using System.Reflection.Metadata.Ecma335;

namespace Learning_C_;

class SSS
{
    public int a;
    private static int b;

    public void SetB(int b)
    {
        SSS.b = b; // особенность доступа к статической переменной, так как она не объект экземпляра класса
    }
    public void PrintB()
    {
        Console.WriteLine(b);
    }


}

class Static
{
    public static void StaticClassField()
    {
        SSS obj1 = new();
        obj1.a = 44;
        // SSS.b = 100; // так происходит доступ к статическому полю класса
        obj1.SetB(100);
        Console.WriteLine("obj1: " + obj1.a);

        SSS obj2 = new();
        obj2.PrintB();
        // хоть у этого объекта класса и не назначалась b, из-за того что она статик ее значение одинаково для всех экземпляров класса
    }
}