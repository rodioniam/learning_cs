namespace Learning_C_;

public static class For_Cycle
{
    public static void Test()
    {
        // пока что тут конечно выглядит как прошлый век какой то
        // грубо говоря тут на первом месте объявляется счетчик, на втором условие для продолжения цикла
        // на третьем инкрементная операция с счетчиком
        for (int ii = 0; ii < 5; ii++)
        {
            Console.WriteLine(ii);
        }

        // так выглядит цикл без всех условий - бесконечный. Точка с запятой обязательна
        // for (; ;)
        // {
        //     break;
        // }

        int i = 0;

        for (; i < 3; i++)
        {
            Console.WriteLine("for_1 " + i);
        }

        for (; i < 5; i++)
        {
            Console.WriteLine("for_2 " + i);
        }

        // можно использовать несколько переменных вннутри условия цикла
        for (int iii = 0, j = 5; iii < 10 && j < 12; iii++, j++)
        {
            Console.WriteLine("iii: " + iii);
            Console.WriteLine("j: " + j);
        }


        // способ выполнения работы цикла в обратном порядке
        for (int p = 5; p >= 0; p--)
        {
            Console.WriteLine(p);
        }
    }
}