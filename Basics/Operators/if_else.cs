namespace Learning_C_;


// Тоже самое что в Python, только способ записи чуть отличается
public static class If_Else_Statement
{
    public static void Test()
    {

        // скобочки обязательны

        bool is_sick = true;

        if (is_sick)
        {
            Console.WriteLine("Your character is sick!");
        }
        else
            // если в блоке if..else одна строчка, то скобочки {} можно не использовать
            Console.WriteLine("Your character is okay");

    }
}