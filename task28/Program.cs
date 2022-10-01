// Напишите программу, которая на вход принимает число N
//  и выдает произведение чисел от 1 до N
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int MultNumbers(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult *= i;
    }
    return mult;
}
if (number <= 0) { Console.WriteLine("Число должно быть больше нуля!"); }
else
    // int multnumbers= MultNumbers(number);

    Console.WriteLine($"Произведение чисел от 1 до {number} = {MultNumbers(number)}");

