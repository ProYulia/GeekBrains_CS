// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
/*

int[] myArray = CreateRandomArray(12,-9,9); // создаем массив и записываем туда значения с помощью метода
Console.WriteLine("Sum of positive numbers is: " + FindPositiveSum(myArray));
Console.WriteLine("Sum of negative numbers is: " + FindNegativeSum(myArray));

int[] CreateRandomArray(int size, int min, int max)
    {
        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
        }
    Console.WriteLine(); // пропускаем строку
    return newArray; // возвращает массив целиком
    } 

int FindPositiveSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
        if (array[i] > 0) sum += array[i];
        }   
    return sum;
    }

int FindNegativeSum(int[] array)
    {
        int sum = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < 0) sum += array[i];
        }
        return sum;
    }
*/

// 2. Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int [] array2 = CreateRandomArray(8, -10, 10);
int[] array2Reverse = ReverseCoeff(array2);
PrintArray(array2Reverse);


int[] CreateRandomArray(int size, int min, int max) // создаем массив с случайными числами
    {
        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
            {
                newArray[i] = new Random().Next(min, max + 1);
                Console.Write(newArray[i] + " ");
            }
        Console.WriteLine();
        return newArray;
    }

int[] ReverseCoeff(int[] array) // меняем знак каждого элемента массива
    {
        for(int i = 0; i < array.Length; i++)
            {
                array[i] *= -1;
            }
        return array;
    }

void PrintArray (int [] anyArray) // выводим массив на экран
    {
        for(int i = 0; i < anyArray.Length; i++)
            Console.Write(anyArray[i] + " ");
    }
    */

 // 3. Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*

int[] newArray = CreateRandomArray(10, 100, 1000);
Console.WriteLine("The number of even numbers in this array is: " + CountEven(newArray));

int[] CreateRandomArray(int size, int min, int max)
    {
        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
        }
    Console.WriteLine();
    return newArray; 
    } 

int CountEven(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                count ++;
            }
        return count;
    }
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/*

int[] newArray = CreateRandomArray(10, -100, 101);
Console.WriteLine("The sum of numbers at odd positions is: " + SumOfOddIndex(newArray));

int[] CreateRandomArray(int size, int min, int max)
    {
        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
        }
    Console.WriteLine();
    return newArray; 
    } 

int SumOfOddIndex(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i+=2)
            {
                sum += array[i];
            }
        return sum;
    }
*/

//Задача 38: Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. 
//Найдите разницу между максимальным и минимальным элементов массива

Console.WriteLine();
double[] newArray = CreateRandomArray(10);
Console.WriteLine("The difference between max & min element of the array is: " + MaxMinDiff(newArray));
Console.WriteLine();

double[] CreateRandomArray(int size)
    {
        double[] newArray = new double[size];
        for (int i = 0; i < size; i++)
        {
        newArray[i] = Math.Round(new Random().NextDouble()*10, 2);
        Console.Write(newArray[i] + " ");
        }
    Console.WriteLine();
    return newArray; 
    } 

double MaxMinDiff(double[] array) 
    {
        double min = array[0];
        double max = array[0];
        double diff;
        for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
        diff = Math.Round(max - min, 2);
        return diff;
    }