namespace CSharpNewFeatures.T32_Deconstruction;

internal class Test
{
    public readonly record struct Point
    { 
        public int X { get; init; } 
        public int Y { get; init; }
        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }

    public static void Run()
    {
        var myPoint = new Point{ X = 10, Y = 20 };

        // declaration
        {
            (int x, int y) = myPoint;

            Console.WriteLine($"x = {x}, y = {y}");
        } 
        
        // assignment:
        {
            int x = 0;
            int y = 0;
            (x, y) = myPoint;

            Console.WriteLine($"x = {x}, y = {y}");
        }

        // declaration and assignment:
        {
            int x = 0;
            (x, int y) = myPoint;

            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}
