// Программа, формирующая трёхмерный массив из неповторяющихся двузначных чисел. 
// Программа построчно выводит массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
bool IsIncorrectInput(int number)
{
    return number < 1;
}
int[,,] Fill3DArray(int x, int y, int z)
{
    int[,,] array3D = new int[x, y, z];
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            int k = 0;
            while (k < array3D.GetLength(2))
            {
                bool IsExist = false;
                int number = new Random().Next(10, 100);
                for (int l = 0; l < x; l++)
                {
                    for (int m = 0; m < y; m++)
                    {
                        for (int n = 0; n < z; n++)
                        {
                            if (array3D[l, m, n] == number)
                            {
                                IsExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!IsExist)
                {
                    array3D[i, j, k] = number;
                    k++;
                }
            }
        }
    }
    return array3D;
}
void Print3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.WriteLine($"{array3D[i, j, k]}({i},{j},{k})");
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Программа создания трёхмерного массива из неповторяющихся двузначных чисел.");
Console.WriteLine("Программа построчно выводит массив, добавляя индексы каждого элемента.");
Console.WriteLine();
Console.WriteLine("Задайте размер трёхмерного массива.");
InputX:
Console.Write("Введите значение размерности x: ");
int x = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(x))
{
    Console.WriteLine();
    Console.WriteLine("Неверный ввод");
    Console.WriteLine();
    goto InputX;
}
InputY:
Console.Write("Введите значение размерности y: ");
int y = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(y))
{
    Console.WriteLine();
    Console.WriteLine("Неверный ввод");
    Console.WriteLine();
    goto InputY;
}
InputZ:
Console.Write("Введите значение размерности z: ");
int z = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(z))
{
    Console.WriteLine();
    Console.WriteLine("Неверный ввод");
    Console.WriteLine();
    goto InputZ;
}
int[,,] array3D = Fill3DArray(x, y, z);
Console.WriteLine();
Console.WriteLine("Трёхмерный массив:");
Print3DArray(array3D);
Console.WriteLine();