/*
Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание,
что такого элемнента нет.
*/
Console.Write("Введите кол-во строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[lines, columns];

FullArray2(lines, columns);
PrintArray2(lines, columns);

Console.Write("Введите позицию элемента которого хотите найти: ");
string position1 = Console.ReadLine()!;

for (int y = 0; y < position1.Length; y++)
{
    Console.Write(position1[y] + " ");
}

for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (position1[0] == i && position1[1] == j)
        {              
            Console.Write($"{position1[0] + position1[1]}");
        }
        if (position1[0] > i && position1[1] > j)
            Console.Write("такого числа нет ");
    }
}




void FullArray2(int lines, int columns)
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray2(int lines, int columns)
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}