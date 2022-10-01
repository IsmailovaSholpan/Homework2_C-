// Напишите программу, которая  принимает на вход число, 
// и выдает кол-во цифр в числе.

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountNumber(int num)
{
    if (num != 0)
    {
        if (num < 0) num = -num;
        int i = 0;
        for (i = 0; i <= num; i++)
        {
            num = num / 10;
        }
        return i;
    }
    return 1;
}
int result = CountNumber(number);
Console.WriteLine(result);

