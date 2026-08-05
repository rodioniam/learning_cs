using System.ComponentModel;

namespace Learning_C_;

class Point
{
    public int x; // поле класса, в реальности обычно никогда не public
    public int y;
    public Color color = Color.Red; // в enum лучше назначать что то по умолчанию

}

class Student
{
    public Guid id;
    public string? firstName;
    public string? lastName;
    public string? middleName;
    public int age;
    public string? group;

    // метод класса
    public void Print()
    {
        Console.WriteLine($"Information about student with id: '{id}'");
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Middle name: {middleName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Group: {group}");
    }

    public string GetFullName()
    {
       return $"\n{firstName} {middleName} {lastName}"; 
    }
}

enum Color
{
    Red,
    Green,
    Orange,
    Yellow,
    Blue
}

class Classes
{
    public static void CreatingClassObject()
    {
        Point p = new Point(); // так создается новый экземпляр класса, p -- экземпляр данного класса
        p.x = 4; // помещение данных в поля класса для конкретно этого экземпляра
        p.y = 2;
        p.color = Color.Orange;
        Point p2 = new()
        {
            x = 2,
            y = 6,
            color = Color.Green
        };

        Console.WriteLine($"p: X: {p.x}, Y: {p.y}, color: {p.color}");
        Console.WriteLine($"p2: X: {p2.x}, Y: {p2.y}, color: {p2.color}");
    }


    static Student GetStudent()
    {
        Student student = new()
        {
          firstName = "Martin",
          middleName = "Luther",
          lastName = "King",
          age = 24,
          id = Guid.NewGuid(),
          group = "FGAD_1"  
        };

        return student;
    }


    public static void StudentExample()
    {
        var firstgStudent = GetStudent();

        firstgStudent.Print(); // вызов метода класса
        string fullName = firstgStudent.GetFullName();
        Console.WriteLine(fullName);
    }

    

}