namespace Learning_C_;

public static class ListArrayList
{
    public static void Result()
    {
        
    }
}

static class SwapTestClass
{
    public static void GenericSwap<T>(ref T a, ref T b) // generic версия будет быстрее
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static void Swapp(ref object a, ref object b)
    {
        object temp = a;
        a = b;
        b = temp;
    }
}