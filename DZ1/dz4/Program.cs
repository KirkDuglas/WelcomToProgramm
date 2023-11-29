using System;

public class Answer 
{
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
     int N = number;
        int x = 1;
        while (x <= N)
        if (x % 2 == 0)
        {
            Console.Write(x + "\t");
            x += 1;
        }
        else
        {
         x += 1;
        }
    }
  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) 
    {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }

}