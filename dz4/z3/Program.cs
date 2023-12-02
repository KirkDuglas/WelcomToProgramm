//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int size = 10;
int[] mas = new int[size]; 
for (int i = 0; i < size; i++)
 {
mas[i] = new Random().Next(100, 1000);
 }
 Console.WriteLine($"Массив ДО: [ {string.Join("; ",mas)} ]");
 for (int i = 0; i < size/2; i++) 
  {
    int temp = mas[i];
    mas[i] = mas[mas.Length - 1 -i];
    mas[mas.Length -1 -i]  = temp;
  }
  Console.WriteLine($"Массив после: [ {string.Join("; ",mas)} ]");


