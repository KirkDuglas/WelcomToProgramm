// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы

// Сделал два варианта:
// 1 как учил Михаил
// 2 (закомментированный) как художник (я так вижу). 

Console.WriteLine ("Введите Число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите Число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string PrintNumbers (int start, int end)
{
    if (start == end) return start.ToString();
    if (start > end) return start + " " + PrintNumbers( start - 1, end);
    return start + " " + PrintNumbers(start + 1, end);

}
Console.WriteLine($"Печать чисел от {M} до {N} = {PrintNumbers(M, N)}");

// Console.WriteLine("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int m, int n)
// {
//     if (m == n) return m.ToString();
//     if (m > n) return m + " " + PrintNumbers( m - 1, n);
//     return m + " " + PrintNumbers(m + 1, n);
// }
// Console.WriteLine($"Печать чисел от {m} до {n} = {PrintNumbers(m, n)}");

