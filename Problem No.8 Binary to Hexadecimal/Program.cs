using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._8_Binary_to_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            string binaryNumber = Console.ReadLine();
            int number = Convert.ToInt32(binaryNumber, 2);
            int dec = 16;
            char[] hexa = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            StringBuilder numberH = new StringBuilder();

            while (number != 0)
            {
                int lastDigit = number % dec;
                numberH.Append(hexa[lastDigit]);

                number = number / dec;
            }

            Console.Write("Hexadecimal number is: ");
            for (int i = numberH.Length - 1; i >= 0; i--)
            {
                Console.Write(numberH[i]);
            }


            Console.ReadLine();
        }
    }
}
