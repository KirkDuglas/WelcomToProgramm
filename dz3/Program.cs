using System;

class Answer {
    static void CheckIfEven(int number)
    {
      // Введите свое решение ниже
int a = number;
if (a % 2 == 1) 
{
    Console.WriteLine($"Число `{a}` нечётное");
}
else 
{
    Console.WriteLine($"Число `{a}` чётное");
}
    }
  

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 77;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}