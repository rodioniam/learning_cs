namespace Learning_C_;


public static class TypeCasting
{
    public static void Result()
    {
        object obj = new C1 {X = 2, Y = 10}; // тип object может хранить любой тип данных, поэтому в нем может быть что угодно
        // object obj = "Hello world!";

        // C1 c = (C1)obj; // это явная конвертация и она вызывает ошибку при несоответствии объектов
        // c.Print();

        // FuncAs(obj);
        FuncIs(obj);
    }


    static void FuncAs(object obj)
    {
        C1? c = obj as C1; // если в obj придет не объект типа C1, то в переменную поместится null

        // теперь можно использовать проверку и условия
        if (c != null)
        {
            c.Print();
        }
        else
        {
            Console.WriteLine("Wrong type.");
        }
    }

    // использование же is сильно сокращает код и сразу позволяет присвоить значение новой переменной если оно соответствует типу
    static void FuncIs(object obj)
    {
        if (obj is C1 c)
        {
            c.Print();
        }
        else
        {
            Console.WriteLine("Wrong type.");
        }
    }


}

class C1
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine(X + ", " + Y);
    }

    
}