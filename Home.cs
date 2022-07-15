namespace Deser;

using System.Text.Json;
public class Home
{
    public string? Name { get; set; }
    public string? Address { get; set; }

    public string toJson()
    {
        //var options = new JsonSerializerOptions { WriteIndented = true };
        var options = new JsonSerializerOptions {};
        return JsonSerializer.Serialize(this, options);
    }

    public static Home? fromJson(string homeAsString)
    {
        Home? home = null;
        try
        {
            home = JsonSerializer.Deserialize<Home>(homeAsString);
            return home;
        }
        catch
        {
            Console.WriteLine("Exception thrown");
            return home;
        }
    }
}