namespace CSharpNewFeatures.V00_01_ExpressionBodiesMembers;

public class Person
{
    private readonly int _id; 
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    //Constructors
    public Person(int id) => this._id = id;

    //Methods
    public override string ToString() => $"{FirstName} {LastName}".Trim();
    public void DisplayName() => Console.WriteLine(ToString());

    //Read-only properties
    public string FullName => $"{FirstName} {LastName}";
}

internal class Test
{
    public static void Run()
    {
        var p = new Person(100) {FirstName = "Bill", LastName = "Gates"};
        Console.WriteLine(p);
        Console.WriteLine(p.FullName);
        p.DisplayName();
    }
}
