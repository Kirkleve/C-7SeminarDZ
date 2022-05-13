/*
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов 
в каждом столбце.
*/
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int sumM = 0;
int sumN = 0;
int[] arrayM = new int[m];
int[] arrayN = new int[n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);
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
    sumM = sumM * arrayM[i];
    
    for (int j = 0; j < n; j++)
    {
        sumN = sumN * arrayN[j];
    }
}
Console.WriteLine(sumM + " " + sumN);