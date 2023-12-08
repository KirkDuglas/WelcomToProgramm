//  Задайте двумерный массив. 
//  Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
void GetNewMatrix (int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if(i > 0 && i < matr.GetLength(1))
            {
                int tempArr = matr[i,j];
                matr[i,j] = matr[i,j];
                matr[i,j] = tempArr;
            }
            else
            {
                int tempArr = matr[i,j];
                matr[i,j] = matr[matr.GetLength(1)-1, j];
                matr[matr.GetLength(1)-1,j] = tempArr;
            }
        }
 
    }
}


int[,] result = CreateMatrix(4,4,0,25);
PrintMatrix(result);
Console.WriteLine($"Матрица После: ");
GetNewMatrix(result);
PrintMatrix(result);
