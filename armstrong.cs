using System;

class Program{
    static void Main(){
        int n = 153;
        int temp = n;
        int sum = 0;

        while(temp > 0){
            int r = temp % 10;
            sum += r * r * r;
            temp /= 10;
        }
        Console.WriteLine(sum == n ? "Arm":"Not arm");
    }
}