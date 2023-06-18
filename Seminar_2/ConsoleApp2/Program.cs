//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int firstNum = num/100;
int ThirdNum = num%10;

Console.Write(firstNum);
Console.WriteLine(ThirdNum);

int result = (firstNum*10) + ThirdNum;
Console.WriteLine(result);