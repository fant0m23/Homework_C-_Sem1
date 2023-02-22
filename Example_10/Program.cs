// Найти индекс максимального значения массива

int[] mass = new int[10];
int size = 10,
      index = 0,
      maxIndex = 0;

while (index < size)
{
   mass[index] = new Random().Next(1, 100);
   index++;
}
index = 0;
int maxValue = mass[index];

void printArray(int[] array)
{
   int count = array.Length;
   int position = 0;
   while (position < count)
   {
      Console.Write(array[position]);
      Console.Write("  ");
      position++;
   }
}

printArray(mass);

index = 0;
while (index < size)
{
   if (maxValue < mass[index])
   {
      maxValue = mass[index];
      maxIndex = index;
   }
   ++index;
}
Console.WriteLine();
Console.WriteLine(maxIndex);
