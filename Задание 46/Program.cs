Console.WriteLine("Введите два числа");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m, n];
for(int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    array[i, j] = new Random().Next(1, 10);
    Console.Write($"{array[i, j]}");
}
Console.WriteLine();
}

