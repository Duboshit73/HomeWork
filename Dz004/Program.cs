// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
int Stepen(int a, int b)
{
    int rez = 1;
    if (b < 0)
    {
        b = Math.Abs(b);
    }
    for (int i = 0; i < b; i++)
    {
        rez = rez * a;
    }
    return rez;
}
Console.Write(" Введите число ");
int volA = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите число ");
int volB = Convert.ToInt32(Console.ReadLine());
int count = Stepen(volA, volB);
Console.Write(" результат А в степени В  " + count);
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int n)
{
    int summa = 0;
    while (n > 0)
    {
        summa = summa + n % 10;
        n = n / 10;
    }
    return summa;
}
Console.Write(" Введите число  ");
int volN = Convert.ToInt32(Console.ReadLine());
int S = Sum(volN);
Console.WriteLine(" Сумма цифр числа  " + volN + " равна " + S);
*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
void Newarray(int[] mass)
{
    int length = mass.Length;
    int index = 0;
    while (index < length)
    {
        mass[index] = new Random().Next(1, 40);
        index++;
    }
}

void PrintArray(int[] massiv)
{
    int size = massiv.Length;
    int pos = 0;
    while (pos < size)
    {

        Console.Write(massiv[pos] + ", ");
        pos++;
    }
}
int[] array = new int[8];
Newarray(array);
PrintArray(array);
*/
