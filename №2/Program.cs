/*
Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание,
что такого элемнента нет.
*/
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

FullArray2(m, n);
PrintArray2(m, n);
string numbers = Convert.ToString(Console.ReadLine());
string[] num = new string [numbers];
for(int i = 0; i < numbers.Length;i++)
{
    numbers[i] = numbers[i] + " ";
}
Console.Write(numbers);




void FullArray2(int lines, int colones)
{
    int[,] array = new int[lines, colones];

    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < colones; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray2(int lines, int colones)
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < colones; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}