// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int div = 0;

if (number >= 100 && number < 1000)
{
  div = number % 10;
  Console.WriteLine("Последняя цифра числа");
  Console.WriteLine(div);
}
else
{
  Console.WriteLine("Обшибка ввода! Необходимо ввести трехзначное число");
}
