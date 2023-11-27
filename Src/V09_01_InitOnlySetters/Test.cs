namespace CSharpNewFeatures.V09_01_InitOnlySetters;

public class PersonAsClass
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; set; }

    public PersonAsClass(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

internal class Test
{
    public static void Run()
    {
        var c01 = new PersonAsClass("a", "b");
        Console.WriteLine($"{c01.FirstName} {c01.LastName} {c01.Age}");

        c01.Age = 5;
        //c01.FirstName = "x"; //Not allowed

    }
}
