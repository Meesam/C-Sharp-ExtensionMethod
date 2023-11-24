using ExtensionMethod;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Extension");
        List<int> list = new List<int>() { 1, 2, 3 };
        list.PrintListElement();
        
    }
}