/*
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов 
в каждом столбце.
*/
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
double[] sum = new double[n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.WriteLine(sum[i] += array[j,i]);     
    }
    Console.WriteLine(Math.Round(sum[i]/m,2));
    Console.WriteLine();
}
