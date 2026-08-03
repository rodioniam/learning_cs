using System.IO.Pipelines;

namespace Learning_C_;


public static class Practice_9
{
    
    public static void RenderResult()
    {
        int[] myarray = {1, 2, 3, 4, 5};

        // ArrayRecursion(myarray);
        // ArrayValuesSumRecursion(myarray);
        Console.WriteLine(NumberValuesSumRecursion(561));
    }

    // вывод массива при помощи рекурсии
    public static void ArrayRecursion(int[] arr, int i = 0)
    {

        if (i >= arr.Length)
        {
            return;
        }
        Console.Write(arr[i] + ", ");

        i++;
        ArrayRecursion(arr, i);
    }

    // сумма элементов массива при помощи рекурсии
    public static void ArrayValuesSumRecursion(int[] arr, int i = 0, int result = 0)
    {

        if (i >= arr.Length)
        {
            Console.WriteLine(result);
            return;
        }

        result = result + arr[i];

        i++;
        ArrayValuesSumRecursion(arr, i, result);
    }

    // сумма чисел числа при помощи рекурсии
    public static int NumberValuesSumRecursion(int value)
    {
        if (value < 10)
        {
            return value;
        }
        
        int digit = value % 10;
        int nextValue = value/10;

        return digit + NumberValuesSumRecursion(nextValue);
    }
}