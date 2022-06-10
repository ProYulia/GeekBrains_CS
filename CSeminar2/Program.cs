/* Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа 

int num;

Console.Write("Enter any three-digit number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
Console.WriteLine(ShowMiddleNum(num));
else Console.WriteLine("Error: " + num + " does not meet the requirements");

int ShowMiddleNum (int num)
{
  return (num / 10 % 10);
}

/* Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

int num;
Console.Write("Enter an integer number: ");
num = Convert.ToInt32(Console.ReadLine());
ThirdNumber(num);

void ThirdNumber (int num) {

    if (num < 0) num = num * -1;

    if (num < 100)
    Console.WriteLine("Number " + num +" does not have the third digit");
    else if (num > 99 && num < 1000)
    Console.WriteLine(num = num % 10);
    else {
        while (num > 1000)
        {
            num = num / 10; 
        }
        Console.WriteLine(num = num % 10);
    }
}
*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

int num;

Console.WriteLine("Enter any number between 1 and 7");
num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 7) 
Console.WriteLine("Choose between 1,2,3,4,5,6,7");
else Console.WriteLine(Day(num));

string Day (int num)
{
    if (num > 0 && num < 6) return "It's a workday";
    else return "It's a day-off";   
}
*/




