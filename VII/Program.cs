//Пользователь задает 2 числа и диапазон, нужно заполнить двумерный массив
/*
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j<b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max+1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int[,] array = CreateRandomTwoDemArray(4, 5, 1, 9);
*/

//1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j.
//Выведите полученный массив на экран.
/*int[,] CreateArray(int m, int n)
{
    int[,] newMatrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            newMatrix[i,j] = i + j;
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int[,] array = CreateArray(4, 5);
*/

//2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
/*
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j<b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max+1);


            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return newMatrix;
}

int[,] array = CreateRandomTwoDemArray(4, 5, 1, 9);


int[,] NewArray(int[,] array)
{
    

    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l<array.GetLength(1); l++)
        {
            
            if (k % 2 == 0 && l % 2 == 0)
            {
                array[k,l] = array[k,l] * array[k,l];
                
            }
            
            Console.Write(array[k,l] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
int[,] array1 = NewArray(CreateRandomTwoDemArray(5, 5, 1, 9));
*/


//3. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j<b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max+1);


            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return newMatrix;
}

int[,] array = CreateRandomTwoDemArray(5, 5, 1, 9);


int SumOfElements(int[,] array)
{

     
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j<b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max+1);


            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return newMatrix;
}

*/