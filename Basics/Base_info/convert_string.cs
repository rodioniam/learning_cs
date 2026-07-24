using System.Globalization; // видимо так происходит импорт модулей в C#

namespace Learning_C_;

public static class Convert_String
{
    public static void Test()
    {
        string str = "5";
        string str2 = "2";

        // в данном случае в выводе будет просто 52
        Console.WriteLine(str + str2);


        string num = "5";
        string num2 = "2";

        int a = Convert.ToInt32(num);
        int b = Convert.ToInt32(num2);

        // в данном случае произойдет сложение двух чисел
        Console.WriteLine(a + b);


        string float_str = "1.3";

        // тут я указываю какой разделитель используется в дробных числах
        NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        {
          NumberDecimalSeparator = ".",  
        };

        /* 
        вторым аргументом нужно передать этот форматер
        и тогда конвертация будет без ошибок
        */
        double float_num = Convert.ToDouble(float_str, numberFormatInfo);

        // метод parse вызывается у самих типов, работает он исключительно со строками
        int parsed = int.Parse(str);
        // при парсинге дробных чисел так же нужно обращать внимание на формат
        double float_parsed = double.Parse(float_str, numberFormatInfo);

        string mixed_str = "5.4hello";
        // string str_num = "5.4";

        try
        {
            double aa = Convert.ToDouble(mixed_str, numberFormatInfo);
            Console.WriteLine("Success");
        }
        catch (Exception)
        {
            Console.WriteLine("Error occured");
        }

        double bb;
        // первым аргументом передаем то что нужно парсить, вторым форматер
        // третим передаем как раз ту переменную, в которую нужно записать результат
        bool result = double.TryParse(mixed_str, numberFormatInfo, out bb);

        if (result)
        {
            Console.WriteLine("Success");  
        }
        else
        {
            Console.WriteLine("Error occured");
        }
    }
}