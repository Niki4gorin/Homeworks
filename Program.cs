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



// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// int num = ReadInt("Введите трехзначное число: ");
// int sum = num.ToString().Length;

// if (sum < 3 || sum > 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     Console.WriteLine(Numbers(num));
// }


// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int Numbers (int a)
// {

//     int result = ((a / 10) % 10);
//     return result;
// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(Array(number, count));


// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int Array(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int dayNumber = ReadInt("Введите число от 1 до 7: ");
// Console.WriteLine(WorkHoliday(dayNumber));

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// string WorkHoliday(int a)
// {
//     if (a > 0 && a < 8)
//     {
//         if (a == 7 || a == 6)
//         {
//             Console.Write("Под цифрой " + a + " - Выходной");
//         }
//         else
//         {
//             Console.Write("Под цифрой " + a + " - Рабочий");
//         }
//     }
//     else
//     {
//         Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
//     }
//     return " день.";
// }



// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void PalinDrome ( int len, string number )
// {
//     if (len ==5)
//     {
//         if ( number[0] == number[4] && number[1] == number[3])
//           {
//             System.Console.WriteLine($"Число {number} является палиндромом");
//           }  
//         else
//           {
//             System.Console.WriteLine($"Число {number} НЕ является палиндромом");
//           }
//     }

//     {
//     System.Console.WriteLine("Вы ввели не пятизначное число!!!"); 
//     }

// }
// System.Console.WriteLine("Введите пятизначное число:");;
// int len = Convert.ToInt32(Console.ReadLine());
// string number = ;
// System.Console.WriteLine($"{PalinDrome}");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// double FindDistance(double x1, double x2, double y1, double y2 , double z1, double z2)
// {
//     return Math.Round (Math.Sqrt(Math.Pow(x2 - x1, 2 ) + Math.Pow(y2 - y1, 2) + Math.Pow(z1 - z2, 2)), 2);
// }


// System.Console.WriteLine("Введите координату X первой точки ->");
// double x1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите координату X второй точки ->");
// double x2 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y первой точки ->");
// double y1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y второй точки ->");
// double y2 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите координату Z первой точки ->");
// double z1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите координату Z второй точки ->");
// double z2 = Convert.ToDouble(Console.ReadLine());


// System.Console.WriteLine($"Растояние между точками в 3D пространстве равняется -> {FindDistance(x1, x2, y1, y2, z1, z2)}");




// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


// void Quad (int x)
// {
//     int count = 1;
//     while ( count <= x)
//     {
//         System.Console.WriteLine($"{count} -> {Math.Pow(count, 3)}");
//         count ++;
//     }
// }
// System.Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// Quad(x);



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string readInput = System.Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }


// int Power (int powerBase, int exponent)
// {
//     int power = 1;
//     for( int i = 0; i < exponent; i++)
//     {
//         power *= powerBase;
//     }
//     return power;
// }

// bool ValidateExponent(int exponent)
// {
//     if (exponent < 0)
//     {
//         System.Console.WriteLine("Не должно быть меньше нуля");
//         return false;
//     }
//     return true;
// }

// int powerBase = Prompt ("Введите основание -> ");
// int exponent = Prompt ("Введите показатель -> ");
// if (ValidateExponent(exponent))
// {
//     System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
// }




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int SumAllDigit(int num)
// {
//     int result = 0;
//     while(num > 0 )
//     {
//         result += num % 10;
//         num = num / 10;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($" Сумма цифр в числе {num} равняется -> {SumAllDigit(num)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]}, ");
//     }
//     System.Console.WriteLine("]");
// }

// System.Console.WriteLine("input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size,minValue,maxValue));


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// System.Console.WriteLine("введите длину массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// void CreateRandomArray (int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//         System.Console.Write(array[i] + " ");
//     }
// }


// int EvenNumbers(int[] array)
// {
//     int num = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         num = num + 1;
//     }
//     System.Console.WriteLine();
//     return num;
// }


// CreateRandomArray(size);
// System.Console.WriteLine($"Четные числа массива -> {EvenNumbers(array)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Console.WriteLine("Введите размер массива  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 0; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];

//     Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//         {
//             max = numbers[z];
//         }
//     if (numbers[z] < min)
//         {
//             min = numbers[z];
//         }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }



// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int Promt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int[] inputArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Promt($"Введите {i + 1} -й элемент ");
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"a[{i}] = {array[i]}");
//     }
// }

// int CountPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// int length = Promt("Введите количество элементов -> ");
// int[] array;
// array = inputArray(length);
// PrintArray(array);
// Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите переменную b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;

// Console.Write($"\n Точка пересечения двух прямых: [{ x},{ y}]");