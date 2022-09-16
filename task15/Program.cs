// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write ("Введите цифру от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 7 || num == 6) Console.WriteLine($"{num} -> Да");
else if (num >=1 && num <=5) Console.WriteLine($"{num} -> Нет");
else Console.WriteLine("Такого дня недели не существует");