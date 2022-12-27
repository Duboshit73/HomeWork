// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool FindPalindrom (int num)
{
    bool result;
    if (num > 99999 || num < 10000)
    {
        Console.WriteLine("Please, input a five-digit number");
    }
    
    if (num / 10000 == num % 10 && num / 10000 % 10 == num % 100 % 10)
        
        result = true;
        
    else
        
        result = false;
    
    return result;
}
Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool findPalindrom = FindPalindrom(number);
Console.WriteLine(findPalindrom);
*/

//Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    return distance;
}
Console.Write("Input x-coordinate of tne first point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate of tne first point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z-coordinate of tne first point: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x-coordinate of tne second point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate of tne second point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z-coordinate of tne first point: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Distance = " + FindDistance(x1,y1,x2,y2,z1,z2));
*/

//Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void FindCube(int n)
{
    int count = 1;
    if(n < 1)
    {
        Console.WriteLine("Input a number more 1");
    }
    else
    {
        while (count <= n)
        {
            Console.WriteLine(Math.Pow(count,3));
            count++;
        }
    }
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
FindCube(n);
*/