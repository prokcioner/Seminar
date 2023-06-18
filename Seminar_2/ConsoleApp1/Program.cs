int a = new Random().Next(10,100);
Console.WriteLine(a);
int firstNum = a/10;
int secondNum = a%10;

int max = firstNum;
if (max < secondNum) max = secondNum;

Console.WriteLine(firstNum);
Console.WriteLine(secondNum);
Console.WriteLine($"Максимальная цифра в числе {a}, это - {max}");