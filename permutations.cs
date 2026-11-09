using System;

class Program
{
    static void Permute(string s, int index)
    {
        if (index == s.Length)
        {
            Console.WriteLine(s);
            return;
        }

        for (int i = index; i < s.Length; i++)
        {
            char[] a = s.ToCharArray();

            char temp = a[index];
            a[index] = a[i];
            a[i] = temp;

            Permute(new string(a), index + 1);
        }
    }

    static void Main()
    {
        Permute("ABC", 0);
    }
}