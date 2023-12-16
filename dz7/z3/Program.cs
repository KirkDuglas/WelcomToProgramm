// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int size = 10;
int [] array = new int [size];
//int i = 0;
//array [i] = new int [size];

int [] FillArray(int [] array, int i = 0)
{
    array [i] = new Random().Next(1, 25);
    if (i == array.Length - 1) return array;
    return FillArray(array, i + 1);   
}
int [] ReverseArray(int [] array, int i = 0, int j = 9)  //int tempIndex = int.MinValue
{
    int temp = 0;
    if (i == array.Length-1) return array;
    // Console.WriteLine(array[i]);
    array[temp] = array[j];
    array[j] = array[i];
    array[i] = array[temp];
    return ReverseArray(array,  i + 1, j-1);
    // array[i] = array[t];
    
//    Console.WriteLine($"{array[i]}");
}

void PrintMas(int [] array)
{
    Console.WriteLine($"Массив после заполнения: [{string.Join("; ",FillArray(array))} ]");
    Console.WriteLine($"Массив после переворота: [{string.Join("; ",ReverseArray(array))} ]");
}
PrintMas(array);
// ReverseArray(array);
 
    // int temp = array[j];
    //     // array[temp] = array[j];
    //     array[i] = array[j];
    //     array[j] = array[temp];
// Console.WriteLine(ReverseArray(array));

    
// void PrintSecondMas(int [] array)
// {
    
// }
