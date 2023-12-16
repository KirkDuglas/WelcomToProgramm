// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.WriteLine ("Введите Число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите Число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int Ack(int m, int n)
{
    if(m == 0) return n + 1;
    if(n == 0) return Ack(m - 1, 1);
    return Ack(m - 1, Ack(m, n - 1)); 
}
Console.WriteLine (Ack(m,n));