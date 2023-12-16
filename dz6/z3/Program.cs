// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string input = "АникИна";
var isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome ? "Да" : "Нет");

// метод чтения туда-сюда
bool IsPalindrome(string str)
{
string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
return normalized.SequenceEqual(normalized.Reverse());

}