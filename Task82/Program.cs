// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int [,] CreateArray()
{
  int m = new Random().Next(2, 10);
  int n = m;
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
  int [,] newArray = new int [matrix.GetLength(1), matrix.GetLength(0)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
    {
      newArray[i, j]= matrix [j,i];
     }
  }
  return newArray;
}

int [,] matrix = CreateArray();
PrintArray (matrix);
Console.WriteLine();
PrintArray(ChangeArray(matrix));
