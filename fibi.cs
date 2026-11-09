using System;

class Program
{
    static void Main()
    {
        long a=0, b=1;

        for (int i = 1; i <= 50; i++)
        {
            Console.Write(a + " ");
            long c=a+b;
            a=b;
            b=c;
        }

    }
}