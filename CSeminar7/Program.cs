// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Ведите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] userArray2d = new double[rows, columns];

Console.WriteLine();
CreateRamdomDoubleArray(userArray2d);
PrintDoubleArray2D(userArray2d);

double[,] CreateRamdomDoubleArray(double[,] array) // заполняет двумерный массив случайными дробными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().NextDouble()*10, 2); 
    }
    return array;
} 

void PrintDoubleArray2D(double [,] array) // выводит массив на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine(); 
    }
} 



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array2d = new int[5,5];
CreateRandomArray2d(array2d, 1, 10);
FindElement(array2d);

void FindElement(int[,] array) // ищет элемент массива
{
    try
    {
        Console.WriteLine($"Элемент на текущей позиции: {array[row,column]}");
    }
    catch (System.IndexOutOfRangeException)
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

int[,] CreateRandomArray2d (int [,] matrix, int min, int max) // заполняет двумерный массив случайными целыми числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i,j] = new Random().Next(min, max);
    }
    return matrix;
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Ведите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2d = new int[rows,columns];
CreateRandomArray2d(array2d, 1, 10);
PrintArray2D(array2d);
ColumnAvg(array2d);


void ColumnAvg (int [,] array) // считает среднее арифметическое каждого столбца
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
        sum = array[i,j] + sum;
        }
    sum = sum/array.GetLength(0);
    Console.WriteLine($"Среднее значение столбца {j + 1} равно: {sum}");
    } 
}

void PrintArray2D(int [,] array) // выводит массив на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine(); 
    }
}

int[,] CreateRandomArray2d (int [,] matrix, int min, int max) // заполняет двумерный массив случайными целыми числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i,j] = new Random().Next(min, max);
    }
    return matrix;
}
