//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Write("How many numbers do you want to enter?");
int userAmount = Convert.ToInt32(Console.ReadLine());
CountPositive(userAmount);

void CountPositive(int number)
{
int n = 0;
int count = 0;

while (n < number)
{
    Console.Write("Enter your number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) count++;
    n++;
}
Console.WriteLine($"Total amount of positive numbers is: {count}");
}


//Задача 45: Напишите программу, которая будет создавать копию 
//заданного массива с помощью поэлементного копирования.

/*
Console.Write("Original array: ");
int[] myArray = RandomArray(10);
Console.Write("Clone array:    ");
ArrayClone(myArray);

int[] RandomArray(int size)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(-100, 101);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

void ArrayClone(int[] array)
{
    int[] clone = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        clone[i] = array[i];
        Console.Write(clone[i] + " ");
    }
}
*/
