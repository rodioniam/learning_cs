namespace Learning_C_;

public static class OneDimensionalArray
{
    public static void Test()
    {   
        // способы инициализации массивов 
        // 1
        int[] myArray;
        // присвоение места в памяти
        myArray = new int[5];
        // 2 
        int[] myArray2 = new int[5] {1, 2, 3, 4, 5}; // {} - способ добавить элементы в массив при инициализации
        // 3 
        int[] myArray3 = {1, 2, 3}; // так можно создать массив размером под передаваемое кол-во данных
        // 4 - заполнение массива каким то отличным от по умолчанию значением
        // создаст массив из 10 двоек
        int[] myArray4 = Enumerable.Repeat(2, 10).ToArray();
        // или заполнить каким то диапазоном
        int[] myArray5 = Enumerable.Range(10, 34).ToArray();


        // по индексу 1 поместил 3 в массив
        myArray[1] = 3;

        Console.WriteLine(myArray[1]);

        // метод length - длина массива
        Console.WriteLine(myArray.Length);
        Console.WriteLine(myArray2[3]);
        Console.WriteLine(myArray4[9]);
        Console.WriteLine(myArray5[0]);
    }
}