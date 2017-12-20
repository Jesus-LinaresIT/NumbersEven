using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        int d;
        double e;

        d = N / 2;
        e = (double) N / 2;

        if (d - e == 0)
        {
            Console.WriteLine("Not Weird");
        }
        else
        {
                Console.WriteLine("Weird");
        }

        Console.ReadKey();
    }
}
