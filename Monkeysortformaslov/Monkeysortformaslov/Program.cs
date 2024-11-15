using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество чисел для сортировки: ");
        int n = int.Parse(Console.ReadLine()); 

        // Массив для хранения чисел
        int[] numbers = new int[n];

        Console.WriteLine("Введите числа:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Вызов сортировки обезьянкой
        MonkeySort(numbers);

        // Выводим отсортированные числа 
        Console.WriteLine("Отсортированные числа:");
        PrintArray(numbers);  
    }

    // Метод сортировки обезьянкой
    static void MonkeySort(int[] arr)
    {
        Random rand = new Random(); 

        // Пока массив не отсортирован
        while (!IsSorted(arr))
        {
            // Рандомно выбираем два элемента
            int i = rand.Next(arr.Length);   
            int j = rand.Next(arr.Length);   

            // Меняем местами
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            // Выводим массив после каждой перестановки
            Console.WriteLine("После перестановки: ");
            PrintArray(arr);
        }
    }

    // Метод проверки сортировки
    static bool IsSorted(int[] arr)
    {
        
        for (int i = 0; i < arr.Length - 1; i++)
        {
            // Если есть элемент, который больше последующего - массив не отсортирован
            if (arr[i] > arr[i + 1])
                return false; 
        }
        // Если все элементы в правильном порядке - массив отсортирован
        return true; 
    }

    // Метод для вывода массива
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");  
        }
        Console.WriteLine(); 
    }
}
