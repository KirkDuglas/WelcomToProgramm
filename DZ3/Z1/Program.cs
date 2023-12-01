//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].


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
    if (mas[i] >= 20 && mas[i] <= 90)
    {
        element++;
    }
 }
 Console.Write($"Число элементов в отрезке [20, 90] = {element}");

