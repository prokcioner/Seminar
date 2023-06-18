//Программа на вход принимает число (может быть любой размерности). Необходимо вывести reverse этого числа.

Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine());
int b = a;
int count = 0;

while (b>0)
{
  int d = b%10;
  int c = b/10;
  b=c;
  Console.Write($"{d}");
  count++;
}

Console.WriteLine(" ");
Console.WriteLine($"В числе {a} - {count} цифр");