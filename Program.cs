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
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 1;
if (res == 1)
{
res += 1;
}
while (res <= num)
{
Console.WriteLine(res);
res += 2;
}