// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке

// void FillArray(int[] collection)
// {
//   int leght = collection.Length;
//   int index = 0;
//   while (index <leght)
//   {
//     collection[index] = new Random().Next(0,2);
//     index++;
//   }
// }

// void PrintArray(int[] col)
// {
//   Console.Write("[");
//   int count = col.Length;
//   for(int position=0; position<count; position++)
//   {
//     Console.Write(col[position]+", ");
//   }
//   Console.Write("]");
// }

// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);



int[] CreateArray(int size)
{
  int [] array = new int [size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(0,2);
  }
return array;
}

int[] newArrey = CreateArray(8);

Console.WriteLine($"[{String.Join(", ", newArrey)}]");