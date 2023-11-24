using System.Runtime.CompilerServices;

namespace CSharpNewFeatures.T41_RawStringLiterals;

internal class Test
{
    public static void Run()
    {
        string longMessage = """
           This is a long message.
           It has several lines.
               Some are indented 
                   more than others.
           Some should start at the first column.
           Some have "quoted text" in them.
           """;
        Console.WriteLine(longMessage);

        var longitude = 18.564654;
        var latitude = 54.687011;
        var location = $$"""
            You are at {{{longitude}}, {{latitude}}}
            """;
        Console.WriteLine(location);
    }

}
