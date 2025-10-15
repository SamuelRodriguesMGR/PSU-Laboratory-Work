
public class City
{
    public string Name { get; set; }
    String[] NamesCities;
    int[] WaysCities;

    public City(string name, String[] cities, int[] ways)
    {
        Name = name;
        NamesCities = cities;
        WaysCities = ways;
    }

    public override string ToString()
    {
        String c = "";
        for (int i = 0; i < NamesCities.Length; i++)
        {
            c += $"{NamesCities[i]}: {WaysCities[i]}; ";
        }
        return $"Город с название {Name} и соединён с городами: {c}";
    }
}

public class CityUpdate
{
    public string Name { get; set; }
    String[] NamesCities = {};
    int[] WaysCities = {};

    public CityUpdate(string name)
    {
        Name = name;
    }

    public CityUpdate(string name, String[] cities, int[] ways)
    {
        Name = name;
        NamesCities = cities;
        WaysCities = ways;
    }

    public override string ToString()
    {   
        if(NamesCities.Length == 0){
            return $"Город с названием {Name} и не соединён ни с кем";
        }
        String c = "";
        for(int i = 0; i < NamesCities.Length; i++)
        {
            c += $"{NamesCities[i]}: {WaysCities[i]}; ";
        }
        return $"Город с название {Name} и соединён с городами: {c}";
    }
}