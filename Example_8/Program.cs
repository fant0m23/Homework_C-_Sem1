// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("введите число N:  ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 1)
{
   int temp = 2;
   while (N >= temp)
   {
      Console.Write(temp);
      Console.Write(", ");
      temp += 2;
   }
}
else
{
   int temp = 0;
   while (N <= temp)
   {
      Console.Write(temp);
      Console.Write(", ");
      temp -= 2;
   }
}
