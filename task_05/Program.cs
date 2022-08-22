//Показать четные числа от 1 до N
Console.WriteLine("Введите чиcло:");
int n = int.Parse(Console.ReadLine());
int i = 0;
Console.WriteLine("В дипазоне от 0 до " + n +" четные числа: ");
while (i <= n)
{
    if (i % 2 == 0)
    {
    Console.Write(" " + i + ",");
    }
    i++;
}
