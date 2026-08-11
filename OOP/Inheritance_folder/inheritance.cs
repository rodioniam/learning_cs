namespace Learning_C_;


public static class Inheritance
{
    public static void Result()
    {
        Monkey monkey = new Monkey
        {
            FirstName = "John",
            LastName = "Cool"
        };


        monkey.PrintMonkey();

        Cat cat = new()
        {
            FirstName = "George",
            LastName = "Willow",
            Color = "Orange"
        };

        cat.PrintMonkey();
        cat.CatInfo();
    }
}


class Monkey
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public void PrintMonkey()
    {
        Console.WriteLine(LastName + " " + FirstName);
    }
}

//на основе класса monkey можно сделать новый класс
class Cat : Monkey
{
    public required string Color { get; set; }

    public void CatInfo()
    {
        Console.WriteLine($"{FirstName} {LastName} is {Color}");
    }
}