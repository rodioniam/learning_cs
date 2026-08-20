namespace Learning_C_;


public static class Delegates
{
    public static void Example()
    {
        // самый последний элемент в сигнатуре - это тип возвращаемого значения
        // первые два - это тип параметров метода, который будет сюда помещен
        Func<int, int, int> mathOperation = Sum;

        var result = mathOperation(2, 4);

        Console.WriteLine(result);
        Console.WriteLine("\nDelegate as method parameter: ");

        // тут теперь можно просто менять метод на необходимый
        PerformMathOperation(Multiply, 2, 5);

        Console.WriteLine("\nCustom delegate: ");
        Operation mathOperationCustom = Sum;
        PerformMathOperationn(mathOperationCustom, 44, 56);
    }
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static int Sum(int a, int b)
    {
        return a + b;
    }
    // данный метод выполняет математические операции, но не знает какую конкретно
    // это будет определяться в момент вызова этого метода
    static void PerformMathOperation(Func<int , int, int> mathOperation, int a, int b)
    {
        Console.WriteLine("Very important code.");

        var operationResult = mathOperation(a, b);

        Console.WriteLine(operationResult);

        Console.WriteLine("Super important code.");
    }

    // нельзя перегружать методы с помощью делегатов
    static void PerformMathOperationn(Operation mathOperation, int a, int b)
    {
        Console.WriteLine("Very important code.");

        var operationResult = mathOperation(a, b);

        Console.WriteLine(operationResult);

        Console.WriteLine("Super important code.");
    }

    // свой делегат
    delegate int Operation(int a, int b);
}


class MultiCastDelegate
{
    public static void Example()
    {
        Notify notify = SendSms;

        // мульти-каст делегат -- один делегат может содержать несколько методов с одинаковой сигнатурой
        notify += SendEmail;

        notify("Hello World!"); // сработает оба метода этого делегата
    }

    delegate void Notify(string message);

    static void SendSms(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
    static void SendEmail(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}