//Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X и Y не равны нулю, и выдаёт номер четверти плоскости, в которой находится это точка.(Функция)

int difinitionOfAQuarter( int num1, int num2)
{
int quarter = -1;

if (num1 > 0 && num2 > 0)
{
   quarter = 1;
}

if (num1 < 0 && num2 > 0)
{
  quarter = 2;
}

if (num1 < 0 && num2 < 0)
{
  quarter = 3;
}

if (num1 > 0 && num2 < 0)
{
  quarter = 4;
}

return quarter;
}

Console.Write("Введите координату X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
  Console.WriteLine("Недопустимые координаты X и Y != 0");
  return;
}

Console.WriteLine($"Номер четверти: {difinitionOfAQuarter(x, y)}");
