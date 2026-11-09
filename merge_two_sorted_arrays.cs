using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        int[] a = {1, 2, 3};
        int[] b = {4, 5, 6};

        List<int> c = new List<int>(a);

        c.AddRange(b);

        Console.WriteLine(string.Join(" ", c));
    }
}