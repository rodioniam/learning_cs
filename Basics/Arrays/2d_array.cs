using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace Learning_C_;

public static class TwoDimensionalArray
{
    public static void Test()
    {
        // объявление массива, кол-во запятых указывает на измерения массива
        int[,] myArray = new int [3, 5];
        // при выделении памяти указывается сколько будет строк (3) и колонок (5)

        // принципиальная разница будет только в том что нужно указывать две координаты (два индекса)
        myArray[0,2] = 200;

        Console.WriteLine(myArray[0,2]);


        // помещение данных в массив при создании
        int[,] myArray2 = new int[3, 5]
        {
            {3, 4, 1, 56, 123},
            {65, 66, 67, 68, 100},
            {5, 4, 3, 2, 1} 
        };
        // это просто более удобная запись, по факту нужно передать столько данных
        // сколько указано в размерности массива

        Console.WriteLine(myArray2[1, 1]);

        // более короткий способ объявления многомерного массива
        int[,] myArray3 = 
        {
            {1, 2, 3},
            {4, 5, 6}
        };

        Console.WriteLine(myArray3[1, 0]);
        Console.WriteLine();

        // первый способ вывода многомерного массива в консоль
        foreach (var item in myArray2)
        {
            Console.WriteLine(item);
        }

        // способ узнать размерность массива
        Console.WriteLine(myArray2.Rank);
        // способ узнать кол-во элементов в определенном измерении массива
        Console.WriteLine($"\nrows: {myArray2.GetLength(0)}");
        Console.WriteLine($"columns: {myArray2.GetLength(1)}");

        // второй способ - вывод примерно в виде таблицы
        int height = myArray2.GetLength(0);
        int width = myArray2.GetLength(1);
        Console.WriteLine();

        // первый цикл будет проходиться по каждой строке - по вертикали
        for (int y = 0; y < height; y++)
        {
            // второй цикл будет проходиться по каждому значению в строке - по горизонтали
            for (int x = 0; x < width; x++)
            {
                Console.Write(myArray2[y, x] + "\t");
            }
            Console.WriteLine();
        }
        // заполнение массива из консоли
        Console.WriteLine("\nArray population from console:");
        Console.WriteLine("With random values.\n");

        int[,] fillArrayRandom = new int[10, 6];
        // случайными числами
        Random random = new Random();

        // принцип Solid - single responsobility - единственной ответственности
        // тут не особо актуально, но поэтому два разных цикла
        // один  заполняет, второй выводит

        // заполняет
        for (int y = 0; y < fillArrayRandom.GetLength(0); y++)
        {
            for (int x = 0; x < fillArrayRandom.GetLength(1); x++)
            {
                fillArrayRandom[y, x] = random.Next();
            }
        }


        // выводит
        for (int y = 0; y < fillArrayRandom.GetLength(0); y++)
        {
            for (int x = 0; x < fillArrayRandom.GetLength(1); x++)
            {
                Console.Write(fillArrayRandom[y, x] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nFrom keyboard values.\n");

        int[,] fillArrayKeyboard = new int[2, 3];

        // заполняет
        for (int y = 0; y < fillArrayKeyboard.GetLength(0); y++)
        {
            for (int x = 0; x < fillArrayKeyboard.GetLength(1); x++)
            {
                Console.WriteLine("Y: " + y + " X: " + x);
                fillArrayKeyboard[y, x] = int.Parse(Console.ReadLine()!);
            }
        }
        Console.WriteLine();
        // выводит
        for (int y = 0; y < fillArrayKeyboard.GetLength(0); y++)
        {
            for (int x = 0; x < fillArrayKeyboard.GetLength(1); x++)
            {
                Console.Write(fillArrayKeyboard[y, x] + "\t");
            }
            Console.WriteLine();
        }

    }
}