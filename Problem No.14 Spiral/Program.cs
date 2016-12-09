using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._14_Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter positive number (<20): ");
            int number = int.Parse(Console.ReadLine());
            int[,] spiral = new int[number, number];
            int row = 0;
            int col = 0;
            string direction = "right";
            int maxRotations = number * number;

            for (int i = 1; i <= maxRotations; i++)
            {
                if (direction == "right" && (col > number - 1 || spiral[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > number - 1 || spiral[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || spiral[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && (row < 0 || spiral[row, col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                spiral[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            for (int r = 0; r < number; r++)
            {
                for (int c = 0; c < number; c++)
                {
                    Console.Write("{0,4}", spiral[r, c]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
