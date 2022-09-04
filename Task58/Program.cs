/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] GetArray(int sizeMatrix, int minValue, int maxValue)
{
    int[,] res = new int[sizeMatrix, sizeMatrix];
    for (int i = 0; i < sizeMatrix; i++)
    {
        for (int j = 0; j < sizeMatrix; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return res;
}

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

int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                resMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resMatrix;
}

Console.Write("Введите размер матриц : ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент матриц: ");
int minNumber = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент матриц: ");
int maxNumber = int.Parse(Console.ReadLine());
int[,] array1 = GetArray(size, minNumber, maxNumber);
int[,] array2 = GetArray(size, minNumber, maxNumber);
Console.WriteLine("Исходные матрицы:");
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Полученная матрица после перемножения: ");
Console.WriteLine();
int[,] resMultMatrix = MultMatrix(array1, array2);
PrintArray(resMultMatrix);
Console.WriteLine();