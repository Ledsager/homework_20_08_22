//Удалить вторую цифру трёхзначного числа
int n = new Random().Next(100,1000);
Console.WriteLine("Случайное число в дипазоне от 100 до 999 равно: " + n);
Console.Write("число без второй цифры:" + (n / 100 * 10 + n % 10));
