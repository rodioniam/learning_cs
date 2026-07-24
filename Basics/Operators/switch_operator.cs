namespace Learning_C_;

public static class Switch_Operator
{
    public static void Test()

    {
        Console.WriteLine("Write 1 or 2.");

        int? user_input, user_input_2;
        user_input = int.Parse(Console.ReadLine());

        // может принимать не только числа, но и строки (+ видимо другие данные)
        switch (user_input)
        {
            // в случае если на user_input придет единица
            case 1:
                {
                    // поддерживает такую запись в {} для более приятного восприятия
                    Console.WriteLine("Your input is '1'.");
                }
                break;

            case 2:
                {
                    Console.WriteLine("Your input is '2'.");
                }
                break;

            default:
                Console.WriteLine("Nor '1' or '2' were given.");
                break;
        }

        user_input_2 = int.Parse(Console.ReadLine());

        switch (user_input_2)
        {
            case 4:
            case 5:
                {
                    // сработет оба условия если условие подходит под несколько case
                    Console.WriteLine("Options were met");
                }
                break;

            default:
                {
                    Console.WriteLine("Default condition triggered");
                }
                break;
        }
    }
}