using System;

class Program{
    static void Main(){
        int[] a = {1, 2, 4, 5};
        int n = 5;

        int total = n * (n + 1) / 2;
        int sum = 0;

        foreach(int x in a){
            sum += x;
        }
        int y=total - sum;
        Console.WriteLine("Missing: " + y);
    }
}