// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Please enter your first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter your second natural number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b > 0)
Console.WriteLine("The result of raising " + a + " to the power of " + b + " is: " + Exponent(a, b));
else Console.WriteLine("Your second number must be NATURAL");

int Exponent (int x, int y)
{
//    int result = (int)Math.Pow(x, y); // Решение с использованием встроенного метода
  int result = 1;                       // Решение через цикл
  for (int i = 0; i < y; i++)
    {
        result *= x;
    }
    return result;
} 

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
int size = 8;
int [] array = new int [size];

Console.WriteLine("Do you want to autofill the array?"); // Пользователь выбирает между автозаполнением и заполнением вручную
string answer = Console.ReadLine();

if (answer == "yes") // Код для автозаполнения массива
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101); 
        Console.Write(array[i] + " ");
    }
}

else if (answer == "no") // Код для заполнения массива значениями пользователя
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write("Add any integer number: ");
        array [index] = Convert.ToInt32(Console.ReadLine());
    }
    foreach(int el in array)
    {
           Console.Write(el + " ");
    }
}

else Console.WriteLine("Please enter 'yes' or 'no'");
*/