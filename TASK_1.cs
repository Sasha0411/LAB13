
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB13
{
    internal class Program
    {
        static int SumOfMainDiagonal(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");
            int n = 3; // Розмір матриці (можна змінювати)

            int[,] matrix = new int[n, n];

            // Заповнення матриці значеннями (замість Random можна використовувати будь-який спосіб)
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(100); // Числа від 0 до 99
                }
            }

            // Вивід матриці на екран
            Console.WriteLine("Матриця:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            int sum = SumOfMainDiagonal(matrix);
            Console.WriteLine($"Сума елементів головної діагоналі: {sum}");
        }
    }
}
