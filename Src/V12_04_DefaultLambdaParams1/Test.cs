namespace CSharpNewFeatures.V12_04_DefaultLambdaParams1;

internal class Test
{
    public static void Run()
    {
        var IncrementBy = (int source, int increment = 1) => source + increment;

        Console.WriteLine(IncrementBy(5)); // 6
        Console.WriteLine(IncrementBy(5, 2)); // 7
    }
}
