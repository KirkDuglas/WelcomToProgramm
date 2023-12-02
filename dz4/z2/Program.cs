// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int size = 10;
int[] mas = new int[size]; 
int element = 0;
for (int i = 0; i < mas.Length; i++)
 {
mas[i] = new Random().Next(100, 1000);
 }
 Console.WriteLine($"Массив: [ {string.Join("; ",mas)} ]");
 for (int i = 0; i < mas.Length; i++) 
  {
    if (mas[i] % 2 == 0)
    {
        element++;
    }
 }
 Console.Write($"Число четных элементов в массиве = {element}");