﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
   Console.Write("Ответ: max = ");
   Console.Write(a);
}
else
{
   Console.Write("Ответ: max = ");
   Console.Write(b);
}