namespace Learning_C_;

public static class ArraysWithLoops
{
    public static void Test()
    {
        int[] myArray = {10, 4, 8, 5, 7};

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}