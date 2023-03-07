// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt() //функция на число
{
    Console.WriteLine("Введите число");
   return Convert.ToInt32(Console.ReadLine());
}
int a = Prompt();  // ввод числа с консоли

int SumNums(int number) // функция на суммирование
{
  int sum = 0;
  for (int i = 0; i <=number; i++)
    sum +=i;
  return sum;
}

Console.WriteLine(SumNums(a)); // подсчет суммирования введенного а
