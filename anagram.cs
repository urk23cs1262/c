using System;

class Program{
    static void Main(){
        string a = "listen";
        string b = "slient";

        char[] x = a.ToLower().ToCharArray();
        char[] y = b.ToLower().ToCharArray();

        if (new string(x) == new string(y)){
            Console.WriteLine("Anagram");
        }
        else{
            Console.WriteLine("Not anagram");
        }
    }
}