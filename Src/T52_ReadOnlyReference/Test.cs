namespace CSharpNewFeatures.T52_ReadOnlyReference;

internal class Test
{
    static void MyMethod(in DateTime myDate)
    {
        //this is allowed
        Console.WriteLine(myDate);
        var dateB= myDate.AddDays(5);

        //this is not allowed
        //myDate = DateTime.Now;
        //myDate.Hour = 10;
    }

    public static void Run()
    {
        var dt = new DateTime();
        MyMethod(dt);
    }
}
