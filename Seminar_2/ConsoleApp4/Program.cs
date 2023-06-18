Console.Write("Напишите число ");
int num = int.Parse(Console.ReadLine());

int num7 = num%7;
int num21 = num%21;

if (num7 + num21 == 0)
{
  Console.WriteLine($"Число {num} кратно 7 и 21 одновременно");
}
else
{
  Console.WriteLine($"Число {num} не кратно 7 и 21 одновременно");
}