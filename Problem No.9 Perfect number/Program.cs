using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._9_Perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine("Number {0} is perfect.", number);
            }
            else
            {
                Console.WriteLine("Number {0} is not perfect.", number);
            }

        }
    }
}
