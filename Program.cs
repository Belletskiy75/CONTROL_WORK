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
    
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (source[i].Length <= 3)
                count++;
        }
   
        string[] result = new string[count];
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            if (source[i].Length <= 3)
            {
                result[index] = source[i];
                index++;
            }
        }

        Console.WriteLine("\nСтроки длиной <= 3 символов:");
        Console.Write("[ ");
        foreach (var str in result)
        {
            Console.Write($"\"{str}\" ");
        }
        Console.WriteLine("]");
    }
}

