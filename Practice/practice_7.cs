using System.Diagnostics.Metrics;
using System.IO.Pipelines;

namespace Learning_C_;

public static class Practice_7
{
    // вывод строки, состоящей из повторяющихся символов
    // символы и кол-во повторов задается через консоль
    public static void PrintString()
    {
        Console.WriteLine("Enter characters: ");
        string? chars = Console.ReadLine();
        Console.WriteLine("Enter number of repeats: ");
        int? repeats = int.Parse(Console.ReadLine()!);

        int count = 0;
        string result = "";
        while (count < repeats)
        {
            result += chars;
            count++;
        }

        Console.WriteLine($"Your string is: '{result}'");
    }

    // поиск индекса элемента массива (вернуть первый подходящий индекс, если будет найден)
    // нужен метод который будет генерировать массив для начала

    static int[] GenerateArray(uint lenght)
    {
        Random random = new Random();
        int[] generatedArray = new int[lenght];
        
        for (int x = 0; x < generatedArray.Length; x++)
        {
            generatedArray[x] = random.Next(100);
        }

        return generatedArray;
    }

    public static string ReturnIndex(int element, uint arrayLenght)
    {
        string result;
        int[] arrayToSearch  = GenerateArray(arrayLenght);
        int searchReasult = Array.FindIndex(arrayToSearch, i => i == element);

        if (searchReasult == -1)
        {
            result = $"Number '{element}' is not in the array :(";
            return result;
        }
        else
        {
            result = $"Number '{element}' has '{searchReasult}' index";
            return result;
        }
    }
}