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

        int GetPositiveSumm(int[] numbers)
        {
            int summ = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) summ += numbers[i];
            }
            return summ;
        }

        int GetNegativeSumm(int[] numbers)
        {
            int summ = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0) summ += numbers[i];
            }
            return summ;
        }

        void ChangedArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= -1;
            }
        }

        void FindElement(int[] numbers, int num)
        {
            bool flag = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    flag = true;
                }

            }
            if (flag) Console.WriteLine("Заданное число присутствует в массиве");
            else Console.WriteLine("Заданное число отсутствует в массиве");
        }

        int CountElementInSegment(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 10 && numbers[i] <= 99)
                {
                    count++;
                }
            }
            return count;
        }

        // Задача 31: Задайте массив из 12 элементов, заполненный 
        // случайными числами из промежутка [-9, 9]. Найдите сумму 
        // отрицательных и положительных элементов массива.
        // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
        // положительных чисел равна 29, сумма отрицательных равна -20

        void Task31()
        {
            int size = 10;
            int[] numbers = new int[size];

            FillArray(numbers);
            PrintArray(numbers);
            int summ = GetPositiveSumm(numbers);
            Console.WriteLine($"Сумма положительных элементов массива равна {summ}.");
            Console.WriteLine($"Сумма отрицательных элементов массива равна {GetNegativeSumm(numbers)}.");
        }
        // Task31();

        // Задача 32: Напишите программу замены элементов массива: 
        // положительные элементы замените на соответствующие отрицательные, и наоборот.
        // [-4, -8, 8, 2] -> [4, 8, -8, -2]

        void Task32()
        {
            int size = 10;
            int[] numbers = new int[size];

            FillArray(numbers);
            PrintArray(numbers);
            ChangedArray(numbers);
            PrintArray(numbers);
        }
        // Task32();

        // Задача 33: Задайте массив. Напишите программу, которая определяет,
        // присутствует ли заданное число в массиве.

        void Task33()
        {
            int size = 15;
            int[] numbers = new int[size];

            FillArray(numbers);
            PrintArray(numbers);
            Console.WriteLine("Введите число: ");
            int currentNumber = Convert.ToInt32(Console.ReadLine());
            FindElement(numbers, currentNumber);
        }
        // Task33();     

        // Задача 35: Задайте одномерный массив из 10 случайных чисел. 
        // Найдите количество элементов массива, значения которых лежат в 
        // отрезке [10,99]. 
        // [5, 18, 123, 6, 2] -> 1
        // [1, 2, 3, 6, 2] -> 0
        // [10, 11, 12, 13, 14] -> 5   

        void Task35()
        {
            int size = 10;
            int[] numbers = new int[size];

            FillArray(numbers, 1, 200);
            PrintArray(numbers);
            Console.WriteLine($"Количество элементов от 10 до 99 в массиве равно {CountElementInSegment(numbers)}.");
        }
        // Task35();
    }
}


