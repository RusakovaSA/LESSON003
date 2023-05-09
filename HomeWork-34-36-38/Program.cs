internal class Program
{
    static void Main(string[] args)
    {
        void FillArray(int[] numbers, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(minValue, maxValue);
            }
        }

        void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }

        int CountEvenNums(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        int GetSummNegativeOddIndex(int[] numbers)
        {
            int summ = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 1) summ += numbers[i];
            }
            return summ;
        }

        void FillArrayDouble(double[] numbers, int minValue = 0, int maxValue = 10)
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(minValue, maxValue) + rnd.NextDouble();
            }
        }

        void PrintArrayDouble(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} ");
            }
            Console.WriteLine();
        }

        double DifferenceMaxMinNums(double[] numbers)
        {
            double min = numbers[0];
            double max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                
                if (max < numbers[i]) max = numbers[i];
                if (min > numbers[i]) min = numbers[i];
            }
            Console.WriteLine($"Максимальный элемент равен {max}");
            Console.WriteLine($"Минимальный элемент равен {min}");
            return max-min;
        }
        // Задача 34: Задайте массив заполненный случайными 
        // положительными трёхзначными числами. Напишите 
        // программу, которая покажет количество чётных чисел в 
        // массиве.

        void Task34()
        {
            int size = 15;
            int[] numbers = new int[size];
            FillArray(numbers, 100, 999);
            PrintArray(numbers);
            Console.WriteLine($"Количество чётных чисел в массиве {CountEvenNums(numbers)}");
        }
        // Task34();

        // Задача 36: Задайте одномерный массив, заполненный 
        // случайными числами. Найдите сумму элементов с 
        // нечётными индексами.

        void Task36()
        {
            int size = 15;
            int[] numbers = new int[size];
            FillArray(numbers, 1, 100);
            PrintArray(numbers);
            Console.WriteLine($"Сумма элементов с нечетными индексами в массиве равна {GetSummNegativeOddIndex(numbers)}");
        }
        // Task36();

        // Задача 38: Задайте массив вещественных чисел. Найдите 
        // разницу между максимальным и минимальным 
        // элементами массива.

        void Task38()
        {
            int size = 10;
            double[] numbers = new double[size];
            FillArrayDouble(numbers);
            PrintArrayDouble(numbers);
            Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DifferenceMaxMinNums(numbers)}.");
        }
        // Task38();

    }
}
