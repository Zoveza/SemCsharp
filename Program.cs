//Задача 2:Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//Console.Write("Введите первое число: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//if (number1 < number2)
//{Console.Write("Максимальное число: ");
//Console.WriteLine(number2);
//Console.Write("Минимальное число: ");
//Console.WriteLine(number1);}
//else
//{
//    Console.Write("Максимальное число: ");
//    Console.WriteLine(number1);
//Console.Write("Минимальное число: ");
//Console.WriteLine(number2);}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//Console.Write("Введите первое число: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите третье число: ");
//int number3 = Convert.ToInt32(Console.ReadLine());
//int[] i = { number1, number2, number3 };
//int maxValue = i.Max();
//Console.Write("Максимальное число: ");
//Console.Write(maxValue);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number % 2 == 0)
//{
//Console.Write("Число является чётным");
//}
//else
//{
//Console.Write("Число является нечетным");
//};

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int res = 1;
//if (res == 1)
//{
//res += 1;
//}
//while (res <= num)
//{
//Console.WriteLine(res);
//res += 2;
//}
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//# Домашнее задание 2
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.Write("Введите трехзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("Вторая цифра этого числа: "+stringNumber[1]);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.Write("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(Number);
// if (stringNumber.Length > 2){
// Console.WriteLine("Третья цифра числа: "+stringNumber[2]);
// }
// else
// {
// Console.WriteLine("Третьей цифры нет");
// }

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.Write("Введите цифру,обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// void DayOfTheWeek (int dayNumber) {
//   if (dayNumber == 6 || dayNumber == 7) {
//   Console.WriteLine("выходной");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) {
//     Console.WriteLine("такого дня недели нет");
//   }
//   else Console.WriteLine("не выходной");
// }
// DayOfTheWeek(dayNumber);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// {
//     int count = 1;
//     while (count <= N)
// {
//     Console.Write($"{Math.Pow(count, 3)} ");
//     count++;
// }
// }

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("Введите пятизначное число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// if (Number < 10000 || Number > 99999)
// {
//     Console.WriteLine("Число не пятизначное");
// }
//     else
//     {
//     if ((Number % 10) == ((Number / 10000)%10) && ((Number / 10) % 10) == ((Number / 1000) % 10))
//     {
//     Console.WriteLine($"Число {Number} является палиндромом ");
//     }
//     else 
//     {
//          Console.WriteLine($"Число {Number} не является палиндромом ");
//     }
//     }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// void length(double a, double b, double c, double d, double e, double f)
// { 
//     Console.WriteLine($"Расстояние между точками : {Math.Round(Math.Sqrt(Math.Pow(a - d, 2) + Math.Pow(b - e, 2) + Math.Pow(c - f, 2)), 2)}");
// }
// Console.WriteLine("Введите координаты точек в 3D пространстве");
// Console.Write("Координаты x первой точки : ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координаты y первой точки : ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координаты z первой точки : ");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координаты x второй точки : ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координаты y второй точки : ");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координаты z второй точки : ");
// double zb = Convert.ToDouble(Console.ReadLine());
// length(xa,ya,za,xb,yb,zb);

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите первое число: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double b = Convert.ToDouble(Console.ReadLine());
// int i = Convert.ToInt32(Math.Pow(a, b));
// Console.WriteLine($"Число a в степени b = " + i );


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (Number > 0)
// {
// sum += Number % 10;
// Number = Number / 10;
// }
// Console.WriteLine("Cумма всех цифр в числе = " + sum);


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Сгенерированный массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"{numbers.Length} чисел в массиве, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//      Console.Write("[");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i]);
//         if (i != numbers.Length - 1 )
//         {
//             Console.Write(",");
//         }

//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 1; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];

//     Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//                 Console.Write(numbers[i]);
//         if (i != numbers.Length - 1 )
//         {
//             Console.Write(",");
//         }

//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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

// Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
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
//     Console.Write("[");
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

// Console.Write($"Введите число М(количество чисел): ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] massiveNumbers = new int[m];

// void InputNumbers(int m){
// for (int i = 0; i < m; i++)
//   {
//  Console.Write($"Введите {i+1} число: ");
//  massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }
// int Comparison(int[] massiveNumbers)
// {
//  int count = 0;
//  for (int i = 0; i < massiveNumbers.Length; i++)
//   {
//  if(massiveNumbers[i] > 0 ) count += 1; 
//   }
//  return count;
// }
// InputNumbers(m);
// Console.WriteLine($"Введено {Comparison(massiveNumbers)} чисел больше 0 ");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.Write("Введите количество строк m: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов n: ");
// int n = int.Parse(Console.ReadLine());
// double [,] matrix = new double[m, n];
// FillArrayRandomNumbers(matrix);
// PrintArray(matrix);
// void FillArrayRandomNumbers(double[,] array)
// {
//  for (int i = 0; i < array.GetLength(0); i++)
//     {
//  for (int j = 0; j < array.GetLength(1); j++)
//         {
//  array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [10,10];
// FillArrayRandomNumbers(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
// }

// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-100, 100)/10;
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Console.WriteLine("введите количество строк");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[n, m];
// FillArrayRandomNumbers(numbers);


// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         avarage = (avarage + numbers[i, j]);
//     }
//     avarage = avarage / n;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();
// PrintArray(numbers);



// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[linesVol, columnsVol];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine();
// Console.WriteLine("Массив до изменения");
// PrintArray(numbers);

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1) - 1; j++)
//     {
//         for (int z = 0; z < numbers.GetLength(1) - 1; z++)
//         {
//             if (numbers[i, z] < numbers[i, z + 1])
//             {
//                 int temp = 0;
//                 temp = numbers[i, z];
//                 numbers[i, z] = numbers[i, z + 1];
//                 numbers[i, z + 1] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Массив с упорядоченными значениями");
// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 5);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// int size = InputInt("размерность матриц: ");
// int[,] matrixA = new int[size, size];
// int[,] matrixB = new int[size, size];
// FillArrayRandomNumbers(matrixA);
// FillArrayRandomNumbers(matrixB);
// int[,] matrixC = new int[size, size];

// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int k = 0; k < size; k++)
//         {
//             matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
//         }
//     }
// }
// Console.WriteLine("Матрица - А");
// PrintArray(matrixA);
// Console.WriteLine();
// Console.WriteLine("Матрица - В");
// PrintArray(matrixB);
// Console.WriteLine();
// Console.WriteLine("Произведение матриц А*В");
// PrintArray(matrixC);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] nums = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     nums[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// PrintArray(nums);

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());
// PrintNumbers(m,n);

// void PrintNumbers(int start, int end)
// {
//     Console.Write($"{start} ");
//     if (start == end) return;
//     PrintNumbers(start + 1, end);
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());
// void NumberSum (int m, int n, int sum)
// {
//     if (m > n) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}"); 
//         return;
//     }
//     sum = sum + (m++);
//     NumberSum(m, n, sum);
// }

// NumberSum(m, n, 0);
