﻿// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int Promt(string message)
{
  Console.WriteLine(message);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int[,] CreateOutputArray(int m, int n)
{
  int[,] matrix = new int[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
      Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
  return matrix;
}

// int SummOfElements(int [,] matrix)
// {
//   int sum = 0;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       if (i== j)
//       sum += matrix[i, j];
//     }
//   }
//   return sum;
// }

// Решение с проходом сразу по диагонали, не учитывая другие ячейки
int SummOfElements(int[,] matrix)
{
  int sum = 0;
  for (int i = 0, j = 0; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
    sum += matrix[i, j];
  return sum;
}


int m = Promt("Введите количество строк: ");
int n = Promt("Введите количество столбцов: ");
Console.WriteLine();
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали равна {SummOfElements(CreateOutputArray(m, n))}");
