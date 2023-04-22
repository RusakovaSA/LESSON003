// Принимаем на вход координаты X и Y, проверяем четверть точки (1, 2, 3, 4)

Console.WriteLine("Введине значение координты X - ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введине значение координты Y - ");
int y = int.Parse(Console.ReadLine());

string ZoneXY (int x, int y)
{
    if (x > 0 && y > 0)
    {
        return ("Точка лежит в первой четверти оси координат.");
    }
    else if (x < 0 && y > 0)
    {
        return ("Точка лежит во второй четверти оси координат.");
    }
    else if (x < 0 && y < 0)
    {
        return ("Точка лежит в третьей четверти оси координат.");
    }
    else if (x > 0 && y <0)
    {
        return ("Точка лежит в четвертой четверти оси координат.");
    }
    else
    {
        return ("Точка лежит на оси координат.");
    }

}

Console.WriteLine(ZoneXY (x, y));