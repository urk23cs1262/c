using System;

class Program{
    static void Main(){
        string s = "hello";

        for (int i=0;i<s.Length;i++){
            if(s.IndexOf(s[i]) == i){
                int count=0;
                
                foreach(char c in s){
                    if(c==s[i]){
                        count++;
                    }
                }
            Console.WriteLine(s[i] + " = "+ count);
            }
        }
    }
}