// Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу квадратов чисел от 1 до N
Console.Clear();
Console.Write("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

void Digite(int num1, int count1)
{
    while (count <= num)
    {
        Console.WriteLine($"|{count}  {count * count, 3}|");
        count = count + 1;
    }
};

// if (num<=0)
// {
//     Console.WriteLine("Число должно быть больше 0.");
// }
Digite(num, count);
