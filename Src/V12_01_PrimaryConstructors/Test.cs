namespace CSharpNewFeatures.V12_01_PrimaryConstructors;

internal class Test
{
    public readonly struct Distance(double dx, double dy)
    {
        public readonly double Magnitude { get; } = Math.Sqrt(dx * dx + dy * dy);
        public readonly double Direction { get; } = Math.Atan2(dy, dx);

        public override string ToString()
        {
            return $"dX:{dx:F2} dY:{dy:F2} mag:{Magnitude:F2} dir:{Direction:F2}";
        }
    }

    public static void Run()
    {
        var dist = new Distance(1, 1);
        Console.WriteLine(dist);
    }
}
