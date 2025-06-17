using System;

namespace Test

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public Program()
    {

    }
    public void CalculateAndPrint(int a, int b)
    {
        int result = a - b;
        Console.WriteLine("My Result is: " + result);
    }
    public void NewGlobalTestMethod()
    {
        Console.WriteLine("Bello.");
    }
}
