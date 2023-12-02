//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
using System;
class Programm
{
static void Main()
{
while (true)
{
Console.Write("Введите число. Для выхода нажмите `q`:");
string? input = Console.ReadLine();
    if (input == "q")
{
    Console.WriteLine("[Выход]");
    break;
}
int number;
if (int.TryParse(input, out number))
{
int sum = 0;
while (number > 0)
{
 sum += number % 10;
    number /= 10; 
}
if (sum %2 == 0)
{
    Console.WriteLine("[STOP]");
    break;
}

}
}
}
}