using System.Runtime.CompilerServices;

namespace CSharpNewFeatures.T31_ConstantInterpolatedString;

internal class Test
{
    public static void Run()
    {
        const string language = "C#";
        const string platform = ".NET";
        const string version = "10.0";

        const string fullProductName = $"{platform} - Language: {language} Version: {version}";

        Console.WriteLine(fullProductName); //.NET - Language: C# Version: 10.0
    }
}
