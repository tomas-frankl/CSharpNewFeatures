﻿namespace CSharpNewFeatures.V12_07_UsingAlias;

using Point = (int x, int y);
using MyArray = int[];

internal class Test
{
    public static void Run()
    {
        Point p = (5, 10);
        Console.WriteLine(p.x);
        Console.WriteLine(p.y);

        MyArray array = [1, 2, 3, 4, 5 ];
        foreach (var item in array) Console.WriteLine(item);
    }
}
