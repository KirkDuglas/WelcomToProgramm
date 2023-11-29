// Напишите программу, которая выводит третью с начала
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 91 => Третьей цифры нет

Console.Write("введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number < 10 || number < 100)
{
   Console.Write("Третьей цифры нет");
} 
    else 
    {    int x = number;
    while ( x > 1000 )
    { 
    x /= 10; 
    }
     int thirdDigit = x % 10;
    Console.Write($"Третья цифра {thirdDigit}");
    }
       



