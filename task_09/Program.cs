//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите любое чиcло:");
double number1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите чиcло кратность к которому хотите проверить:");
double number2 = double.Parse(Console.ReadLine());

if (number1 % number2 == 0)
{
   Console.WriteLine($"Число: {number1} кратно числу:{number2}");
}
else
{
    Console.WriteLine($"Остаток от {number1} / {number2} = {number1 % number2}");
}