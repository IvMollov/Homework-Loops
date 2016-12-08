using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._11_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  number: ");
            int number = int.Parse(Console.ReadLine());
            string stringNumber = number.ToString();
            StringBuilder palindrome = new StringBuilder();
            for (int i = stringNumber.Length - 1; i >= 0; i--)
            {
                palindrome.Append(stringNumber[i]);
            }

            string test = palindrome.ToString();
            int singleNumber = Convert.ToInt32(test);

            if (singleNumber == number)
            {
                Console.WriteLine("Number {0} is palindrome.", number);
            }
            else
            {
                Console.WriteLine("Number {0} is not palindrome.", number);
            }

        }
    }
}
