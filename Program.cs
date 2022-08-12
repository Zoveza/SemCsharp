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