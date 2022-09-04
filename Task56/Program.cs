/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/
// Задаем массив, как в предыдущей задаче

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

void FindSumAndIndex(int[,] inArray)
{
    int sumFirstLow = 0;
    int[] firstRow = new int[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        firstRow[j] = inArray[0, j];
        sumFirstLow += inArray[0, j];
    }
    int indexMinSum = 0;
    int minSum = sumFirstLow;
    int[] minRow = firstRow;
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        int sumLow = 0;
        int[] tempRow = new int[inArray.GetLength(1)];
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sumLow += inArray[i, j];
            tempRow[j] = inArray[i, j];
        }
        if (sumLow < minSum)
        {
            minSum = sumLow;
            indexMinSum = i;
            minRow = tempRow;
        }
    }
    Console.Write($"Наименьшая сумма элементов, равная {minSum}, находится в строке с позицией {indexMinSum}: ");
    Console.WriteLine($"[{String.Join(", ", minRow)}]");
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
FindSumAndIndex(array);