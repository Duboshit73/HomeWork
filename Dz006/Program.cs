// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int AmountPositiveNums(int M)
{
    int amount = 0;
    int count = 0;
    do
    {
        Console.Write("Input a number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        if (num > 0) count++;
        amount++;
    }
    while (amount < M);
    return count;
}
Console.Write("Input amount of numbers: ");
int m = Convert.ToInt32(Console.ReadLine());
int result = AmountPositiveNums(m);
Console.WriteLine($"Amount of positive numbers is {result}");
*/

// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write("Input k1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());
if (b1==b2 & k1==k2) Console.WriteLine("Lines coincide");
    else if (k1==k2) Console.WriteLine("Lines are parallel");
        else 
        {
            double x = -(b1 - b2) / (k1 - k2);
            double y = k1 * x + b1;
            Console.WriteLine($"Point intersection is ({x};{y})");
        }
*/