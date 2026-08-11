namespace Learning_C_;

partial class Human // использование одного и того же назвния класса и ключевого слова partial.
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }


}