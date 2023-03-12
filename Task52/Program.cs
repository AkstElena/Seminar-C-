// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные,
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int [] GetArray()
{
  int [] array = new int[12];
  for (int i =0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-99, 100);
  }
return array;
}

int [] array = GetArray();
Console.WriteLine($"[{String.Join(", ", array)}]");

int [] NewArray(int [] array)
{
  int [] newArray = new int [array.Length];
for (int index =0 ; index < array.Length; index++)
{
  newArray [index] =  array [index] * (-1);
}
return newArray;
}

int [] newArray = NewArray(array);
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", newArray)}]");