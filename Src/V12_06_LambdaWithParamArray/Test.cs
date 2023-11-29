namespace CSharpNewFeatures.V12_06_LambdaWithParamArray;

internal class Test
{
    public static void Run()
    {
        var sum = (params int[] values) =>
        {
            int sum = 0;
            foreach (var value in values)
                sum += value;

            return sum;
        };


        {
            var sequence = new[] { 1, 2, 3, 4, 5 };
            var total = sum(sequence);
            Console.WriteLine(total); // 15
        }

        {
            var total = sum();
            Console.WriteLine(total); // 0
        }

        {
            var total = sum(1, 2, 3);
            Console.WriteLine(total); // 6
        }
    }
}
