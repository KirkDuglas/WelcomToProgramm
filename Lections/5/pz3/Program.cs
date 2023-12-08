//    Поиск среднего арифметического
   
    // Создание метода  Строки Столбцы      Мин и макс значение
int[,] CreateMatrix (int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(min, max+1);
        }
    }
    return matrix;
}
void ShowMatrix (int[,] mas)
{
     for (int i = 0; i < mas.GetLength(0); i++)
     {
        for (int j = 0;j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i,j]} \t");
        }
        Console.WriteLine();
     }
}

Double [] GetArrayWhithMeans (int[,] mas)
{
    double [] means = new double [mas.GetLength(0)];// задаем количество элементов в массиве
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        Double CurrentSumm = 0;
        for (int j = 0; j < mas.GetLength(1); j++)
        {
         CurrentSumm += mas[i,j];
        }
       double CurrentMean = CurrentSumm / mas.GetLength(1);
       means[i] = CurrentMean;
        
    }
    return means;
}

int[,] res = CreateMatrix(4,5,0,20);
ShowMatrix(res);
double[] means = GetArrayWhithMeans(res);
Console.WriteLine($"Массив [{string.Join("; ", means)}]");
// SquarElements(res);
// ShowMatrix(res);
