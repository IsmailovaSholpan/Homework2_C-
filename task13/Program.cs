// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = num;
if (num < 100)
{Console.WriteLine($"{num} -> третьей цифры нет");}
else 
{while (count > 1000)
{ 
    count = count / 10; 
}
Console.WriteLine($"{num} -> {count % 10}");}

