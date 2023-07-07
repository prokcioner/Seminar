// See https://aka.ms/new-console-template for more information

Console.Write("Введите текст (строку): ");
string userString = Console.ReadLine();
string reverseUserString = "";
for (int i = userString.Length - 1; i >= 0; i--)
{
  reverseUserString = reverseUserString + userString[i];
}
if (reverseUserString == userString)
{
  Console.WriteLine("Ваша строка полиндром");
}
else
{
  Console.WriteLine("Ваша строка не полиндром");
}