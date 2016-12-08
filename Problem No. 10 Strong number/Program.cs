using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._10_Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int factorial = 1;
            int singleNumber;
            string stringNumber = number.ToString();
            for (int i = 0; i < stringNumber.Length; i++)
            {
                singleNumber = (int)Char.GetNumericValue(stringNumber[i]);
                for (int j = singleNumber; j > 0; j--)
                {
                    factorial *= j;
                }
                sum += factorial;
                factorial = 1;
            }

            if (sum == number)
            {
                Console.WriteLine("Number {0} is strong.", number);
            }
            else
            {
                Console.WriteLine("Number {0} is not strong.", number);
            }

        }
    }
}
