using System.Diagnostics.CodeAnalysis;

namespace CSharpNewFeatures.T43_RequiredFields;

public class PersonAsClass
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required int Age { get; set; }

    public PersonAsClass()
    {
    }

    [SetsRequiredMembers]
    public PersonAsClass(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}

internal class Test
{
    public static void Run()
    {
        var c01 = new PersonAsClass("a", "b", 1);
        var c02 = new PersonAsClass { FirstName = "a", LastName = "b", Age = 1 };
        //var c02 = new PersonAsClass(); //This is not allowed
    }
}
