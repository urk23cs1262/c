using System;
class Program{
    static void Main(){
        int[] a = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        int sum = 0;
        int max = 0;

        foreach (int n in a){
            sum += n;

            if (sum > max){
                max = sum;
            }
            if (sum < 0){
                sum = 0;
            }
        }
        Console.WriteLine("Max sum: " + max);
    }
}