using System;

class Singleton
{
    private static readonly Lazy<Singleton> instance =
        new Lazy<Singleton>(() => new Singleton());

    private Singleton()
    {
        Console.WriteLine("Object Created");
    }

    public static Singleton Instance
    {
        get { return instance.Value; }
    }
}

class Program
{
    static void Main()
    {
        Singleton a = Singleton.Instance;
        Singleton b = Singleton.Instance;

        Console.WriteLine(a == b);
    }
}