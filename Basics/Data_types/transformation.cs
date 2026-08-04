namespace Learning_C_;


public static class DataTransformation
{
    public static void RenderResult()
    {
        int a = 5;

        double b = 3.3;

        float c = 4.5F; // так явно указывается float, без этого ошибка

        Func(a); // хоть метод и принимает float, но происходит неявная трансформация типов
        Func((float)b); // явная конвертация типов делается так -- (тип)переменная
        Console.Write(c);
    }


    public static void Func(float value)
    {
        Console.WriteLine(value);
    }

    public static void Overflow()
    {
        int a = int.MaxValue;

        // местное применение часто используется в конструкции try...catch
        try
        {
            a = checked(a + 1); // местное применение проверки на overflow
            Console.Write(a); // запускать в debug
        }
        catch (OverflowException)
        {
            Console.WriteLine('0');
        }

        checked
        {
            // можно помещать множество операций с потенциальным overflow в такую конструкцию.
        }


        // типа overflow для типов с плавающей точкой
        double b = 1.0 / 0.0;
        Console.WriteLine(double.IsInfinity(b)); // выполняет проверку на бесконечность

        double c = 0.0 / 0.0;
        Console.WriteLine(double.IsNaN(c)); // проверка на отсутствие значения

        double d = double.MaxValue + double.MaxValue;
        Console.WriteLine(double.IsInfinity(d)); // тоже бесконечность - самое близкое к overflow


    }
}