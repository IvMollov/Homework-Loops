using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._2_Sequence_of_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of sequence: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int max = int.MinValue;
            int min = int.MaxValue;
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                temp = array[i];
                if (temp > max)
                {
                    max = temp;
                }
                if (temp < min)
                {
                    min = temp;
                }
            }
            Console.WriteLine("Maximal value is {0}, minimal is {1}", max, min);


        }
    }
}
