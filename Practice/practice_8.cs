using System.Runtime.CompilerServices;

namespace Learning_C_;

public static class Practice_8
{
    public static void Result()
    {

        int [] arr = {1, 2, 3, 4, 5};


        Remove(ref arr, 0);

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

/// <summary>
/// Добавление элемента в конец или начало массива
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="arr"></param>
/// <param name="value"></param>
/// <param name="from_start">по умолчанию false, добавление с конца</param>
    public static void AppendToArray<T>(ref T[] arr, T value, bool fromStart = false)
    {
        T[] newArray = new T[arr.Length + 1];

        if (fromStart)
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

/// <summary>
/// Вставка в массив по индексу со смещением
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="arr"></param>
/// <param name="value"></param>
/// <param name="position"></param>
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

/// <summary>
/// удалить первый или последний элемент из массива
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="arr"></param>
/// <param name="fromStart"></param>
    public static void Pop<T>(ref T[] arr, bool fromStart = false)
    {
        T[] newArray = new T[arr.Length - 1];

        if (fromStart)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = arr[i + 1];
            }
        }
        else
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArray[i] = arr[i];
            }
        }

        arr = newArray;
    }

/// <summary>
/// удаление элемента из массива по индексу
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="arr"></param>
/// <param name="position"></param>
    public static void Remove<T>(ref T[] arr, int position)
    {
        T[] newArray = new T[arr.Length-1];

        for (int i = 0; i < position; i++)
        {
            newArray[i] = arr[i];
        }

        for (int i = position; i < newArray.Length; i++)
        {
            newArray[i] = arr[i + 1];
        }

        arr = newArray;
    }
}