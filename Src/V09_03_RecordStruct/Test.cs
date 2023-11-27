namespace CSharpNewFeatures.V09_03_RecordStruct;

//init only members by default
public record struct PersonAsStruct(string FirstName, string LastName)
{
    public int Age { get; set; }
};

internal class Test
{
    public static void Run()
    {
        var c01 = new PersonAsStruct("a", "b") {Age = 1};
        var c02 = new PersonAsStruct("a", "b") { Age = 1 };

        if (c01 == c02)
        {
            Console.WriteLine("c01 and c02 equals");
        }

        var c01Copy1 = c01;
        c01Copy1.Age = 5;
        Console.WriteLine($"{c01.Age} == {c01Copy1.Age}");

        //non destructive mutation
        var c01Copy2 = c01 with { Age = 5 };
        Console.WriteLine($"{c01.Age} == {c01Copy2.Age}");
    }
}
