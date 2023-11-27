namespace CSharpNewFeatures.V09_04_Patterns;

//init only members by default
internal class Test
{
    public static void Run()
    {
        TypePatterns();
        ConstantPatterns();
        RelationalPatterns();
        LogicalPatterns();
        PropertyPatterns();
        PositionalPatterns();

        ListPatterns();
    }

    private static void TypePatterns()
    {
        {
            object greeting = "Hello, World!";
            if (greeting is string message)
            {
                Console.WriteLine(message.ToLower());
            }
        }

        {
            int GetTypeId(object source) => source switch
            {
                null => 0,
                string s => 1,
                Int32 => 2,
                _ => 3,
            };

            Console.WriteLine(GetTypeId(null)); //0
            Console.WriteLine(GetTypeId("s")); //1
            Console.WriteLine(GetTypeId(1)); //2
            Console.WriteLine(GetTypeId(DateTime.Now)); //3
        }
    }

    private static void ConstantPatterns()
    {
        static decimal GetGroupTicketPrice(int visitorCount) => visitorCount switch
        {
            1 => 12.0m,
            2 => 20.0m,
            3 => 27.0m,
            0 => 0.0m,
            _ => throw new ArgumentException($"Not supported number of visitors: {visitorCount}")
        };

        Console.WriteLine(GetGroupTicketPrice(1)); //12.0
    }

    private static void RelationalPatterns()
    {
        {
            static string Classify(double measurement) 
                => measurement switch 
                { 
                    < -4.0 => "Too low", 
                    > 10.0 => "Too high", 
                    double.NaN => "Unknown", 
                    _ => "Acceptable",
                };

            Console.WriteLine(Classify(20)); //Too high
        }

        {
            static string GetCalendarSeason(DateTime date)
                => date.Month switch
                {
                    >= 3 and < 6 => "spring",
                    >= 6 and < 9 => "summer",
                    >= 9 and < 12 => "autumn",
                    12 or (>= 1 and < 3) => "winter",
                    _ => throw new ArgumentOutOfRangeException(nameof(date))
                };

            var myDate = new DateTime(2022, 11, 28);
            Console.WriteLine(GetCalendarSeason(myDate)); //autumn
        }

    }

    private static void LogicalPatterns()
    {
        bool IsLetter(char c) 
            => c is (>= 'a' and <= 'z' or >= 'A' and <= 'Z');

        bool IsLetterOrSeparatorOrSpace(char c) 
            => c is ((>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',' or ' ');

        var isLetter = IsLetter('d');
        var isSeparator = IsLetterOrSeparatorOrSpace(',');
    }

    #region PropertyPatterns
    record Point(int X, int Y);
    record Segment(Point Start, Point End);
    private static void PropertyPatterns()
    {
        {
            bool IsConferenceDay(DateTime date)
                => date is { Year: 2020, Month: 5, Day: 19 or 20 or 21 };

            bool isConferenceDay1 = IsConferenceDay(new DateTime(2020, 5, 20)); //true
            bool isConferenceDay2 = IsConferenceDay(new DateTime(2020, 5, 17)); //false
        }

        {
            bool IsAnyEndOnXAxis(Segment segment)
                => segment is { Start: { Y: 0 } } or { End: { Y: 0 } };

            bool IsAnyEndOnXAxisB(Segment segment) //since C# 9.0 - nested properties pattern
                => segment is { Start.Y: 0 } or { End.Y: 0 };

            bool isAnyEndOnXAxis1 = IsAnyEndOnXAxis(new Segment(new Point(0, 0), new Point(0, 1))); //true
            bool isAnyEndOnXAxis2 = IsAnyEndOnXAxis(new Segment(new Point(1, 6), new Point(3, 1))); //false

            bool isAnyEndOnXAxisB1 = IsAnyEndOnXAxisB(new Segment(new Point(0, 0), new Point(0, 1))); //true
            bool isAnyEndOnXAxisB2 = IsAnyEndOnXAxisB(new Segment(new Point(1, 6), new Point(3, 1))); //false
        }

    }
    #endregion

    #region PositionalPatterns
    readonly struct PointXY
    {
        public int X { get; } 
        public int Y { get; } 
        public PointXY(int x, int y) => (X, Y) = (x, y); 
        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }
    private static void PositionalPatterns()
    {
        string Classify(PointXY point) => point switch
        {
            (0, 0) => "Origin",
            (1, 0) => "positive X basis end",
            (0, 1) => "positive Y basis end",
            (_, 0) => "on X axis",
            (0, _) => "on Y axis",
            _ => "Just a point"
        };

        Console.WriteLine(Classify(new PointXY(0, 0)));//Origin
    }
    #endregion

    private static void ListPatterns()
    {
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers is [1, 2, 3]); // True
            Console.WriteLine(numbers is [1, 2, 4]); // False
            Console.WriteLine(numbers is [1, 2, 3, 4]); // False
            Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]); // True
        }

        {
            List<int> numbers = new() { 1, 2, 3 };
            if (numbers is [var first, _, _])
            {
                Console.WriteLine($"The first element of a three-item list is {first}.");
            }
        }
    }
}
