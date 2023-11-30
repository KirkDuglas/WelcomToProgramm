//Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.


int size = 10;
double[] array = new double[size]; 
for (int i = 0; i < array.Length; i++)
 {
array[i] = Math.Round(new Random().NextDouble() * new Random().Next(101), 2);
 }
 Console.WriteLine($"Массив: [ {string.Join("; ",array)} ]");
double max = array.Max();
double min = array.Min();
double raznost = Math.Round(max - min, 2) ;
Console.WriteLine($"Максимальное значение массива: {max}");
Console.WriteLine($"Минимальное значение массива: {min}");
Console.WriteLine($"Разница составляет: {raznost}");