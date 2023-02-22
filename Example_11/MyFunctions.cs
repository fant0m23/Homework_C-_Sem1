// создаю функции:
// Наполнения массива
// Печати всех элементов массива в строку через двойной пробел
// Поиска определенного значения среди элементов массива
// Поиска индекса элемента с максимальным значением

//ФУНКЦИИ:
void fillArray(int[] array)
{
   int size = array.Length,
      index = 0;
   while (index < size)
   {
      array[index] = new Random().Next(1, 10);
      index++;
   }
}
void printArray(int[] array)
{
   int size = array.Length,
      index = 0;
   while (index < size)
   {
      Console.Write(array[index]);
      Console.Write("  ");
      index++;
   }
   Console.WriteLine();
}
int searchValue(int[] array, int find)
{
   int position = -1,
      index = 0,
      size = array.Length;
   while (index < size)
   {
      if (find == array[index])
      {
         position = index;
         break;
      }
      index++;
   }
   return position;
}
int searchIndexMAX(int[] array)
{
   int index = 0,
      currentMax = array[index],
      size = array.Length,
      indexMax = 0;
   while (index < size)
   {
      if (currentMax < array[index])
      {
         currentMax = array[index];
         indexMax = index;
      }
      index++;
   }
   return indexMax;
}

//Входные значения:
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Среди элементов массива нужно найти значение: ");
int value = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[size];

//Применение функций:
fillArray(mass);
printArray(mass);
int find = searchValue(mass, value);
int maxIndex = searchIndexMAX(mass);

//Вывод результатов:
Console.Write("Искомое значение расположено под индексом ");
Console.WriteLine(find);
Console.Write("Максимальный элемент массива расположен под индексом ");
Console.WriteLine(maxIndex);
