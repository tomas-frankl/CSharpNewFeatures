namespace CSharpNewFeatures.V09_02_RecordClass;

//init only members by default
//class by default
public record class PersonAsClass(string FirstName, string LastName)
{
    public int Age { get; set; }
};

internal class Test
{
    public static void Run()
    {
        var c01 = new PersonAsClass("a", "b") { Age = 1 };
        var c02 = new PersonAsClass("a", "b") { Age = 1 };

        if (c01 == c02) //IEquatable is implemented by default
        {
            Console.WriteLine("c01 and c02 equals");
        }

        //but it is still a reference
        var c01Reference = c01;
        c01Reference.Age = 5;
        Console.WriteLine($"{c01.Age} == {c01Reference.Age}");

        //non destructive mutation
        var c01Copy = c01 with { Age = 5 };
        Console.WriteLine($"{c01.Age} == {c01Copy.Age}");

        Console.WriteLine(c01);
    }
}
