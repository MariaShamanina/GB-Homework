// Задача 1: 
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n % 7 == 0 && n % 23 == 0)
//     Console.Write($"Число {n} кратно одновременно 7 и 23");
// else 
//     Console.Write($"Число {n} не кратно одновременно 7 и 23");


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n == 0)
// {
//     Console.Write("Вы ошиблись!\nВведите любое число, кроме 0: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// while (m == 0)
// {
//     Console.Write("Вы ошиблись!\nВведите любое число, кроме 0: ");
//     m = int.Parse(Console.ReadLine()!);
// }
// if (n > 0 && m > 0)
//     Console.Write("Координатная четверть №1");
// else if (n > 0 && m < 0)
//     Console.Write("Координатная четверть №2");
// else if (n < 0 && m < 0)
//     Console.Write("Координатная четверть №3");
// else
//     Console.Write("Координатная четверть №4");

//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

// Console.Clear();
// Console.Write("Введите число от 10 до 99: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 10 || n > 99)
// {
//     Console.Write("Вы ошиблись!\nВведите число от 10 до 99: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// if (n / 10 > n % 10)
//     Console.Write($"Число {n / 10} больше");
// else
//     Console.Write($"Число {n % 10} больше");

Console.Clear();
Console.Write("Введите любое натуральное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 0 )
{
    Console.Write("Вы ошиблись!\nВведите любое натуральное число: ");
    n = int.Parse(Console.ReadLine()!);
}
while (n > 0)
{
    int m = n % 10;
    n /= 10;
        if (n > 0)
        {
            Console.Write(m + ",");
        }
        else
        {
            Console.WriteLine(m);
        }
}