using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._15_Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of lines: ");
            int number = int.Parse(Console.ReadLine());
            int[,] spiral = new int[number, number];
            int row = 0;
            int col = 0;


            for (row = 0; row < number; row++)
            {
                for (col = 0; col <= row; col++)
                {
                    if ((col == 0) || (col == row))
                    {
                        spiral[row, col] = 1;
                    }
                    else
                    {
                        spiral[row, col] = spiral[row - 1, col] + spiral[row - 1, col - 1];
                    }
                }
            }
            for (int r = 0; r < number; r++)
            {
                for (int c = 0; c <= r; c++)
                {
                    Console.Write("{0,4}", spiral[r, c]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
