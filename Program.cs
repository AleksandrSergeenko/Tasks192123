/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
 */

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