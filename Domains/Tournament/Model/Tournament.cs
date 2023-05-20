public class Tournament
{
    public Tournament(string uuid, string name, DateTime date)
    {
        Uuid = uuid;
        Name = name;
        Date = date;
    }

    public string Uuid {get; set;}
    public string Name {get; set;}
    public DateTime Date {get; set;}
}