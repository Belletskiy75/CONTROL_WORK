using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());

        string[] source = new string[n];

        Console.WriteLine("Введите строки:");
        for (int i = 0; i < n; i++)
        {
            source[i] = Console.ReadLine();
        }
    }
}



