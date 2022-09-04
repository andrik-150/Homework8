/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] Getmass(int x, int y, int z)
{
    int[,,] arr = new int[x, y, z];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int k = 0;
            while (k < arr.GetLength(2))
            {
                int number = new Random().Next(10, 100);
                if (FindSameNumber(arr, number) == true)
                {
                    arr[i, j, k] = number;
                    k++;
                }
                else continue;
            }
        }
    }
    return arr;
}

bool FindSameNumber(int[,,] mass, int findNumber)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                if (mass[i, j, k] == findNumber) return false;
            }
        }
    }
    return true;
}

void PrintArray(int[,,] mass1)
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            for (int k = 0; k < mass1.GetLength(2); k++)
            {
                Console.Write($"{mass1[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите размер массива, x: ");
int countX = int.Parse(Console.ReadLine());
Console.Write("Введите размер массива, y: ");
int countY = int.Parse(Console.ReadLine());
Console.Write("Введите размер массива, z: ");
int countZ = int.Parse(Console.ReadLine());
int[,,] resArray = Getmass(countX, countY, countZ);
PrintArray(resArray);