
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB13
{
    internal class Program
    {
        static int IterativeSumOfPowersOfTwo(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (int)Math.Pow(2, i - 1);
            }

            return sum;
        }
            static int RecursiveSumOfPowersOfTwo(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return (int)Math.Pow(2, n - 1) + RecursiveSumOfPowersOfTwo(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");
            Console.Write("Введіть ціле число N: ");
            int n = int.Parse(Console.ReadLine());

            int recursiveSum = RecursiveSumOfPowersOfTwo(n);
            int iterativeSum = IterativeSumOfPowersOfTwo(n);

            Console.WriteLine($"Рекурсивна сума S = {recursiveSum}");
            Console.WriteLine($"Ітеративна сума S = {iterativeSum}");
        }
    }
}
