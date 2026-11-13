class Player
{
    public string FullName;
    public int Number;
    public string Position;
    public string Team;


 public void GetInfo()
    {
        Console.WriteLine($"FullName {FullName}");
        Console.WriteLine($"Number {Number}");
        Console.WriteLine($"Position {Position}");
        Console.WriteLine($"Team {Team}");
    }   
}