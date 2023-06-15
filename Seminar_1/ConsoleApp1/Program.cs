Console.Write("Напишите целое число ");
int num = int.Parse(Console.ReadLine());

int result = num * num;
//Знак $ в конструкции ниже позволяет значение reault при обрамлении в фигурные скобки {} вывести
Console.WriteLine($"Квадрат входного числа: {result}");