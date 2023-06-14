// Задача 2
// Напишите программу которая на вход принимает два числа и выдает какое меньшее, а какое большее

// System.Console.WriteLine("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if ( num1 > num2 )
// {
//     System.Console.WriteLine($"Первое число = {num1}; Второе число = {num2}; Большее число -> {num1}");
// }
// else
// {
//     System.Console.WriteLine($"Первое число = {num1}; Второе число = {num2}; Большее число -> {num2}");
// }

// Задача 4
// Напишите программу которая принимает на вход 3 числа и выдает максимальное

// System.Console.WriteLine("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число -> ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if ( (num1 > num2) & (num1 > num3) )
// {
//     System.Console.WriteLine($"{num1},{num2},{num3} -> {num1}");
// }

// else if ( num2 > num3 )
// {
//     System.Console.WriteLine($"{num1},{num2},{num3} -> {num2}");
// }

// else
// {
//     System.Console.WriteLine($"{num1},{num2},{num3} -> {num3}");
// }

// Задача 6
// Напишите программу которая на вход принимает число и выдает, являяется ли число четным (делится ли оно на 2 без остатка)

// System.Console.WriteLine("Введите число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if ( num1 % 2 ==0)
// {
//     System.Console.WriteLine($"Число {num1} является четным");
// }
// else 
// {
//     System.Console.WriteLine($"Число {num1} не является четным");
// }

// Задача 8
// Напишите программу, которая на входе принимает число (N), а на выходе показывает все четные числа от 1 до N/

// System.Console.WriteLine("Введите любое число начинающее от 1 -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// String num1 = "";

// if ( num < 1)
// {
//     System.Console.WriteLine($"Фатальная, ужасная, ну просто уму непостижимая ошибка. Как так можно вообще? ЧИСЛО НАДО ОТ 1, А ТЫ ЧТО ВВЕЛ???");
//     num = Convert.ToInt32(Console.ReadLine());
// }
// for ( int i = 1; i <= num; i ++)
// {
//     if ( i % 2 == 0 )
//     num1 = num1 + ($" {i } ");
// }
// System.Console.WriteLine($"{num} -> {num1}");