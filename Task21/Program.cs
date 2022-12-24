// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter point Xa coordinate: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter point Ya coordinate: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter point Za coordinate: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter point Xb coordinate: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter point Yb coordinate: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter point Zb coordinate: ");
int zb = Convert.ToInt32(Console.ReadLine());

double distance1 = Math.Round(Distance(xa, xb, ya, yb, zb, za), 2,MidpointRounding.ToZero);
Console.WriteLine($"Enter {xa} {xb} {ya} {yb} {za} {zb} distance = {distance1}");


double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
}