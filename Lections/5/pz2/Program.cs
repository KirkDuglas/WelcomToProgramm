//    Поиск диагонали
   
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

int SumOfMainDiag(int[,] mas)
{
    int summ = 0;
    
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
          if (i == j)
          {
        summ += mas[i,j];
          }  
        }
    }
    return summ;
}

int[,] res = CreateMatrix(4,5,0,20);
ShowMatrix(res);
Console.WriteLine($"Сумма главной диагонали {SumOfMainDiag(res)}");
// SquarElements(res);
// ShowMatrix(res);
