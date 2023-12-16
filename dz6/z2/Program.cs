// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

char[,] charArray = new char[,] { { 'A', 'b', 'O' }, { 'c', 'd', 'F' } };
string result = CreateStringFrom2DArray(charArray);
Console.WriteLine(result);
string CreateStringFrom2DArray(char[,] array)
{
    string tempResult = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempResult += array[i, j];
        }
    }
    string input = tempResult;
    string result = input.ToLower();
    return result;
}
// void GetStringBigRegister(string[] charArray)
// {

// Console.WriteLine(result1);

