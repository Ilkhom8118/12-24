namespace OOP;

public class Student
{
    public string Name { get; set; }
    public string Age { get; set; }
    public string Gruop { get; set; }
    public string Pol { get; set; }
    public string Email { get; set; }
    public void DisplayInfo()
    {
        string res = $"Name : {Name},  Age : {Age}, Jins : {Pol}";
        Console.WriteLine(res);
    }
}
