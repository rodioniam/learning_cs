namespace Learning_C_;

public static class Increment_Decrement
{
    public static void Test()
    {
        int inc = 9;
        int dec = 10;

        // постфиксные
        inc++;
        dec--;
        // префиксные
        ++inc;
        --dec;


        Console.WriteLine(inc);
        Console.WriteLine(dec);

        // можно заметить что в выводе я получил снова 11, хотя было произведено увеличение.
        Console.WriteLine("Постфиксный вид операции " + inc++);
    }
}