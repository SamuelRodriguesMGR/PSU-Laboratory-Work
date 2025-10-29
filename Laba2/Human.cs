public class Human
{
    private string Name { get; set; }
    private int Height { get; set; }

    public Human(string name, int height)
    {
        Name = name;
        Height = height;
    }

    public override string ToString()
    {
        return $"Человек с именем {Name} и ростом {Height}";
    }
}

