//Выяснить является ли число чётным
Console.WriteLine("Введите чиcло:");
int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите чиcло2:");
//int number2 = int.Parse(Console.ReadLine());
if (number1 % 2 == 0)
{
    Console.Write("Number = " + number1 + " является четным числом");
}
else
{
   Console.Write("Number = " + number1 + " является нечетным числом");
}
