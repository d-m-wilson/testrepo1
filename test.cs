using System;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("This is a test.");
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"args[{i}] = \"{args[i]}\"");
        }
    }
}