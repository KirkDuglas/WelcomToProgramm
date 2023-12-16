// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
void GetStringWihMin (int[,] matr)
{
    int minRow = 0;
int minSumm = int.MaxValue;

   for(int i = 0; i < matr.GetLength(0); i++)
    { 
        int tempSumm = 0;
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            tempSumm += matr[i,j];
        }
        Console.WriteLine ($"Сумма строки [{i}]= {tempSumm}");
        if (minSumm > tempSumm)
            {
                minSumm = tempSumm;
                minRow = i;
            }
    }
    Console.WriteLine($"Минимальная сумма: {minSumm}");
    Console.WriteLine($"Индекс строки c наименьшей суммой: [{minRow}]");
}
int[,] result = CreateMatrix(5,3,0,25);
PrintMatrix(result);
// int [] minString = GetStringWihMin(result);
GetStringWihMin(result);

