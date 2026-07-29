namespace Learning_C_;

public static class NdArrays
{
    public static void Test()
    {   
        // объявление трехмерного массива
        int[,,] myArray = new int[4, 3, 5];

        myArray[0, 2, 1] = 50;

        Console.WriteLine(myArray[0, 2, 1]);

        // создание и вывод трехмерного массива
        Console.WriteLine("\n3 dimensional array with random values\n");

        Random random = new Random();
        // заполняет
        for (int z = 0; z < myArray.GetLength(0); z++)
        {
            for (int y = 0; y < myArray.GetLength(1); y++)
            {
                for (int x = 0; x < myArray.GetLength(2); x++)
                {
                    myArray[z, y, x] = random.Next(100);
                }
            }
        }

        // выводит
        for (int z = 0; z < myArray.GetLength(0); z++)
        {
            for (int y = 0; y < myArray.GetLength(1); y++)
            {
                for (int x = 0; x < myArray.GetLength(2); x++)
                {
                    Console.Write(myArray[z, y, x] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }

        // тоже самое но с зубчатым многомерным массивом
        Console.WriteLine("\nJagged n-dimensional array with random numbers: \n");
        int[][][] myArrayJagged = new int[random.Next(3, 6)][][];

        // заполняет
        for (int z = 0; z < myArrayJagged.Length; z++)
        {
            myArrayJagged[z] = new int[random.Next(2, 6)][];

            for (int y = 0; y < myArrayJagged[z].Length; y++)
            {

                myArrayJagged[z][y] = new int[random.Next(2, 6)];

                for (int x = 0; x < myArrayJagged[z][y].Length; x++)
                {
                    myArrayJagged[z][y][x] = random.Next(100);
                }
            }
        }

        // выводит
        for (int z = 0; z < myArrayJagged.Length; z++)
        {
            for (int y = 0; y < myArrayJagged[z].Length; y++)
            {
                for (int x = 0; x < myArrayJagged[z][y].Length; x++)
                {
                    Console.Write(myArrayJagged[z][y][x] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }
    }
}