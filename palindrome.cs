using System;

class Program
{
    static void Main()
    {
        string s = "madam";
        string rev = "";

        for (int i = s.Length - 1; i >= 0; i--)
            rev += s[i];

        if (s == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}