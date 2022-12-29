//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) / 10;
    return array;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();  
    }
}
double[,] myArray = CreateRandom2dArray(4, 5, -100, 100);
Show2dArray(myArray);
*/

//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
        
    }
}
void ElementValue(int[,] array)
{
    Console.Write("Input row number: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input column number: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if(i < array.GetLength(0) && j < array.GetLength(1))
    {
        int num = array[i,j];
        Console.WriteLine("Your element is: " + num);    
    }
    else
        Console.WriteLine("There are no numbers with these indexes in the array");
}
int[,] myArray = CreateRandom2dArray(4, 5, 1, 10);
Show2dArray(myArray);
ElementValue(myArray);
*/

//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
double[] Avarage(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];
        newArray[j] = Math.Round((sum / array.GetLength(0)),1);;
    }
    return newArray;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
int[,] myArray = CreateRandom2dArray(4, 5, 1, 10);
Show2dArray(myArray);
Console.Write("Avarage of columns is: ");
double[] newArray = Avarage(myArray);
ShowArray(newArray);
*/