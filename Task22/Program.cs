// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(10, 1000);
Console.WriteLine("Случайное число - это " + number);
Console.WriteLine($"{number / 100}{number % 10}");
