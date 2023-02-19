/* 
Задача 19
Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
 */

/* 
Console.WriteLine($"Введите пятизначное число: ");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
        Console.WriteLine($"{number} -> да, число - палиндром");
    else
        Console.WriteLine($"{number} -> нет, число - не палиндром");
}
else
    Console.WriteLine($"Число {number} не является пятизначным");
 */

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
 */

/* 
point A;
point B;
Console.Write($"Ведите координату x точки A: ");
double.TryParse(Console.ReadLine()!, out A.x);
Console.Write($"Ведите координату y точки A: ");
double.TryParse(Console.ReadLine()!, out A.y);
Console.Write($"Ведите координату z точки A: ");
double.TryParse(Console.ReadLine()!, out A.z);
Console.Write($"Ведите координату x точки B: ");
double.TryParse(Console.ReadLine()!, out B.x);
Console.Write($"Ведите координату y точки B: ");
double.TryParse(Console.ReadLine()!, out B.y);
Console.Write($"Ведите координату z точки B: ");
double.TryParse(Console.ReadLine()!, out B.z);

double ans = Math.Round(Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2) + + Math.Pow(A.z - B.z, 2)), 2);
//вычисление раcстояния между А и В:
Console.Write($"A({A.x}; {A.y}; {A.z}) B({B.x}; {B.y}; {B.z}) -> {ans}");  

struct point
{
    public double x;

    public double y;

    public double z;
}
 */

/* Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* 
int N;
Console.Write($"Ведите число: ");
int.TryParse(Console.ReadLine()!, out N);

for (int i = 1; i <= N; i++)
    Console.Write($"{i * i * i}");
 */