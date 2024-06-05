
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB13
{
    internal class Program
    {
        static bool BinarySearch(double[] array, double value)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (array[mid] == value)
                {
                    return true;
                }
                else if (array[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return false;
        }

        static bool LinearSearch(string[] array, string value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");
            // Масив дійсних чисел
            double[] numbers = { 1.2, 3.4, 5.6, 7.8, 9.0 };

            Console.Write("Введіть дійсне число для пошуку: ");
            double searchNumber = double.Parse(Console.ReadLine());

            bool foundNumber = BinarySearch(numbers, searchNumber);
            Console.WriteLine($"Число {searchNumber} {(foundNumber ? "знайдено" : "не знайдено")} в масиві.");

            // Масив слів
            string[] words = { "яблуко", "груша", "банан", "апельсин", "слива" };

            Console.Write("Введіть слово для пошуку: ");
            string searchWord = Console.ReadLine();

            bool foundWord = LinearSearch(words, searchWord);
            Console.WriteLine($"Слово {searchWord} {(foundWord ? "знайдено" : "не знайдено")} в масиві.");
        }
    }
}
