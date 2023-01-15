//Задача 1. Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);
}
ShowNums(8);
*/

// Задача 2. Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNums(int m, int n)
{
    if(m > n) return SumNums(m - 1, n) + n;
    if(m < n) return SumNums(m, n - 1) + n;
    else return m;
}
Console.Write(SumNums(1, 6));
*/

// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
/*
int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m,n - 1));
    return Ackermann(m,n); 
}                  
Console.Write("Input positive number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive number n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ackermann function (m, n) = " + Ackermann(m,n));
*/