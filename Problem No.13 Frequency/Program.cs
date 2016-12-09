using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._13_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            StringBuilder reverse = new StringBuilder();
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] newArray = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = number; i > 0; i /= 10)
            {
                if ((i % 10) == 0)
                {

                    newArray[i % 10]++;
                }
                else if ((i % 10) == 1)
                {

                    newArray[i % 10]++;
                }
                else if ((i % 10) == 2)
                {

                    newArray[i % 10]++;
                }
                else if ((i % 10) == 3)
                {

                    newArray[i % 10]++;
                }
                else if ((i % 10) == 4)
                {

                    newArray[i % 10]++;
                }
                else if ((i % 10) == 5)
                {

                    newArray[i % 10]++;
                }
                else if ((i % 10) == 6)
                {

                    newArray[i % 10]++;
                }
                else if ((i % 10) == 7)
                {

                    newArray[i % 10]++;
                }
                else if ((i % 10) == 8)
                {

                    newArray[i % 10]++;
                }
                else if ((i % 10) == 9)
                {

                    newArray[i % 10] = 1;
                }

            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Frequency of {0} = {1}", array[i], newArray[i]);
            }

            Console.ReadLine();
        }
    }
}
