// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Console.Clear();
// Console.Write("Введите первое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int m = int.Parse(Console.ReadLine()!);

// string printNumbers(int n)
// {
//     if (n < m)
//     {
//         int temp = n;
//         n = m;
//         m = temp;
//     }

//     if (n == m)
//         return $"{n} ";
//     return printNumbers(n - 1) + $"{n} ";
// }

// Console.WriteLine(printNumbers(n));


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int akkerman(int m, int n)
// {
//     if (m == 0)
//         return (n + 1);
//     else if (m >0 && n ==0)
//         return akkerman(m - 1, 1);
//     else
//         return akkerman(m - 1, akkerman(m, n - 1));
// }

// Console.Clear();
// Console.Write("Введите число m: ");
// int m = int.Parse(Console.ReadLine()!);
// while (m < 0)
// {
//     Console.Write("Вы ошиблись!\nВведите положительное число: ");
//     m = int.Parse(Console.ReadLine()!);
// }
// Console.Write("Введите число n: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 0)
// {
//     Console.Write("Вы ошиблись!\nВведите положительное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }

// Console.WriteLine(akkerman(m, n));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

string printElements (int[] array, int i)
{
    if (i == array.Length)
        return "";
    else
    return printElements(array, i + 1) + $"{array[i]} ";
}

void inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); 
        //чтобы не оперировать слишком длинными числами, ограничила перечень. 
        //А т.к. в примере числа, то использовала тоже числовой массив, хотя в формулировке "произвольный".
}

Console.Clear();
Console.Write("Введите кол-во чисел в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

Console.WriteLine(printElements(array, 0));