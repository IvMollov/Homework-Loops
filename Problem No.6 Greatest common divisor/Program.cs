using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._6_Greatest_common_divisor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number 1: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int numberTwo = int.Parse(Console.ReadLine());

            Console.Write("Greatest common divisor (GCD) of ({0}, {1}) is: ", numberOne, numberTwo);
            GCD(numberOne, numberTwo);

        }

        public static void GCD(int numberOne, int numberTwo)
        {
            while (numberTwo != 0)
            {
                int temp = numberTwo;
                numberTwo = numberOne % numberTwo;
                numberOne = temp;
            }
            Console.Write(numberOne);
        }

    }
}

