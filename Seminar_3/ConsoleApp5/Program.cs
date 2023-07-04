/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

int square(int Num)
{
  int sq = Num * Num;
  return sq;
}


Console.Write("Введите число, которое хотите возводить в квадрат: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
Console.Write("Ответ: ");
while (i <= N)
{
  Console.Write($"{square(i)} ");
  i++;
}
