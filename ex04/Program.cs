// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Примеры:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("введите первое целое число:");
int a = int.Parse(Console.ReadLine());
Console.Write("введите второе целое число:");
int b = int.Parse(Console.ReadLine());
Console.Write("введите третье целое число:");
int c = int.Parse(Console.ReadLine());


int max1=Math.Max(a, b);
int max2=Math.Max(a, c);
int max=Math.Max(max1, max2);

Console.WriteLine(max);
