using System;
class Hello
{
    static void Main(string[] args)
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
        Console.WriteLine("The largest number is {0} ", max);
        Console.ReadLine();
    }

}

