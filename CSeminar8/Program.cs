
 
int[,] CreateRandomArray2d (int [,] massive, int min, int max) // заполняет двумерный массив случайными целыми числами
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        	massive[i,j] = new Random().Next(min, max);
    }
    return massive;
}
void PrintArray2D(int [,] massive) // выводит массив на экран
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
            Console.Write(massive[i,j] + " ");
        Console.WriteLine(); 
    }
}

// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

int[,] myArray = new int[6,6];
CreateRandomArray2d(myArray,1,10);
PrintArray2D(myArray);
Console.WriteLine();
SortArray2dAsc(myArray);
PrintArray2D(myArray);

int[,] SortArray2dAsc(int[,] massive)
{
	int temp;
	for (int i = 0; i < massive.GetLength(0); i++)
	{
		temp = 0;
		for (int j = 0; j < massive.GetLength(1); j++)
		{
			for (int m = j +1; m < massive.GetLength(1); m++)
			{
				if (massive[i,m] < massive[i,j])
				{
					temp = massive[i,j];
					massive[i,j]=massive[i,m];
					massive[i,m] = temp;
				}
			}
		}
	}
	return massive;
}

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] newArray = new int [5,3];
CreateRandomArray2d(newArray, 1, 10);
PrintArray2D(newArray);
Console.WriteLine();
MinSumStr(newArray, 10);

void MinSumStr (int [,] array, int maxElement)
{
	int minSum = maxElement * array.GetLength(0);
	int minSumLine = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		int sum = 0;
		for (int j = 0; j < array.GetLength(1); j++)
			sum += array[i,j];
		if (sum < minSum)
		{
			minSum = sum;
			minSumLine = i + 1; // нумерация строк начинается с 1
		} 
	}
	Console.WriteLine($"Минимальная сумма элементов находится в {minSumLine} строке и равна {minSum}");
}

// Задача 62. Заполните спирально массив 4 на 4.

int n = 4;
int [,] myArray = new int [n,n];
SnailFill(myArray);
PrintArray2D(myArray);

void SnailFill(int[,] massive)
{
	int el = 1;
	int top = 0;
	int right = n-1;
	int bottom= n-1;
	int left = 0;

	while (top <= bottom)
	{
		for (int j = left; j <= right; j++)
			massive[top,j] = el++;
		top++; // поворот вниз

		for (int i = top; i <= bottom; i++)
			massive[i,right] = el++;
		right--; // поворот налево

		for (int j = right; j >= left; j--)
			massive[bottom,j] = el++;
		bottom--; // поворот наверх

		for (int i = bottom; i >= top; i--)
			massive[i,left] = el++;
		left++; // поворот направо
	}
}
