/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void PrintArray(int[,] mass1)
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            Console.Write($"{mass1[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int sizeX, int sizeY, int minValue, int maxValue)
{
    int StartRow = 0;
    int StartCol = 0;
    int EndRow = sizeX;
    int EndCol = sizeY;
    int[,] resArray = new int[sizeX, sizeY];

    while (StartRow < EndRow && StartCol < EndCol)
    {
        //верхний ряд
        for (int i = StartCol; i < EndCol; i++)
        {
            resArray[StartRow, i] = new Random().Next(minValue, maxValue + 1);
        }
        StartRow++;
        //правый ряд
        for (int i = StartRow; i < EndRow; i++)
        {
            resArray[i, EndCol - 1] = new Random().Next(minValue, maxValue + 1);
        }
        EndCol--;
        //нижний ряд
        if (EndRow > StartRow)
        {
            for (int i = EndCol - 1; i >= StartCol; i--)
            {
                resArray[EndRow - 1, i] = new Random().Next(minValue, maxValue + 1);
            }
            EndRow--;
        }
        //левый ряд
        if (EndCol > StartCol)
        {
            for (int i = EndRow - 1; i >= StartRow; i--)
            {
                resArray[i, StartCol] = new Random().Next(minValue, maxValue + 1);
            }
            StartCol++;
        }
    }
    return resArray;
}

Console.Write("Введите число строк массива: ");
int countX = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int countY = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minNumber = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxNumber = int.Parse(Console.ReadLine());
int[,] array = GetArray(countX, countY, minNumber, maxNumber);
PrintArray(array);
Console.WriteLine();