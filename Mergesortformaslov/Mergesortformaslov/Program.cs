using System;
using System.Linq;

namespace Sort.MergeSort
{
    internal class MergeSortProgram
    {
        static void Main()
        {
            // Ввод длины массива
            Console.WriteLine("Введите длину массива:");
            int massLength = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[massLength];

            // Ввод элементов массива по одному
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < massLength; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Сортировка массива с использованием MergeSort
            MergeSort(array);

            // Вывод отсортированного массива
            Console.WriteLine("Отсортированный массив:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }

        static void MergeSort(int[] mass)
        {
            Console.WriteLine("Начальный массив: " + string.Join(" ", mass));

            if (mass.Length <= 1)
            {
                // Если массив состоит из одного или нуля элементов, он уже отсортирован
                return; 
            }

            // Разделяем массив на две части
            int mid = mass.Length / 2;
            int[] left = mass.Take(mid).ToArray();  
            int[] right = mass.Skip(mid).ToArray(); 

            
            Console.WriteLine("\nРазделение массива: ");
            Console.WriteLine("Левая часть: " + string.Join(" ", left));
            Console.WriteLine("Правая часть: " + string.Join(" ", right));

            // сортируем обе части
            MergeSort(left);
            MergeSort(right);

            // Сливаем отсортированные части и сохраняем результат в исходный массив
            int[] merged = Merge(left, right);

            // Сохраняем отсортированные данные обратно в исходный массив
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = merged[i];
            }

            // Выводим массив после слияния на текущем шаге
            Console.WriteLine("\nМассив после слияния: ");
            Console.WriteLine(string.Join(" ", mass));
        }

        public static int[] Merge(int[] left, int[] right)
        {
            // создаем новый массив для хранения результата слияния
            // длина будет равна сумме длин массивов left и right
            int[] result = new int[left.Length + right.Length];

            // индекс для вставки элементов в массив result
            int index = 0;

            // индексы для обхода правого и левого массивов 
            int indexL = 0, indexR = 0;
            // Пока не завершился один из массивов
            while (indexL < left.Length && indexR < right.Length)
            {
                // Сравниваем элементы массива left и right
                // Если элемент из left меньше, то его вставляем в результат
                if (left[indexL] < right[indexR])
                {
                    // Вставляем элемент из left в результат
                    result[index++] = left[indexL++];
                }
                else
                {
                    // Если элемент из right меньше или равен, то вставляем его в результат
                    result[index++] = right[indexR++];
                }
            }

            // Если остались элементы в left, вставляем их в результат
            while (indexL < left.Length)
            {
                result[index++] = left[indexL++];
            }

            // Если остались элементы в right, вставляем их в результат
            while (indexR < right.Length)
            {
                result[index++] = right[indexR++];
            }

            // Возвращаем отсортированный массив после слияния
            return result;
        }
    }
}
