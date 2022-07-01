//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива
/*
int [,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int [,] array = new int[m,n];
    for (int i = 0; i<n; i++)
    {
        for (int j = 0; j<n; j++)
        {
            array[i,j] = new Random().Next(min, max+1);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    
}

int[,] ChangeLines(int[,] array, int strIndex1, int strIndex2)
{
    int temp;
    for (int j = 0; j<array.GetLength(1); j++)
    {
        temp = array[strIndex1, j];
        array[strIndex1, j] = array[strIndex2, j];
        array[strIndex2, j] = temp;
    }
    return array;
}

int[,] myArray = CreateTwoDimArray(4, 5, 1, 9);
ShowArray(myArray);
myArray = ChangeLines(myArray, 2, 1);
Console.WriteLine();
ShowArray(myArray);
*/




//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
123
456
789

147
258
369
*/

int [,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int [,] array = new int[m,n];
    for (int i = 0; i<n; i++)
    {
        for (int j = 0; j<n; j++)
        {
            array[i,j] = new Random().Next(min, max+1);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] MatrixChange (int[,] array)
{
    if (array.GetLength(0) = array.GetLength(1))
    {
        int temp;
        for (int i = 0, j = 0; i < array.GetLength(0)-1; i++)
        {
            for (int j = i+1; j<array.GetLength(1); j++)

            temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
          
        }
        return array;
    }
}






//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
/*
4263
8357
7345

0000
8057
7045

*/


