internal class Program
{
    static void Main(string[] args)
    {
        string Input(string text)
        {
            Console.Write($"{text} ");
            return Console.ReadLine();
        }

        void FillArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Input("Введите число: "));
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

        int CountPositiveNum(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    count++;
                }
            }
            return count;
        }

        // Задача 41: Пользователь вводит с клавиатуры M чисел. 
        // Посчитайте, сколько чисел больше 0 ввёл пользователь.

        void Task41()
        {
            int size = Convert.ToInt32(Input("Количество чисел:"));
            int[] numbers = new int[size];

            FillArray(numbers);
            PrintArray(numbers);
            Console.WriteLine($"Количество чисел больше нуля равно {CountPositiveNum(numbers)}");

        }
        // Task41();

        // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
        // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
        // значения b1, k1, b2 и k2 задаются пользователем.

        void Task43()
        {
            double b1 = Convert.ToDouble(Input("Введите коэффициент b1: "));
            double k1 = Convert.ToDouble(Input("Введите коэффициент k1: "));
            double b2 = Convert.ToDouble(Input("Введите коэффициент b2: "));
            double k2 = Convert.ToDouble(Input("Введите коэффициент k2: "));

            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            if (k1 * x + b1 == k2 * x + b2)
            {
                Console.WriteLine($"Решением заданных уравнений является точка пересечения с координатами ({x}; {y})");                    
            }
            else
            {
                 Console.WriteLine("Точки пересечения не существует - прямые параллельны.");
            }
           
        }
        // Task43();
    }
}