// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int StepenNum(int a, int b)
{
    if (a != 0 && b > 0)
    {
        return Convert.ToInt32(Math.Pow(a, b));
    }
        else if (a != 0 && b < 0)
        {
            return Convert.ToInt32(Math.Pow(a, Math.Abs(b)));
        }
            else if (a == 0 && b != 0)
            {
                return 0;
            }
                else if (a != 0 && b == 0)
                {
                    return 1;
                }
    else
    {
        return -1;
    }
                    
}

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"Число " + a + " в степени " + b + " равно " + StepenNum(a, b));