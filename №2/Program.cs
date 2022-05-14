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
string? position = Console.ReadLine();

for (int y = 0; y < position.Length; y++)
{
    Console.WriteLine(position[y]);
}

for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (position[0] == i && position[1] == j)
        {              
            Console.Write(position[0] + position[1]);
            break;
        }
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