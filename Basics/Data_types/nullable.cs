namespace Learning_C_;


public static class Nullable
{
    public static void RenderResult()
    {
        
    }

    public static void Func()
    {
        int? a = null; // не может быть null без наличия ? после типа
        // это способ принудительно присвоить null типам, которые его не могут получать по умолчанию
        // присвоение null значимому типу добавляет ему методов
        Console.WriteLine(a.HasValue); // bool, проверка на наличие значения
        Console.WriteLine(a.GetValueOrDefault()); // понятно из названия
        Console.WriteLine(a ?? 55); // оператор null-объединения
        // Console.WriteLine(a.Value); // бросит ошибку если там null
        int b = 4;
        int? sum = a + b;

        Console.WriteLine(sum); // получу null, стоит об этом помнить
    }
}