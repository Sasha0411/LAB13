
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB13
{
    internal class Program
    {
        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++) // Проходимо по елементах масиву
            {
                int minIndex = i; // Індекс мінімального елемента

                for (int j = i + 1; j < array.Length; j++) // Знаходимо мінімальний елемент
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Обмін місцями мінімального елемента з елементом на поточній позиції
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");
            int[] array = { 5, 2, 4, 1, 3 }; // Приклад масиву

            Console.WriteLine("Масив до сортування:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();

            SelectionSort(array); // Сортування масиву

            Console.WriteLine("Масив після сортування:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
        }
    }
}
