using System.Reflection;

namespace CSharpNewFeatures.V11_02_GenericAttributes;

internal class Test
{
    // Before C# 11:
    public class MyTypeAttribute1 : Attribute 
    {
        public MyTypeAttribute1(Type t) 
            => ParamType = t; 
        public Type ParamType { get; }
    }

    // Since C# 11: 
    public class MyTypeAttribute2<T> : Attribute
    {
    }



    [MyTypeAttribute1(typeof(string))]
    public string Method1() => default;

    public static void CheckMethod1()
    {
        var t = typeof(Test);
        var m = t.GetMethod(nameof(Method1));
        var a = m?.GetCustomAttribute<MyTypeAttribute1>();

        if (a?.ParamType == typeof(string))
        {
            Console.WriteLine("It's a string!");
        }
    }

    [MyTypeAttribute2<string>()]
    public string Method2() => default;

    public static void CheckMethod2()
    {
        var t = typeof(Test);
        var m = t.GetMethod(nameof(Method2));
        var a = m?.GetCustomAttribute<MyTypeAttribute2<string>>();

        if (a?.GetType().GetGenericArguments()[0] == typeof(string))
        {
            Console.WriteLine("It's a string!");
        }
    }

    public static void Run()
    {
        CheckMethod1();
        CheckMethod2();
    }
}
