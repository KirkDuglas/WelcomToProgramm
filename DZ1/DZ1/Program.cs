using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
    int a = firstNumber;
    int b = secondNumber;
    int max = a;
    if (b < a)
    {
        Console.Write($"Первое число `{a}` больше чем второе число `{b}`");
    }
    else if (b > a)
    {
        Console.Write($"Первое число `{a}` меньше чем второе число `{b}`");
    } 
    else
    {
        Console.Write($"Введенные числа равны `{max}`");
    }    
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 4;
            secondNumber = 4;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}