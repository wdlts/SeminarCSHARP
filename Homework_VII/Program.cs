/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
Console.WriteLine("Input row quantity: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column quantity: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] NewArrayRandomDouble(int m, int n)
{
    double[,] array = new double[m,n]; 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            array[i,j]  = Math.Round(Convert.ToDouble(new Random().Next(-100, 100)*0.1), 2);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();     
    }
    return array;
}

NewArrayRandomDouble(m, n);
*/


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
*/

/*
int[,] NewArray (int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();    
    }
    return array;
} 


void ArrayCheckPosition (int[,] newarray)
{
    Console.WriteLine("Input row index");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input column index");
    int l = Convert.ToInt32(Console.ReadLine());

    if (k == 0 || l == 0)
    {
        Console.WriteLine("Index should be greater than 0");
    }
    else
    {
        k--;
        l--;
        if (k < newarray.GetLength(0) && l < newarray.GetLength(1))
        {
            Console.WriteLine ($"Number on this position is {newarray[k,l]}");
        }
    else
        {   
            k++;
            l++;
            Console.WriteLine($"{k} {l} No such position in array");
        }
    }
}   

ArrayCheckPosition(NewArray(7,4));
*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


/*
int[,] NewArray (int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + "    ");
        }
    Console.WriteLine();    
    }
    Console.WriteLine(); 
    return array;
}   


void ArMean (int[,] newarray)
{
    double armean = 0;
    double sum = 0;
    double div = newarray.GetLength(0);
    
    for (int k = 0; k<newarray.GetLength(1); k++)
    {        
        for (int l = 0; l<newarray.GetLength(0); l++)
        {            
            sum = sum+newarray[l, k];
            armean = Math.Round((sum / div), 1);
        }
        sum=0;
        Console.Write(armean + "  ");
    }
    Console.WriteLine(); 
}

Console.WriteLine("Input row quantity");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column quantity");
int l = Convert.ToInt32(Console.ReadLine());
ArMean(NewArray(k,l));
*/

