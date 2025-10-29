public class Name
{
    private string LastName { get; set; }   // Фамилия
    private string FirstName { get; set; }  // Имя
    private string MiddleName { get; set; } // Отчество

    public Name() { 
        LastName = null!;
        FirstName = null!;
        MiddleName = null!;
    }

    public Name(string firstName)
    {
        LastName = null!;
        FirstName = firstName;
        MiddleName = null!;
    }

    public Name(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = null!;
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