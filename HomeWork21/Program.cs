// Задача 21: Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


void XYRange(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)) + (Math.Pow((z1 - z2), 2)));
    Console.WriteLine(result);
}

Console.Write("Введите значение x1: ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение z1: ");
double z1 = double.Parse(Console.ReadLine());

Console.Write("Введите число x2: ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Введите число y2: ");
double y2 = double.Parse(Console.ReadLine());

Console.Write("Введите число z2: ");
double z2 = double.Parse(Console.ReadLine());

XYRange(x1, y1, z1, x2, y2, z2);