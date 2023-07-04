/*Задача №21 AB = √(xb - xa)2 + (yb - ya)2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

Console.Write("X для первой точки: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Y для первой точки: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("X для Второй точки: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Y для второй точки: ");
double y2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

 Console.WriteLine($"Ответ: {distance}");