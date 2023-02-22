// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

bool multiple7and23(int value)
{
   return value % 7 == 0 && value % 23 == 0;
}
bool result = multiple7and23(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(result);