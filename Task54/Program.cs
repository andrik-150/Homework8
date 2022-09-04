/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] GetArray(int sizeX, int sizeY, int minValue, int maxValue)
{
    int[,] res = new int[sizeX, sizeY];
    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
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

int[] SortArray(int[] inArray)
{
    int temp = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] < inArray[j])
            {
                temp = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = temp;
            }
        }
    }
    return inArray;
}

int[,] ConvertArray(int[,] mass2)
{
    int[,] convertMass = new int[mass2.GetLength(0), mass2.GetLength(1)];
    int[] tempArray = new int[mass2.GetLength(1)];

    for (int i = 0; i < mass2.GetLength(0); i++)
    {
        for (int j = 0; j < mass2.GetLength(1); j++)
        {
            tempArray[j] = mass2[i, j];
        }
        int[] newTempArray = SortArray(tempArray);
        for (int j = 0; j < mass2.GetLength(1); j++)
        {
            convertMass[i, j] = newTempArray[j];
        }
    }
    return convertMass;
}

Console.Write("Введите число строк массива : ");
int countX = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива : ");
int countY = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minNumber = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxNumber = int.Parse(Console.ReadLine());
int[,] array = GetArray(countX, countY, minNumber, maxNumber);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
int[,] resArray = ConvertArray(array);
Console.WriteLine("Новый массив:");
PrintArray(resArray);