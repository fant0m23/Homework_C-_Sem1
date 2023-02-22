// Напишите программу, которая выводит случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int maxDigit(int number)
{
   int max = 0,
         x = number / 10,
         y = number % 10;
   if (x > y)
   {
      max = x;
   }
   else
   {
      max = y;
   }
   return max;
}
int numeral = new Random().Next(10, 100);
Console.WriteLine(numeral);
int max = maxDigit(numeral);
Console.WriteLine(max);