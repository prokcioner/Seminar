﻿//Задача №18

Console.Write("Введите число от 1 до 4: ");
int Area = int.Parse(Console.ReadLine());

switch (Area)
{
  case (1):
    Console.WriteLine(" x > 0 и y > 0");
    break;
  case (2):
    Console.WriteLine(" x < 0 и y > 0");
    break;
  case (3):
    Console.WriteLine(" x < 0 и y < 0");
    break;
  case (4):
    Console.WriteLine(" x > 0 и y < 0");
    break;      
  default:
  Console.WriteLine("Введите цифру от 1 до 4!!!");
  break;
}