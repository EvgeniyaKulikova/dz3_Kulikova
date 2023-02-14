//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double DistanceAB (int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;

    double distAB = Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ), 2);
    return distAB;
}
Console.Write("imput X coordinat of A: ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("imput Y coordinat of A: ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("imput Z coordinat of A: ");
int zAcoord = Convert.ToInt32(Console.ReadLine());

Console.Write("imput X coordinat of B: ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("imput Y coordinat of B: ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("imput Z coordinat of B: ");
int zBcoord = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);
Console.WriteLine($"distance between A & B: {distanceAB}");




