using System.Diagnostics.Tracing;
using System.Reflection.Metadata;

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