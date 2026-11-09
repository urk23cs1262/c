using System;

class Program{
    static void Main(){
        int[] a = {1, 2, 3, 4, 5};
        int k = 2;
        int[] b = new int[a.Length];

        for (int i = 0; i < a.Length; i++){
            b[(i + k) % a.Length] = a[i];
        }
        Console.WriteLine(string.Join(" ", b));
    }
}