// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите чиcло:");
double num = double.Parse(Console.ReadLine());
string a = num.ToString();// Преобразуем число в строку
if (a.Length < 3)// или if (((int)Math.Log10((double)num) + 1) < 3)
{
Console.WriteLine($"Количество цифр в числе: {num} меньше 2х");
}
else
{
    Console.WriteLine($"Третья цифра в числе: {num} равна {a[2]}");
}
