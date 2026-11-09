using System;
class Program{
    static void Main(){
        int[] a = {10, 20, 30, 40, 50};
        int result = Array.BinarySearch(a, 30);

        Console.WriteLine(result);
    }
}