using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
class Test
{
    static string Max()
    {
        int[] number = new int[10];
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            number[i] = Int32.Parse(Console.ReadLine());
        }
        int max = number[0];
        for (int j = 1; j < 10; j++)
        {
            if (number[j] > max)
                max = number[j];
        }
        string m = max.ToString();
        return m;
    }
    static string Date()
    {
        DateTime Res = DateTime.Now;
        string d = Res.ToString();
        return d;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Chose:\n1.Maximum\n2.Date");
        string a = Console.ReadLine();
        int b = int.Parse(a);
        if (b == 1)
        {
            Console.WriteLine(Max());
            Console.ReadLine();
        }
        if (b == 2)
        {
            Console.WriteLine(Date());
            Console.ReadLine();
        }
    }
}