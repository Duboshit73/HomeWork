// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
int CountsEvenNumbers (int[]array)
{
    int count = 0;
    for  (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}
Console.Write("Input amount of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, 100, 999);
ShowArray(myArray);
int even = CountsEvenNumbers(myArray);
Console.WriteLine($"There are {even} even numbers in this array");
*/

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
int CountsEvenPosition (int[]array)
{
    int count = 0;
    for  (int i = 1; i < array.Length; i++)
        if (i % 2 == 1)
            count += array[i];
    return count;
}
Console.Write("Input amount of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, 1, 50);
ShowArray(myArray);
int sum = CountsEvenPosition(myArray);
Console.WriteLine($"Sum of elements is {sum}");
*/

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    
    for(int i = 0; i < size; i++)
        array[i] = Convert.ToDouble( new Random().Next(minValue, maxValue +1)) / 100;
    return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
double FindDifference (double[]array)
{
    double min = 100;
    double max = 0;
    double difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i]; 
    
    
    difference = (max - min);
    }
    return difference;
}
Console.Write("Input amount of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(size, 100, 10000);
ShowArray(myArray);
double diff = FindDifference(myArray);
Console.WriteLine("Difference is " + diff);
*/