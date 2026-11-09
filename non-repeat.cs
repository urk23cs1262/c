using System;

class Program{
    static void Main(){
        string s = "swiss";

        foreach (char c in s){
            if(s.IndexOf(c) == s.LastIndexOf(c)){
                Console.WriteLine(c);
                break;
            }
        }
    }
}