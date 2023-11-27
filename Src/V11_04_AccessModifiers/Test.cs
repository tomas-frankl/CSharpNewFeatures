namespace CSharpNewFeatures.V11_04_AccessModifiers;

public class Class1 //anywhere
{
}

internal class Class2 //within same assembly
{
}

file class Class3 //within same file
{
}

class Class
{
    public int _field1;             //anywhere
    protected int _field2;          //derived class
    private int _field3;            //only within same class
    internal int _field4;           //within same assembly
    protected internal int _field5; //derived class or within same assembly
    private protected int _field6;  //only derived class within same assembly
}

internal class Test
{
    public static void Run()
    {
    }
}
