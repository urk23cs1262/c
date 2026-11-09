using System;

class Program{
    static void Main(){
        string s = "I Love You";
        string[] a = s.Split(' ');

        for (int i = a.Length - 1; i >= 0; i--){
            Console.Write(a[i] + " ");
        }
    }
}