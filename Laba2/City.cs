public class City
{
    private string Name;
    private Dictionary<City, int> routes;

    public City(string name)
    {
        Name = name;
        routes = new Dictionary<City, int>();
    }

    public void AddRoute(City city, int cost)
    {
        routes[city] = cost;
    }

    public bool RemoveRoute(City city)
    {
        return routes.Remove(city);
    }

    public string GetTextOutput()
    {
        
        var routeStrings = routes.Select(route => $"{route.Key.Name}:{route.Value}");
        return routes.Count > 0
            ? $"Город с названием {Name} соединён с городами: {string.Join(", ", routeStrings)}"
            : $"Город с названием {Name} не соединён с городами";
    }
    
    public override string ToString()
    {
        return GetTextOutput();
    }
}

