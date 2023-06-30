//Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X и Y не равны нулю, и выдаёт номер четверти плоскости, в которой находится это точка.

Console.Write("Введите координату X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
  Console.WriteLine("Недопустимые координаты X и Y != 0");
  return;
}

if (x > 0 && y > 0)
{
  Console.WriteLine("Номер четверти: 1");
}

if (x < 0 && y > 0)
{
  Console.WriteLine("Номер четверти: 2");
}

if (x < 0 && y < 0)
{
  Console.WriteLine("Номер четверти: 3");
}

if (x > 0 && y < 0)
{
  Console.WriteLine("Номер четверти: 4");
}