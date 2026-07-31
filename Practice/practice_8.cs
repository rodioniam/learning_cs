using System.Runtime.CompilerServices;

namespace Learning_C_;

public static class Practice_8
{
    public static void Result()
    {

        int [] arr = {1, 2, 3, 4};

        // AppendToArray(ref arr, 43);
        Insert(ref arr, 100, 2);

        Console.WriteLine(string.Join(',', arr));
    }

    /// <summary>
    /// Собственная реализация метода Resize
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="size"></param>
    public static void Resize<T>(ref T[] arr, int size)
    {
        // <T> - это способ сделать метод generic - может принимать любые типы данных
        T[] arrNew = new T[size];

        for (int x = 0; x < arr.Length && x < arrNew.Length; x++)
        {
            arrNew[x] = arr[x];
        } 

        arr = arrNew;
    }


    public static void AppendToArray<T>(ref T[] arr, T value, bool from_start = false)
    {
        T[] newArray = new T[arr.Length + 1];

        if (from_start)
        {
            newArray[0] = value;

            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i + 1] = arr[i];
            }
        }
        else
        {
            newArray[^1] = value;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                newArray[i] = arr[i];
            }
        }

        arr = newArray;
    }

    public static void Insert<T>(ref T[] arr, T value, uint position)
    {
        T[] newArray = new T[arr.Length + 1];

        newArray[position] = value;

        for (int x = 0; x < position; x++)
        {
            newArray[x] = arr[x];
        }

        for (uint x = position; x < arr.Length; x++)
        {
            newArray[x + 1] = arr[x];
        }

        arr = newArray;

    }
}