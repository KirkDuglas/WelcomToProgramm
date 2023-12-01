//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.


int size = 10;
int[] mas = new int[size]; 
int element = 0;
for (int i = 0; i < mas.Length; i++)
 {
mas[i] = new Random().Next(1, 101);
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