// По заданному номеру четверти вывести диапозон возможных значений x и y

Console.WriteLine("Введите номер четверти - ");
int Quarter = int.Parse(Console.ReadLine());



string ZoneXY(int Quarter)
{
    if (Quarter == 1)
    {
        return ("Значение x > 0 и значение y > 0.");
    }
    else if (Quarter == 2)
    {
        return ("Значение x < 0 и значение y > 0.");
    }
    else if (Quarter == 3)
    {
        return ("Значение x < 0 и значение y < 0.");
    }
    else if (Quarter == 4)
    {
        return ("Значение x > 0 и значение y < 0.");
    }
    else
    {
        return ("В этой системе координат нет заданной четверти.");
    }

}

Console.WriteLine(ZoneXY(Quarter));
