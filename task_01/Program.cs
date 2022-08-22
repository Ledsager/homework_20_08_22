//По двум заданным числам проверять является ли первое квадратом второго
 Console.WriteLine("Введите чиcло1:");
int number1 = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите чиcло2:");
int number2 = int.Parse(Console.ReadLine());
if (number1 * number1 == number2)
{
    Console.Write("Number1 = " + number1 + " является квадратом Number2 = " + number2);
}
else
{
    Console.Write("Number1 = " + number1 + " не является квадратом Number2 = " + number2);
}
Console.WriteLine();