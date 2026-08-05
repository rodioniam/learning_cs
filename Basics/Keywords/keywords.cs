namespace Learning_C_;

public static class ReferenceRef
{
    public static void Func(int a)
    {
        a = -5;
    }

    public static void Func2(ref int aa) // теперь данные передаются по ссылке
    {
        aa = -5;
    }

    public static void RenderResult()
    {
        int a = 2;
        int aa = 2;
        int[] arrayOne = {2, 2, 2};
        int[] arrayTwo = {2, 2, 2};

        Func(a); // тут происходит копирование переменной и ее данные живут только в пределах этого метода
        Func2(ref aa); // тут не было копирования, а была ссылка

        Console.WriteLine(a); // будет результат из этой области видимости -- 2
        Console.WriteLine(aa); // тут будет результат из метода, так как данные одни и те же и они изменились внутри него

        FuncArr(arrayOne); // в этом случае ссылка начала вести на новый объект и удалилась после выхода из области видимости
        FuncArr2(ref arrayTwo); // в этом случае ссылка на ссылку позволяет менять именно оригинальную ссылку, а не копию

        Console.WriteLine(string.Join(',', arrayOne)); // покажет исходный результат
        Console.WriteLine(string.Join(',', arrayTwo)); // покажет новый результат

    }


    public static void FuncArr(int[] arr)
    {
        arr = new int [4] {1, 1 , 1, 1};
    }

    public static void FuncArr2(ref int[] arr)
    {
        arr = new int [4] {1, 1, 1, 1};
    }


    // Другие примеры использования ref

    public static void RenderResultTwo()
    {
        int[] arr = {1, 2, 3, 4};

        int b = arr[1];

        ref int c = ref arr[2]; // а теперь переменная становится ссылочной

        b = -10;

        c = -10; // взаимодействие с ссылочной переменной меняет исходные данные

        Console.WriteLine(arr[1]); // работа по умолчанию
        Console.WriteLine(arr[2]);

        ref int d = ref Func3(arr); // вернет результат в виде ссылки на объект

        d = -5;

        Console.WriteLine(arr[0]);
    }

    public static ref int Func3(int[] numbers)
    {
        return ref numbers[0];
    }
}


public static class Out
{
    public static void RenderResult()
    {
        int variable = 0; // при использовании с out у переменной изначально может не быть никакого значения.
        
        Func(out variable); // логика такая же как и у ref - передача данных по ссылке
        Func(out int a); // можно объявлять переменную прямо в вызове метода

        Console.WriteLine(variable);
        Console.WriteLine(a);
    }


    public static void Func(out int value)
    {
        value = 10; // только out обязует давать переменной какое то значение внутри метода
    }
}


public static class IN
{
    public static void RenderResult()
    {
        int number = 5;

        Console.WriteLine(number);
        Func(in number);
    }


    public static void Func(in int value)
    {
        Console.WriteLine(value);
    }
}


public static class Params
{
    public static void RenderResult()
    {
        int result = Sum(2, 2, 5, 1); // нет необходимости каждый раз изменять метод

        Console.WriteLine(result);
        
        Func("string", 12, 4.2, true);
    }

    public static int Sum(params int[] numbers)
    {
        int result = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }

        return result;
    }

    public static void Func(params object[] parameters)
    {
        string message = "Data type of {1}: {0}";

        foreach (var item in parameters)
        {
            Console.WriteLine(message, item.GetType(), item); // видимо фишка такая что можно в строке указать номера, а в консоли написать через запятую что помещать вместо цифр
        }
    }

}


public static class Enums
{
    public static void RenderResult()
    {
        
    }
}