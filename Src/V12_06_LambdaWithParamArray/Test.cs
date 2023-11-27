namespace CSharpNewFeatures.V12_06_LambdaWithParamArray;

internal class Test
{
    [Obsolete("FeatureID")]
    public static void Run()
    {
        var sum = (params int[] values) =>
        {
            int sum = 0;
            foreach (var value in values)
                sum += value;

            return sum;
        };


        var empty = sum();
        Console.WriteLine(empty); // 0

        var sequence = new[] { 1, 2, 3, 4, 5 };
        var total = sum(sequence);
        Console.WriteLine(total); // 15
    }
}
