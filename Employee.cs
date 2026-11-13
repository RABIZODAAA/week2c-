class Employee
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Position;

    public void GitInfo()
    {
        Console.WriteLine($"FirstName: {FirstName}");
        Console.WriteLine($"SurName: {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Position: {Position}");
    }
}