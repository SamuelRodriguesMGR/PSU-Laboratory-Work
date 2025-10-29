public class UpdateCity
{
    private string Name;
    private Dictionary<UpdateCity, int> routes;

    public UpdateCity(string name)
    {
        Name = name;
        routes = new Dictionary<UpdateCity, int>();
    }
    
    public UpdateCity(string name, Dictionary<UpdateCity, int> initialRoutes)
    {            
        Name = name;
        routes = new Dictionary<UpdateCity, int>();
        
        foreach (var route in initialRoutes)
        {
            AddRoute(route.Key, route.Value);
        }
    }
    
    public void AddRoute(UpdateCity city, int cost)
    {
        routes[city] = cost;
    }
    
    public void AddDictRoute(Dictionary<UpdateCity, int> initialRoutes)
    {
        foreach (var route in initialRoutes)
        {
            AddRoute(route.Key, route.Value);
        }
    }

    public bool RemoveRoute(UpdateCity city)
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
