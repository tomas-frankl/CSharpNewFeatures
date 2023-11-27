namespace CSharpNewFeatures.V00_03_UnusedVariables;

internal class Test
{
    public static void Run(string parameter = "a")
    {
        _ = parameter;

        var myValues = new [] { 0, 1, 2 };

        {
            FindMinMaxAvg(myValues, out var min, out _, out _);
            Console.WriteLine($"min = {min}");
        }

        {
            var (min, max, _) = FindMinMaxAvg(myValues);
            Console.WriteLine($"min = {min}, max = {max}");
        }
    }

    private static void FindMinMaxAvg(int[] values, out int min, out int max, out double avg)
    {
        min = values.Min(v => v);
        max = values.Max(v => v); 
        avg = values.Average(v => v);
    }

    private static (int min, int max, double avg) FindMinMaxAvg(int[] values)
    {
        return
        (
            values.Min(v => v),
            values.Max(v => v),
            values.Average(v => v)
        );
    }
}
