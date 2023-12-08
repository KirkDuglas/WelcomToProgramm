// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

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

int [] Getindexes(int[,] matr)
{
int [] indexes = new int [2];
int min = matr[0,0];
for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if(min > matr[i,j])
            {
                min = matr[i,j];
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    }
    return indexes;
}

int[,] getResultMatrix(int[,] matr, int[] indexes)
{
    int[,] result = new int [matr.GetLength(0)-1, matr.GetLength(1)-1];
    int row = 0;
    int col =0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == indexes[1]) continue;
            result[row,col] = matr[i,j];
            col++;
        }
        col=0;
        row++;
    }
    return result;
}
int[,] result = CreateMatrix(5,4,0,25);
PrintMatrix(result);
Console.WriteLine ($"минимальный эелемент находится: [{String.Join (";", Getindexes(result))}]");
// int [,] result = getResultMatrix (result);
PrintMatrix(getResultMatrix(result, Getindexes(result)));
// GetStringWihMin(result);
