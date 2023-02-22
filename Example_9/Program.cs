// Напишите программу, которая будет принимать на вход два числа и выводить, является ли
// второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

void multiple(int number1, int number2)
{
   if (number1%number2==0)
   {
      Console.WriteLine("Число кратно");
   }
   else
   {
      Console.Write("Остаток от деления равен ");
      Console.WriteLine(number1%number2);
   }
}
Console.WriteLine("Введите 2 числа");
int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());
multiple(first, second);