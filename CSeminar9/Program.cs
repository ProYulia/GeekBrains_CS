// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите меньшее число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите большее число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} равна {RecSum(m, n)}");
int RecSum (int min, int max)
{
    if (max == min)
        return min;
    else return max + RecSum(min, max-1);
}

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {n} равно {RecDigitCount(n)}");

int RecDigitCount(int number)
{
    if (number < 10)
        return 1;
    else return 1 + RecDigitCount(number/10);
}

