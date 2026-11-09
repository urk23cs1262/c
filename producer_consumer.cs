using System;
using System.Collections.Generic;

class Program{
    static void Main(){

        Queue<int> q = new Queue<int>();

        for (int i = 1; i <= 5; i++){
            q.Enqueue(i);
            Console.WriteLine("Produced: " + i);
        }
        while (q.Count > 0){
            Console.WriteLine("Consumed: " + q.Dequeue());
        }
    }
}