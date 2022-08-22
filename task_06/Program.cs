//Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите чиcло:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра числа: " + number + " равна: " + number % 100 / 10);
