using System.IO.Pipelines;

namespace Learning_C_;


public static class InterfaceExplicitImplementation
{
    public static void Result()
    {
        DoubleInterfaceImplementation obj = new();
        Func(obj);
        Func2(obj);
        Console.WriteLine();
        ExplicitInterfaceImplementation obj2 = new();
        Func(obj2); // требование опрежеденного типа внутри метода
        Func2(obj2);
        ((IFirstInterface)obj2).Action(); // явное приведение типов 
        if (obj2 is ISecondInterface secondInterface) // явное приведение типов при помощи оператора is
        {
            secondInterface.Action();
        }
    }

    // указание конкретного интерфейса в параметрах определяет код какой реализации интерфейса будет использован
    static void Func(IFirstInterface firstInterface) 
    {
        firstInterface.Action();
    }

    static void Func2(ISecondInterface secondInterface)
    {
        secondInterface.Action();
    }
}

interface IFirstInterface
{
    void Action();
}

interface ISecondInterface
{
    void Action();
}

class DoubleInterfaceImplementation : IFirstInterface, ISecondInterface
{
    public void Action()
    {
        Console.WriteLine("My class action...");
    }
}

class ExplicitInterfaceImplementation : IFirstInterface, ISecondInterface
{
    void IFirstInterface.Action() // так выглядит синтаксис явной реализации интерфейса
    {
        Console.WriteLine("Explicit implementation of first interface.\n");
    }

    void ISecondInterface.Action()
    {
        Console.WriteLine("Explicit implementation of second interface.\n");
    }
}