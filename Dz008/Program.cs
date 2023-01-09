// Задача 1. Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
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
    Console.WriteLine();
}
void SortingArray(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for (int m = 0; m < array.GetLength(1) - 1; m++)
            {
                if (array[i, m] < array[i, m + 1])
                {
                    int temp = array[i, m];
                    array[i, m] = array[i, m + 1];
                    array[i, m + 1] = temp;
                }
            }
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
SortingArray(myArray);
Show2dArray(myArray);
*/

// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
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
    Console.WriteLine();
}
int FindRowWithTheSmallestAmount(int[,] array)
{
    int minSum = 0;
    int row = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if (minSum == 0) minSum = sum;
        Console.WriteLine($"Sum of elements {i + 1} row is: {sum}");
        if (sum < minSum) row = i;
    }
    return row;
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int row = FindRowWithTheSmallestAmount(myArray);
Console.WriteLine("Row with minimum sum of elements is: " + (row + 1));
*/

// Задача 3. Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
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
    Console.WriteLine();
}
int[,] MatrixProduct(int[,] oneArray, int[,] twoArray)
{
    int[,] matrixProduct = new int[oneArray.GetLength(0), twoArray.GetLength(1)];
        for(int i = 0; i < oneArray.GetLength(0); i++)
            for(int j = 0; j < twoArray.GetLength(1); j++)
                for(int k = 0; k < oneArray.GetLength(1); k++)
                    matrixProduct[i, j] += oneArray[i, k] * twoArray[k, j];
    return matrixProduct;
}
Console.WriteLine("First array:");
int[,] oneArray = CreateRandom2dArray();
Console.WriteLine("Second array:");
int[,] twoArray = CreateRandom2dArray();
Show2dArray(oneArray);
Show2dArray(twoArray);
Show2dArray(MatrixProduct(oneArray, twoArray));
*/

// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] Create3dArray(int rows, int columns, int depth, int min, int max)
{
    int[,,] array = new int[rows, columns, depth];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
            {
                int element = new Random().Next(min, max + 1);
                    if(FindElement(array, element)) continue;
                    array[i, j, k] = element;
            }                
    return array;
        bool FindElement(int[,,] array, int el)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] == el) return true;
                    }
                }
            }
            return false;
        }
}
void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            Console.WriteLine();
        
    }
    Console.WriteLine();
}
int[,,] myArray = Create3dArray(2, 2, 2, 10, 99);
Show3dArray(myArray);
*/

// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] CreateSpiralArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= rows * columns)
    {
        array[i, j] = num; 
        if(i <= j + 1 && i + j < columns - 1) j++;
        else if (i < j && i + j >= rows - 1) i++;
        else if (i >= j && i + j > columns - 1) j--;
        else --i;    
        ++num;
    }
    return array;
}
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
        
    }
    Console.WriteLine();
}
int[,] myArray = CreateSpiralArray(6, 6);
ShowArray(myArray);
*/