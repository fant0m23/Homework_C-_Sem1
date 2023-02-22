// Найти максимальное из 9 чисел с помощью функции

int Function(int arg1, int arg2, int arg3)
{
   int result = arg1;
   if (arg2 > result) result = arg2;
   if (arg3 > result) result = arg3;
      return result;
}

int a1 = 46, b1 = 48, c1 = 36,
   a2 = 74, b2 = 43, c2 = 16,
   a3 = 39, b3 = 24, c3 = 7;

int max1 = Function(a1, b1, c1);
int max2 = Function(a2, b2, c2);
int max3 = Function(a3, b3, c3);
int max = Function(max1, max2, max3);

Console.WriteLine(max);
