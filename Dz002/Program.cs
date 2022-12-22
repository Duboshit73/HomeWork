// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num)
{
    int result;
    int dec = num / 10 % 10;
    result = dec;
    return result;
}
Console.Write("Input a three-digit number ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = SecondDigit(number);
Console.WriteLine("The second digit is " + secondDigit);
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdDigit(int number)
{
    int result;
    if (number /10 > 10)
    {
        int ed = number % 10;
        result = ed;
        Console.WriteLine("Third digit is " + result);
    }
    else
    {
        int ed = number % 10;
        result = ed;
        Console.Write("No third digit");
    }
    return result;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdNumber = ThirdDigit(number);
*/

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Weekends(int number)
{
    bool result;
    if (number > 7)
    {
        Console.WriteLine("Please, input correct day namber");
    }
    if (number == 7 || number == 6)
    
        result = true;
    
    else
    
        result = false;
    
    return result;
}
Console.Write("Input day number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool weekends = Weekends(number);
Console.WriteLine(weekends);
*/