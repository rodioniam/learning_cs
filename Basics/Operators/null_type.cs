namespace Learning_C_;

public static class NullType
{
    public static void Test()
    {
        int[] arr; // arr содержит null - не выделено место в памяти и нет данных

        arr = new int[10]; // тут уже появился объект и null не будет.
    }


    // оператор null объединения
    public static void NullCoalescing()
    {
        string? str = null;

        string result = str ?? string.Empty;

        // так легко добавляется значение по умолчанию для ссылочных типов данных.
        Console.WriteLine(str ?? "no data");

        // так можно обрабатывать возможное null с методами
        Console.WriteLine($"String length is: {result.Length}");
    }

    // оператор присваивания объединения со значением null
    public static void NullCoalescingAssignment()
    {
        string? str = null;
        str ??= "default string";

        Console.WriteLine(str);
        Console.WriteLine(str + "23");
    }

    // пример с массивами

    public static int[] GetArray()
    {
        int[] ?arr = null;

        return arr!;
    }

    public static int[] GetArray(int a)
    {   
        Random random = new Random();

        int[] arr = new int[a];

        for (int x = 0; x < arr.Length; x++)
        {
            arr[x] = random.Next(100);    
        }
        return arr;
    }

    public static void ArrayExample()
    {
        int[] myArray = GetArray();

        myArray ??= new int[0]; // создаст новый пустой массив и присвоит его переменной

        Console.WriteLine($"Array length is: {myArray.Length}");
    }


    // Оператор условного NULL
    public static void NullConditional()
    {
        int[] arr = GetArray(); // поставь число в аргумент для смены примера

        Console.WriteLine($"Sum of the elements in array is: {arr?.Sum() ?? 0}");
    }
}