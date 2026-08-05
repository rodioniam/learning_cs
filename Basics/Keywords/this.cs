namespace Learning_C_;


class Person
{
    public Person(string lastName, DateTime birthday)
    {
        this.lastName = lastName;
        this.birthday = birthday;
    }

    // после : пример наследования параметров из другого метода
    public Person(string lastName, string firstName, string middleName, DateTime birthday):this(lastName, birthday)
    {
        this.firstName = firstName;
        this.middleName = middleName;
    }

    public Person(Person person) // это полезная фишка для создания правильной копии объекта
    // так как это ссылочные данные при простом копировании новый объект будет все равно ссылаться на то же место в памяти
    {
        firstName = person.firstName;
        lastName = person.lastName;
        middleName = person.middleName;
        birthday = person.birthday;
    }

    private string firstName = string.Empty;
    private string lastName = string.Empty;
    private string middleName = string.Empty;
    private DateTime birthday;

    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public void Print()
    {
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Middle name: {middleName}");
        Console.WriteLine($"Birthday: {birthday}");
    }

}

class Keyword_This
{
    public static void KeywordThis()
    {
        Person person1 = new Person("Brad", new DateTime(1963, 12, 18));
        person1.Print();
        // правильное копирование объектов класса
        Person person2 = new Person(person1);
        person2.SetFirstName("Pitt");
        Console.WriteLine();
        person2.Print();
    }
}