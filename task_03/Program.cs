//Найти максимальное из трех чисел
Console.WriteLine("Введите 3 чиcла через Enter:");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
int max = number1;//выбираем по умолчанию максимальным первое введеное число
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
Console.WriteLine("Maximum = " + max);