/* Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом. 

Console.WriteLine("Please enter an integer number: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Pal (num);

void Pal (int num)
{
    int num2 = num;
    int interim = 0;
    while (num > 0)
    {
        interim = interim * 10 + num % 10;
        num = num / 10;
    }
    if (num2 == interim)
    Console.WriteLine("WOW! It's a palindrome!");
    else
    Console.WriteLine("Nope, it's not a palindrome");
}
*/

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Define the first point:");
Console.Write("x: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Good! Now define the second point:");
Console.Write("x: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The distance between these two points is: " + Math.Round(Distance(x1, x2, y1, y2, z1, z2), 2));

double Distance (double a, double b, double c, double d, double e, double f) {
double result = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)));
return result;
                 }
*/

/* Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Type your natural number here: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1) Console.WriteLine ("Choose any NATURAL number");
else Cubes (num);

void Cubes (int num) {
    int interim = 1;
    while (interim <= num) 
    {
       Console.Write(interim * interim * interim + " ");
        interim ++;
    }
   
}*/

