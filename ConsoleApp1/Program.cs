using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] scores = new int[5];
        Console.WriteLine("Enter 5 scores:");

        for (int i = 0; i < 5; i++)
        {
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += scores[i];
        }

        double average = (double)sum / 5;

        if (average >= 75)
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }
}
