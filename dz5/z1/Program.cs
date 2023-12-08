// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rand = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    matrix[i,j] = rand.Next(min,max+1);
    }
}
return matrix;
}

void PrintMatrix (int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write($"{matr[i,j]} \t");
        }
        Console.WriteLine();  
    }  
}

int FindElement(int[,] matr)
{
Console.Write("введите индекс строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int y = Convert.ToInt32(Console.ReadLine());
int element = 0;
if (x <= matr.GetLength(0) && y <= matr.GetLength(1))
{
    for (int i = 0; i < x; i++)
    {
    for (int j = 0; j < y; j++)
    {
        element = matr [i,j];
    }
    }
   }
    else
        {
          Console.Write("Искомый элемент отсутствует!!! ");
        }
 return element;
}

int[,] result = CreateMatrix(4,4,0,25);
PrintMatrix(result);
// Console.Write($"Найден искомый элемент: ");
Console.WriteLine(FindElement(result));
