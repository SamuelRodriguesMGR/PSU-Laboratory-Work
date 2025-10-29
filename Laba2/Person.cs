public class Person
{
    private Name FullName { get; set; }
    private int Height { get; set; }

    public Person(Name fullname, int height)
    {
        FullName = fullname;
        Height = height;
    }

    public override string ToString()
    {
        return $"Человек с именем {FullName} и ростом {Height}";
    }
}