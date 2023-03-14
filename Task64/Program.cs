// Задача 44: Не используя рекурсию, выведите первые N чисел Фибонначи.
// Первые два числа 0 и 1
// Если N = 5 то 0 1 1 2 3
// Если N = 3 то  0 0 1
// Если N = 7  то 0 1 1 2 3 5 8

int Promt(string message)
{
  Console.WriteLine(message);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int[] Nfibonacci(int num)
{
  int[] array = new int[num];
  int a = 0;
  int b = 1;
  array[0] = a;
  array[1] = b;
  for (int i = 2; i < num; i++)
  {
    array[i] = a + b;
    a = b;
    b = array[i];
  }
  return array;
}

int num = Promt("Введите количество чисел последовательности: ");
Console.WriteLine($"Последовательность Фибоначи: {String.Join(", ", Nfibonacci(num))}");

