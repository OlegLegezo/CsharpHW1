// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// Примеры:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("введите первое целое число:");
int a = int.Parse(Console.ReadLine());
Console.Write("введите второе целое число:");
int b = int.Parse(Console.ReadLine());
int max;
int min;

if (a == b)
{
    bool res1 = a == b;
    Console.WriteLine(res1 ? "числа равны" : "");
}

else
{
    if (a > b)
    {
        max = a;
        min = b;
    }
    else
    {
        max = b;
        min = a;
    }

    Console.Write("большее число = ");
    Console.WriteLine(max);
    Console.Write("меньшее число = ");
    Console.WriteLine(min);
}



