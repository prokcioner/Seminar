
Console.Write("Пожалуйста введите число от 1 до 7 ");

int input = int.Parse(Console.ReadLine());

switch (input)
{
  case (1):
    Console.Write("Первый день недели это понедельник.");
    break;
  case (2):
    Console.Write("Второе день недели это вторник.");
    break;
  case (3):
    Console.Write("Третий день недели это среда.");
    break;
  case (4):
    Console.Write("Четвёртый день недели это четверг.");
    break;
  case (5):
    Console.Write("Пятый день недели это пятница.");
    break;
  case (6):
    Console.Write("Шестой день недели это суббота.");
    break;
  case (7):
    Console.Write("Седьмой день недели это воскресенье.");
    break;
  
  default:
    Console.Write("Введённое число не равно от 1 до 7.");
    break;
}