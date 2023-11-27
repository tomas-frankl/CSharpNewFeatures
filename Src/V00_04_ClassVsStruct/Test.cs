namespace CSharpNewFeatures.V00_04_ClassVsStruct;

public class PersonAsClass
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; set; }
}

public struct PersonAsStruct
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; set; }
};

internal class Test
{
    public static void Run()
    {
        //Class
        var c01 = new PersonAsClass { FirstName = "a", LastName = "b", Age = 1 };
        var c02 = new PersonAsClass { FirstName = "a", LastName = "b", Age = 1 };

        if (c01 == c02) //not the same object and IEquatable is not implemented
        {
            Console.WriteLine("c01 and c02 equals");
        }

        var c01Reference = c01;
        c01Reference.Age = 5;
        Console.WriteLine($"{c01.Age} == {c01Reference.Age}");

        if (c01 == c01Reference) //not the same object and IEquatable is not implemented
        {
            Console.WriteLine("r01 and r02 equals");
        }

        //Struct
        var s01 = new PersonAsStruct{ FirstName = "a", LastName = "b", Age = 1 };
        var s02 = new PersonAsStruct{ FirstName = "a", LastName = "b", Age = 1 };

        if (s01.Equals(s02))
        {
            Console.WriteLine("r01 and r02 equals");
        }

        var s01Copy = s01;
        s01Copy.Age = 5;
        Console.WriteLine($"{s01.Age} == {s01Copy.Age}");

        Console.WriteLine(c01);
        Console.WriteLine(s01);
    }
}
