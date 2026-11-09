using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        string s = "{[()]}";
        Stack<char> st = new Stack<char>();

        foreach (char c in s){
            if (c=='(' || c=='{' || c=='['){
                st.Push(c);
            }
            else{
                if (st.Count==0){
                    Console.WriteLine("Not Balanced");
                    return;
                }
                
                char t = st.Pop();
                
                if ((c==')' && t!='(') || (c=='}' && t!='{') || (c==']' && t!='[')){
                    Console.WriteLine("Not Balanced");
                    return;
                }
            }

        }       
        Console.WriteLine(st.Count == 0 ? "Balanced":"Not Balanced");
    }
}