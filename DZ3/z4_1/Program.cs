//Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
//Пример вы найдете в конце презентации к семинару.

//Генерируем число и узнаем его длину
int number = new Random().Next(1, 100001);
Console.WriteLine($"Сгенерированное число:  {number}");
string str = Convert.ToString(number);
// int.TryParse(str, out int result);
//string size = str.Lenght;
// int number1 = Convert.ToInt32(str);
// int[] mas = new int [str.Length]; 
// for (int i = 0; i < str.Length; i++)
//  {
// mas[i] = str[i];
//  }
 Console.WriteLine($"Массив: [ {string.Join("; ",str)} ]");
//  for (int i = 0; i < mas.Length; i++) 
//   {
//     if (mas[i] >= 20 && mas[i] <= 90)
//     {
//         element++;
//     }
//  }
//  Console.Write($"Число элементов в отрезке [20, 90] = {element}");
