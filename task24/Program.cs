// Напишите программу, которая на вход принимает число (А) 
// и выдает сумму чисел от 1 до А.

Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        // sum = sum + i; 
        sum += i;
    }
    return sum;
}

int sumnumbers= SumNumbers(a);
// Console.WriteLine($"Сумма чисел от 1 до {a} = {SumNumbers(SumNumbers(SumNumbers(a)))}"); // добавление метода в методе
Console.WriteLine($"Сумма чисел от 1 до {a} = {SumNumbers(a)}");