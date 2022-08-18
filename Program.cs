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