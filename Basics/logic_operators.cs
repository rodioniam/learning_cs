namespace Learning_C_;


public static class Logic_Opearators
{
    public static void Test()
    {
        bool is_infected = false;

        // инверсия условия
        if (!is_infected)
        {
            Console.WriteLine("You are not infected");
        }


        bool is_high_temperature = true;
        bool has_no_cooling = false;

        if (is_high_temperature && has_no_cooling)
        {
            Console.WriteLine("Overheating!!!");
        }
        else
        {
            Console.WriteLine("OK");
        }

        if (is_high_temperature || has_no_cooling)
        {
            Console.WriteLine("Overheating!!!");
        }
    }

}
