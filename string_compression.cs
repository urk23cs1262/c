using System;
using System.Text;

class Program{
    static void Main(){
        string s = "aabcccccaaa";
        StringBuilder result = new StringBuilder();

        for (int i = 0; i<s.Length; i++){
            int count = 1;

            while(i < s.Length - 1 && s[i] == s[i + 1]){
                count++;
                i++;
            }
            result.Append(s[i]).Append(count);
        }
        Console.WriteLine(result);
    }
}