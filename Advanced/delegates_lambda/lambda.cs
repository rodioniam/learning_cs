using System.Runtime.ExceptionServices;

namespace Learning_C_;


public static class Lambda
{
    public static void Example()
    {
        var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        var result1 = numbers.Where(IsEven);
        // устаревший синтаксис
        var result2 = numbers.Where(delegate (int number) {return number % 2 == 0;});
        // норм синтаксис, если входящий параметр только один (number), то первые скобки, тип и return не обязательны
        // var result3 = numbers.Where(number => number % 2 == 0); // самый простой вариант
        var result3 = numbers.Where((int number) => {return number % 2 == 0;});

        foreach (var number in result3) // меняй result тут
        {
            Console.WriteLine(number);
        }

        // все кроме названия и типа возвращаемого значения можно использовать прямо в параметрах другого метода
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}