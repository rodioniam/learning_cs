namespace Learning_C_;

public static class JaggedArray
{
    public static void Test()
    {
        // это способ объявления массива массивов
        // при выделении памяти указал сколько будет строк - массивов в массиве
        int[][] myArray = new int[3][];
        myArray[0] = new int[5];
        myArray[1] = new int[2];
        myArray[2] = new int[4];

        Console.WriteLine(myArray[0].Length);

        // так происходит взаимодействие с вложенными массивами
        myArray[0][0] = 10;

        Console.WriteLine(myArray[0][0]);

        // заполняем и выводим в консоль массив массивов со случайными числами
        Console.WriteLine("\nJagged array with random numbers: \n");
        Random random = new Random();

        // заполняет
        for (int y = 0; y < myArray.Length; y++)
        {
            for (int x = 0; x < myArray[y].Length; x++)
            {
                myArray[y][x] = random.Next();
            }
        }

        // выводит
        for (int y = 0; y < myArray.Length; y++)
        {
            for (int x = 0; x < myArray[y].Length; x++)
            {
                Console.Write(myArray[y][x] + "\t");
            }
            Console.WriteLine();
        }

    }
}