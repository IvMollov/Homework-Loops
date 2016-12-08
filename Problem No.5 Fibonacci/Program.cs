using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._5_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int fibonacci1 = 0;
            int fibonacci2 = 1;
            int fibonacci;
            Console.Write("First {0} members are: {1}, {2}, ", number, fibonacci1, fibonacci2);
            for (int i = 3; i <= number; i++)
            {
                fibonacci = fibonacci1 + fibonacci2;
                fibonacci1 = fibonacci2;
                fibonacci2 = fibonacci;
                Console.Write("{0}, ", fibonacci);
            }

        }
    }
}
