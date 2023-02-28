// Нужно написать программу
// перемножения матриц
//
// генерация матрицы m x n

using static MyMethods;

int SizeMatrix(string message)
{
   Console.Write(message);
   return Convert.ToInt32(Console.ReadLine());
}
int[,] Create2xArray(int size0, int size1, int from, int to)
{
   int[,] newArray = new int[size0, size1];
   for (int i = 0; i < size0; i++)
   {    
      for (int j = 0; j < size1; j++)
      {
         newArray[i, j] = new Random().Next(from, to);
      }
   }
   return newArray;
}
void ShowMatrix(int [,] matrix1)
{
   Console.WriteLine("Матрица: ");
   for(int i = 0; i < matrix1.GetLength(0); i++)
   { 
      for(int j = 0; j < matrix1.GetLength(1); j++)
      {
         Console.Write($"{matrix1[i, j]} ");
      }
         Console.WriteLine();
   }
}

int lines = SizeMatrix("Введите кол-во строчек матрицы: ");
int columns = SizeMatrix("Введите кол-во столбцов матрицы: ");
int from = SizeMatrix("Введите случайноe значение от: ");
int to = SizeMatrix("Введите случайноe значение до: ");
int [,] matrix1 = Create2xArray(lines, columns, from, to);
int [,] matrix2 = Create2xArray(lines, columns, from, to);
ShowMatrix(matrix1);
ShowMatrix(matrix2);

// void Composition(int[,] matr, int[,] matr1, int[,] compMatr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             compMatr[m, n] = matr[m, n] * matr1[m, n];
//         }
//     }
// }