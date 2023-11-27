namespace CSharpNewFeatures.T54_DefaultLambdaParams2;

internal class Test
{
    private delegate int IncrementByDelegate(int source, int increment = 1);

    private static int MyIncrementFunction(int source, int increment = 1) => source + increment;

    private static void MyMethod(IncrementByDelegate myDelegate)
    {
        Console.WriteLine(myDelegate(5, 2));
        Console.WriteLine(myDelegate(5));
    }

    public static void Run()
    {
        MyMethod(MyIncrementFunction);
        
        MyMethod((int source, int increment = 1) => source + increment);
    }
}
