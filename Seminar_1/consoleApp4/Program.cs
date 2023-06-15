//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите трёхзначное число ");
int a = int.Parse(Console.ReadLine());

 int lastN = Math.Abs(a % 10);

Console.WriteLine($"{lastN} последнее число");