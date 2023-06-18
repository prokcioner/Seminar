//Программа на вход принимает число (может быть любой размерности). Необходимо вывести количество цифр в этом числе.

Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine());
int b = Math.Abs(a);
int count = 0;

while (b>0)
{
  int c = b/10;
  b=c;
  count++;
}

Console.WriteLine($"В числе {a} - {count} цифр");
