// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.


int [,] CreateArray()
{
  int m = new Random().Next(2, 10);
  int n = new Random().Next(2, 10);
  int [,] matrix = new int [m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  
  }
  return matrix;
}

int [,] PrintArray(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            Console.Write(matrix[i, j] + "\t");
    }
  Console.WriteLine();
  }
  return matrix;
}


int [,] ChangeArray(int [,] matrix)
{
  int tmp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      tmp = matrix[0, j];
      matrix[0, j]= matrix [matrix.GetLength(0)-1,j];
      matrix [matrix.GetLength(0)-1,j] = tmp;
   }
   return matrix;
}

int [,] matrix = CreateArray();
PrintArray (matrix);
Console.WriteLine();
PrintArray(ChangeArray(matrix));



