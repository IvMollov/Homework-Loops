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
            StringBuilder numberH = new StringBuilder();
            while (number != 0)
            {
                if (number % dec == 0)
                {
                    numberH.Append("0");
                }
                if (number % dec == 1)
                {
                    numberH.Append("1");
                }
                if (number % dec == 2)
                {
                    numberH.Append("2");
                }
                if (number % dec == 3)
                {
                    numberH.Append("3");
                }
                if (number % dec == 4)
                {
                    numberH.Append("4");
                }
                if (number % dec == 5)
                {
                    numberH.Append("5");
                }
                if (number % dec == 6)
                {
                    numberH.Append("6");
                }
                if (number % dec == 7)
                {
                    numberH.Append("7");
                }
                if (number % dec == 8)
                {
                    numberH.Append("8");
                }
                if (number % dec == 9)
                {
                    numberH.Append("9");
                }
                if (number % dec == 10)
                {
                    numberH.Append("A");
                }
                if (number % dec == 11)
                {
                    numberH.Append("B");
                }
                if (number % dec == 12)
                {
                    numberH.Append("C");
                }
                if (number % dec == 13)
                {
                    numberH.Append("D");
                }
                if (number % dec == 14)
                {
                    numberH.Append("E");
                }
                if (number % dec == 15)
                {
                    numberH.Append("F");
                }
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
