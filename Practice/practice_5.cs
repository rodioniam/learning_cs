namespace Learning_C_;

public static class Practice_5
{
    public static void Test()
    {
        Console.Write("Enter height: ");
        int height = int.Parse(Console.ReadLine());
        Console.Clear();
    
        char tag = '#';
        char empty = ' ';

        // первый треугольник
        for (int t1 = 0; t1 < height; t1++)
        {
            for (int ttag = 0; ttag <= t1; ttag++)
            {   
                Console.Write(tag);
            }
            Console.WriteLine();

        }

        Console.WriteLine("");
        Console.WriteLine("");

        // второй треугольник
        for (int t2 = 0; t2 < height; t2++)
        {

            for (int t2tag = height; t2tag > t2; t2tag--)
            {   
                Console.Write(tag);
            }
            Console.WriteLine();
        }

        Console.WriteLine("");
        Console.WriteLine("");

        // третий треугольник
        for (int t3 = 0; t3 < height; t3++)
        {
            for (int t3empty = height-1; t3empty > t3; t3empty--)
            {   
                Console.Write(empty);
            }

            for (int t3tag = 0; t3tag <= t3; t3tag++)
            {   
                Console.Write(tag);
            }
            Console.WriteLine();

        }

        Console.WriteLine("");
        Console.WriteLine("");

        // четвертный треугольник
        for (int t4 = 0; t4 < height; t4++)
        {
            for (int t4empty = 1; t4empty <= t4; t4empty++)
            {   
                Console.Write(empty);
            }

            for (int t4tag = height; t4tag > t4; t4tag--)
            {   
                Console.Write(tag);
            }
            Console.WriteLine();
        
        
        }
        Console.WriteLine();
    }
}