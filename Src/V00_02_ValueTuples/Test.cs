namespace CSharpNewFeatures.V00_02_ValueTuples;

internal class Test
{
    public static void Run()
    {
        //value tuple with anonymous field names
        (double, int) t1 = (4.5, 3);
        Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
        
        //value tuple with field names
        (double Sum, int Count) t2 = (4.5, 3);
        Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
        Console.WriteLine($"Sum of {Get1().Count} elements is {Get1().Sum}.");
        Print(t2);
        Print(t1);

        //implicit filed names (now allowed in return parameters etc)
        var sum = 4.5; var count = 3; 
        var t = (sum, count); 
        Console.WriteLine($"Sum of {t.count} elements is {t.sum}.");
        //Console.WriteLine($"Sum of {Get2().count} elements is {Get2().sum}.");
    }

    public static (double Sum, int Count) Get1()
    {
        return (4.5, 3);
    }

    public static (double, int) Get2()
    {
        var sum = 4.5; var count = 3;
        return (sum, count);
    }

    public static void Print((double Sum, int Count) t)
    {
        Console.WriteLine($"Sum of {t.Count} elements is {t.Sum}.");
    }
}
