//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.


int size = 10;
int[] array = new int[size]; 
int element = 0;
for (int i = 0; i < array.Length; i++)
 {
array[i] = new Random().Next(1, 101);
 }
 Console.WriteLine($"Массив: [ {string.Join("; ",array)} ]");
 for (int i = 0; i < array.Length; i++) 
  {
    if (array[i] % 2 == 0)
    {
        element++;
    }
 }
 Console.Write($"Число четных элементов в массиве = {element}");