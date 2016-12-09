using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._12_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            StringBuilder reverse = new StringBuilder();
            int control;
            char temp;
            for (int i = number; i > 0; i /= 10)
            {
                control = i % 10;
                text.Append(control);
            }

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse.Append(text[i]);

            }

            temp = reverse[0];
            reverse[0] = reverse[reverse.Length - 1];
            reverse[reverse.Length - 1] = temp;
            Console.Write(reverse.ToString());

            Console.ReadLine();
        }
    }
}
