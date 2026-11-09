using System;

class Program{
    static void Main(){
        int n = 13;
        int count = 0;

        while (n != 0){
            n = n & (n - 1);
            count++;
        }
        Console.WriteLine("Set Bits: " + count);
    }
}