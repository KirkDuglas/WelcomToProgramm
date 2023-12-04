//Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.


int size = 10;
double[] mas = new double[size]; 
for (int i = 0; i < mas.Length; i++)
 {
mas[i] = Math.Round(new Random().NextDouble() * new Random().Next(101), 2);
 }
 Console.WriteLine($"Массив: [ {string.Join("; ",mas)} ]");
double max = mas[0];
double min = mas[0];
for (int i = 1; i < mas.Length; i++)
// while (i < mas.Length)
{
    if (mas[i] < min)
    {
        min = mas[i];
    } 
    else if (mas[i] > max)
    {
        max = mas[i];
    }
}
double result = Math.Round(max - min, 2);
Console.WriteLine($"Максимальное значение массива: {max}");
Console.WriteLine($"Минимальное значение массива: {min}");
Console.WriteLine($"Разница составляет: {result}");