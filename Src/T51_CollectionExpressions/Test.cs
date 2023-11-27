﻿namespace CSharpNewFeatures.T51_CollectionExpressions;

internal class Test
{
    public static void Run()
    {
        // Create an array:
        int[] a = [1, 2, 3, 4, 5, 6, 7, 8];

        // Create a list:
        List<string> b = ["one", "two", "three"];

        // Create a span
        Span<char> c = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i'];

        // Create a jagged 2D array:
        int[][] twoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

        // Create a jagged 2D array from variables:
        int[] row0 = [1, 2, 3];
        int[] row1 = [4, 5, 6];
        int[] row2 = [7, 8, 9];
        int[][] twoDFromVariables = [row0, row1, row2];


        
        // Create a 2D array using spread operator:
        int[] part0 = [1, 2, 3];
        int[] part1 = [4, 5, 6];
        int[] part2 = [7, 8, 9];
        int[] single = [.. part0, .. part1, .. part2];
        foreach (var element in single)
        {
            Console.Write($"{element}, ");
        }
    }
}
