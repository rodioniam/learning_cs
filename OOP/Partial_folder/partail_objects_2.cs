namespace Learning_C_;


public static class PartailCLass
{
    public static void Example()
    {
        Human human = new Human("Lebron", "James");

        human.PrintName();

    }
}


partial class Human // использование одного и того же назвния класса и ключевого слова partial.
{
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }

    public void PrintName()
    {
        Console.WriteLine(GetFullName());
    }
}