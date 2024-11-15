using System;

class Program
{
    static void Main()
    {
        // Запрос числа элементов для сортировки
        Console.Write("Введите количество чисел для сортировки: ");
        int n = int.Parse(Console.ReadLine());

        // Массив для хранения введенных чисел
        int[] numbers = new int[n];

        // Ввод чисел с клавиатуры
        Console.WriteLine("Введите числа:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine()); 
        }

       
        BubbleSort(numbers);

        // Вывод окончательно отсортированных чисел
        Console.WriteLine("Отсортированные числа:");
        PrintArray(numbers);  
    }

    // Метод для сортировки пузырьком
    static void BubbleSort(int[] arr)
    {
        // Определяем размер массива
        int n = arr.Length;

        // Сортировка пузырьком
       
        for (int i = 0; i < n - 1; i++)
        {  
            for (int j = 0; j < n - 1 - i; j++) 
            {
                // Если текущий элемент больше следующего, то меняем их местами
                if (arr[j] > arr[j + 1])
                {
                    // меняем местами
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    // Выводим массив после каждой перестановки
                    Console.WriteLine("После перестановки: ");
                    PrintArray(arr); 
                }
            }
        }
    }

    // Метод для вывода массива
    static void PrintArray(int[] arr)
    {
        // Проходим по каждому элементу массива и выводим его
        foreach (int num in arr)
        {
            Console.Write(num + " "); 
        }
        Console.WriteLine();  
    }
}


