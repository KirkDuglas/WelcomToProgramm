
Console.WriteLine ("Введите Число:");
int N = Convert.ToInt32(Console.ReadLine());
string PrintNumbers (int start, int end)
{
    if (start == end) return start.ToString();

    return start + " " + PrintNumbers(start + 1, end);

}
Console.WriteLine($"Печать чисел от 1 до {N} = {PrintNumbers(1, N)}");
