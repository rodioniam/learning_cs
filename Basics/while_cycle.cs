namespace Learning_C_;

public static class While_Cycle
{
    public static void Test()
    {
        int count = 0;
        int count2 = 5;

        while (count < 5)
        {
            count++;
            Console.WriteLine("Iteration №" + count);
        }

        // цикл do...while сначала выполняет действие, а потом проверяет условие
        // пример ниже выведет к консоль 6, хотя по логике цикла уже не должно быть

        do
        {
            count2++;
            Console.WriteLine("Second iteration №" + count2);

        } while (count2 < 5);
    }
}