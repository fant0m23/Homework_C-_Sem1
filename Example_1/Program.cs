Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine()!;
if (username.ToLower() == "маша" || username.ToLower() == "саша")
{
   Console.Write("Класс, это же ");
   Console.Write(username.ToUpper());
   Console.Write("!");
}
else
{
   Console.Write(username);
   Console.WriteLine(", давай, до свидания!");
}