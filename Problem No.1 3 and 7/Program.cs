using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._1_3_and_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number bigger than 1: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (!((i % 3 == 0) || (i % 7 == 0)))
                {
                    Console.Write("{0}, ", i);
                }
            }

        }
    }
}
