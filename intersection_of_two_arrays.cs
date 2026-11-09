using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        int[] a = {1, 2, 3, 4};
        int[] b = {3, 4, 5, 6};

        HashSet<int> set = new HashSet<int>(a);

        foreach (int n in b){
            if (set.Remove(n)){
                Console.WriteLine(n + " ");
            }
        }
    }
}