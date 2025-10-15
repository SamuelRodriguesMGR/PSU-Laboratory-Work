

public class Human
{
    public string Name { get; set; }
    public int Height { get; set; }

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


public class Name
{
    public string LastName { get; set; } = null!;   // Фамилия
    public string FirstName { get; set; } = null!;  // Имя
    public string MiddleName { get; set; } = null!; // Отчество

    public Name() { }

    public Name(string firstName)
    {
        FirstName = firstName;
    }

    public Name(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    public Name(string lastName, string firstName, string middleName)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
    }


    public override string ToString()
    {
        var parts = new string[] { LastName, FirstName, MiddleName };
        String result = "";

        foreach (var part in parts)
        {
            if (result.Length > 0)
                result += " ";
                
            result += part;
        }

        return result.ToString();
    }
}

public class Person
{
    public Name FullName { get; set; }
    public int Height { get; set; }

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