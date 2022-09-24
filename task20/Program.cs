// Напишите программу, которая принимает координаты двух точек
// и находит расстояние между ними в 2Д пространстве.

Console.WriteLine("Введите координаты точки А");
Console.Write("Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());


double Distance(int xc1, int yc1, int xc2, int yc2)
{
    // if (xc1 > xc2) return a = xc1 - xc2;
    // if (xc1 < xc2) return a = xc2 - xc1;
    // if (yc1 > yc2) return b = yc1 - yc2;
    // if (yc1 < yc2) return b = yc2 - yc1;
    double c = (xc1 - xc2)*(xc1 - xc2) + (yc1 - yc2)*(yc1 - yc2);
    return Math.Round(Math.Sqrt(c),2, MidpointRounding.ToZero); 
}

double result = (Distance(x1, y1, x2, y2));
Console.WriteLine(result);

