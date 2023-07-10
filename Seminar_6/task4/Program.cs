/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
int a = 0;
int b = 1;

if (num == 1){ Console.WriteLine("0");}
if (num == 2){ Console.WriteLine("0 1");} 
if (num >= 3)
{
  Console.Write("0 1 ");
for (int i = 0; i < num - 2; i++)
{
  if (a > b)
  {
    b = sum;
  }
  else
  {
    a = sum;
  }
  sum = a + b;
  Console.Write($"{sum} ");

}
}








