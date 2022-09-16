// Напишите программу, которая на вход принимает трехзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num < 1000 && num > 99)
{
    Console.WriteLine($"{num} -> {num / 10 % 10 }");
}
else
    Console.WriteLine("Число должно быть трехзначным!");
