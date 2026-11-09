using System;

class Program{
    static void Main(){
        int[] a = {10, 20, 5, 4, 30};

        int first = int.MinValue;
        int second = int.MinValue;

        foreach (int n in a){
            if (n>first){
                second = first;
                first = n;
            }
            else if (n>second && n != first){
                second = n;
            }
        }

        if (second == int.MinValue){
            Console.WriteLine("No");
        }
        else{
            Console.WriteLine(second);
        }
    }
}