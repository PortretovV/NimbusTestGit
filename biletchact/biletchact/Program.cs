using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biletchact
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] mass = new int[6];
            int del;
            for (int i = 1001; i <= 999999; i++)
            {
                del = i;
                for (int j = mass.Length - 1; 0 <= j; j--)
                {
                    mass[j] = del % 10;
                    del /= 10;
                }
                if (mass[0] + mass[1] + mass[2] == mass[3] + mass[4] + mass[5]) count++;
            }
            Console.Write(count + " ");
            Console.ReadKey();
        }
    }
}
