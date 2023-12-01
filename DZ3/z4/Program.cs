//Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
//Пример вы найдете в конце презентации к семинару.

//Генерируем число и узнаем его длину
int number = new Random().Next(1, 100001);
Console.WriteLine($"Сгенерированное число:  {number}");
int temp = number;
int count = 0;
while (number > 0)
{
    number /= 10;
    count ++;
}

//заполняем массив
int [] mas = new int[count];
for (int i = count - 1; i >= 0; i--)
 {
mas[i] = temp % 10; 
temp /= 10 ;
 }
 Console.WriteLine($"Массив до сортировки:  [ {string.Join("; ",mas)} ]");

//Сортируем массив
for (int i = 0; i < mas.Length; i++)
 {
    for (int j = i+1; j < mas.Length; j++)
    if (mas[j] > mas[i])
    {
        temp = mas[j];
        mas[j] = mas[i];
        mas[i] = temp;

    }
 }
  Console.WriteLine($"Массив после сортировки: [ {string.Join("; ",mas)} ]");
