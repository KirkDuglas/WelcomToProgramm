// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// Пример вы найдете в конце презентации к семинару.

Console.Write("введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number < 10)
{
   Console.Write(number);
} 
    else 
    { 
    while ( number > 0 )
    { 
        
        int x = number % 10;
    number /= 10; 
    if (number > 0)
    {
    Console.Write(x + ", ");
    }
    else
    {
        Console.Write(x);
    }
    }
    }

// Console.Write($"длина числа = {len}");
// if (number < 10 || number < 100)

//     Console.Write("введите число: ")
// } 
// int firstdigit = number 