using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N(N > 1): ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K(K > N): ");
            int K = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;
            int factorialKN = 1;
            for (int i = N; i > 1; i--)
            {
                factorialN *= i;
            }

            for (int i = K; i > 1; i--)
            {
                factorialK *= i;
            }

            for (int i = K - N; i > 1; i--)
            {
                factorialKN *= i;
            }

            Console.WriteLine("N!*K!/(K-N)! = {0}", (factorialN * factorialK) / factorialKN);

        }
    }
}
