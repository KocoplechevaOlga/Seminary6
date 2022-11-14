// Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон.

bool TeorSumTrisngl (int a, int b, int c)
{
    return c < a + b && a < b + c && b < a + c;
}

Console.WriteLine("Введите 1 сторону: ");
int len1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 сторону: ");
int len2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3 сторону: ");
int len3 = Convert.ToInt32(Console.ReadLine());

bool res = TeorSumTrisngl(len1, len2, len3);
Console.WriteLine(res == true ? "Треугольник возможен" : "Треугольник не возможен");
