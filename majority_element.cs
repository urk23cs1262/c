using System;

class Program
{
    static void Main()
    {
        int[] a = { 2, 2, 1, 2, 3, 2, 2 };

        int candidate = 0, count = 0;

        foreach (int n in a)
        {
            if (count == 0)
                candidate = n;

            count += (n == candidate) ? 1 : -1;
        }

        count = 0;

        foreach (int n in a)
            if (n == candidate)
                count++;

        if (count > a.Length / 2)
            Console.WriteLine("Majority: " + candidate);
        else
            Console.WriteLine("No Majority Element");
    }
}