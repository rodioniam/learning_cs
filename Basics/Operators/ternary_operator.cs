namespace Learning_C_;

public static class Ternary_Operator
{
    public static void Test()
    {
        bool accessAllowed;

        string storedPassword = "qwerty";

        Console.Write("Enter your password: ");
        string ? enteredPassword = Console.ReadLine();


        // if (enteredPassword == storedPassword)
        // {
        //     accessAllowed = true;
        // }
        // else
        // {
        //     accessAllowed = false;
        // }

        // такой же код только с помощью тернарного оператора

        accessAllowed = enteredPassword == storedPassword ? true : false;
        Console.WriteLine(accessAllowed);

        Console.Write("Write number: ");

        int userInput = int.Parse(Console.ReadLine());

        int outputData = userInput < 0 ? 0: userInput;

        Console.WriteLine(outputData);

    }
}