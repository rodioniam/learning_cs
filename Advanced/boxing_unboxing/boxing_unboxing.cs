using System;

namespace Learning_C_;


public static class BoxingUnboxing
{
    public static void Result()
    {
        int a = 1;
        object b = a; // тут происходит неявная упаковка, так как object это класс - ссылочный тип данных
        int c = (int)b; // тут происходит неявная распаковка - из ссылочного в значимый тип
    }
}