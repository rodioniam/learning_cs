namespace Learning_C_;


public static class ExtentionMethods
{
    public static void Result()
    {
        DateTime currentDateTime = DateTime.Now;
        currentDateTime.Print(); // теперь могу использовать свой extention метод для класса DateTime
        Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Monday));

        Console.WriteLine();
        Friend newFriend = new()
        {
            FirstName = "Mark",
            LastName = "Strong"
        };

        Console.WriteLine(newFriend.GetFullName());
    }
}


static class MyExtentions
{
    // реализация метода Print для DateTime класса
    // через ключевое слово this указывается для какого класса пишется extention метод
    // после указывается название переменной
    public static void Print(this DateTime dateTime)
    {
        Console.WriteLine(dateTime);
    }

    // проверка текущего дня недели
    public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
    {
        return dateTime.DayOfWeek == dayOfWeek;
    }

    public static string GetFullName(this Friend friend)
    {
        return friend.FirstName + " " + friend.LastName;
    }
}


sealed class Friend
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}

