// Напиши программу, которая на вход принимает координаты точки (Х; Y), 
// причем Х не равно 0 и Y не равно 0, и выдает номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки Х");
Console.Write("Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)
{ if (xc > 0 && yc > 0) return "Первая четверь";
    if (xc > 0 && yc < 0) return "Вторая четверь";
    if (xc < 0 && yc < 0) return "Третья четверь";
    if (xc < 0 && yc > 0) return "Четвертая четверь";
    return "Введены некорректные координаты";
}
string result = Quarter(x, y);
Console.WriteLine(result);
