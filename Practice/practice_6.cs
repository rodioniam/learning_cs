using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Learning_C_;

public static class Practice_6
{
    public static void Test()
    {

        Console.Write("Enter length of an array: ");
        int userArrayLength = int.Parse(Console.ReadLine()!);
        int[] userArray = new int[userArrayLength];
        Console.Clear();

        for (int i = 0; i < userArrayLength; i++)
        {
            Console.Write("Enter number to put in array: ");
            int userNumber = int.Parse(Console.ReadLine()!);
            Console.Clear();
            userArray[i] = userNumber;
        }

        Console.WriteLine("Your array: \n");

        for (int i = 0; i < userArray.Length; i++)
        {
            Console.WriteLine("\tElement #: " + i + " -- " + userArray[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Your array backwards: \n");

        for (int i = userArray.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("\tElement #: " + i + " -- " + userArray[i]);
        }

        int evenNumbersSum = 0;

        for (int i = 0; i < userArray.Length; i++)
        {
            if (userArray[i] % 2 == 0)
            {
                evenNumbersSum += userArray[i];
            }
        }

        Console.WriteLine($"\nSum of even numbers is: {evenNumbersSum}\n");

        Console.WriteLine($"Smallest number in the array: {userArray.Min()}\n");
    }
}