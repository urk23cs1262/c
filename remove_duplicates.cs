using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        int[] a = {1, 2, 2, 3, 5, 3, 4};

        HashSet<int> seen = new HashSet<int>();

        foreach (int n in a){
            if(seen.Add(n)){
                Console.Write(n + "");
            }
        }
        
    }
}