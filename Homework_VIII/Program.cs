/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
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

void ArraySort (int[,] array)
{
    int temp;
    for (int k = 0; k<array.GetLength(1); k++)
    {
        for (int a = 1; a<array.GetLength(0); a++)
        {
            for (int b = (array.GetLength(0))-1; b >= a; b--)
            {
                if (array[k,b-1] > array[k,b])
                    {
                        temp = array[k,b-1];
                        array[k,b-1] = array[k, b];
                        array[k, b] = temp;
                    }
            }
        }
    } 
    Console.WriteLine();  
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();    
    }
}

Console.WriteLine("Input rows number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns number");
int n = Convert.ToInt32(Console.ReadLine());

ArraySort(NewArray(m,n));
*/



/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void ShowMinRow (int[,] array)
{
    int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        {
            Sum2 = 0;
        for(int j = 0; j < array.GetLength(1); j++)
            {Sum2 += array[i, j];}
                if(Sum2 < Sum1)
            {Sum = Sum2; Row = i;}
                Sum1 = Sum2;
        }
        Console.WriteLine("Smallest sum = {0}", Sum);
        Console.WriteLine("Row nr. = {0}", Row+1);
}

Console.WriteLine("Input rows number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns number");
int n = Convert.ToInt32(Console.ReadLine());

int[,] newArray = NewArray(m,n);
ShowMinRow(newArray);
*/



/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

/*
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

int[,] SpiralFill()
{    
    Console.WriteLine("Input side number");
    int N = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[N,N];
    int num = 1;
    
    for (int innum = 0; innum < N-2; innum++)
    {
        for (int i = 0+innum; i < N - innum; i = i+1)
        {
            array[0+innum,i] = num;
            num++;
        }
        num--;
        for (int i = 0+innum; i< N-innum; i++)
        {
            array[i,N-1-innum] = num;
            num++;
        }
        num--;
        for (int i = N-1-innum; i >= 0+innum; i--)
        {
            array[N-1-innum,i] = num;
            num++;
        }
        num--;
        for (int i = N-1-innum; i >=1+innum; i--)
        {
            array[i,0+innum] = num;
            num++;
        }
    }
    return array;   
}

int[,] myArray = SpiralFill();
ShowArray(myArray);

*/