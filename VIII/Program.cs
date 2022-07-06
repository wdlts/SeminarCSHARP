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
*/





//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
/*
4263
8357
7345

0000
8057
7045

*/
/*
int[,] CreateRandomTwoDimArray(int m, int n, int min, int max)
{
    int[,] newMatrix = new int[m,n];

    for(int i = 0; i< m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
        }
    }
    return newMatrix;
}

void ShowTwoDimArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}




int[,] DeleteRowColumn(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int min = array[minRow, minColumn];

    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            if (array[i,j] < min)
            {
                min = array[i,j];
                minRow = i;
                minColumn = j;
            }
        }
    }

    for (int i = 0; i<array.GetLength(0); i++)
    {
        array[i, minColumn] = 0;
    }
     for (int j = 0; j<array.GetLength(1); j++)
    {
        array[minColumn, j] = 0;
    }
    return array;
}

int[,] myArray = CreateRandomTwoDimArray(4,6,1,9);
ShowTwoDimArray(myArray);
Console.WriteLine();
myArray = DeleteRowColumn(myArray);
ShowTwoDimArray(myArray);
*/





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
/*
int[,] MinRowSum (int[,] array)
{   
    int sum=0;
    
    for (int i = 0; i<array.GetLength(0); i++)
    {
        sum=0;
        for (int j = 0; j<array.GetLength(1); j++)
        {
            sum=sum + array[i,j];
            array[i,j] = sum;
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
        
    }
    return array;
    
}
*/

void ShowMinRow (int[,] array)
{
    int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;
    for(int i = 0; i < array.GetLength(0); i++) //Проходим по циклу строк
        {
            Sum2 = 0;
        for(int j = 0; j < array.GetLength(1); j++) //Проходим по циклу столбцов
            {   Sum2 += array[i, j];} //Сумма всех членов 1ой строки.
                if(Sum2 < Sum1)
            {   Sum = Sum2; Row = i;}
                Sum1 = Sum2;
        }
        Console.WriteLine("Smallest sum = {0}", Sum);
        Console.WriteLine("Row nr. = {0}", Row+1);
}



/*
{   
           
    int liml =  array.GetLength(1); 
    int limk =  array.GetLength(0);
    int min=array[limk-1,liml-1];
    int minrownr=0;
    
    for (int k = 0; k<array.GetLength(0); k++)
    {
        
        for (int l = liml-1; l<array.GetLength(1); l++)
        {
            
            if (min > array[k,l])
            
            {
                Console.WriteLine(l);
                min = array[k,l];
                minrownr = l;
                
            }
            
            
        }
        
    }
       
}
*/

int[,] newArray = NewArray(5,5);
ShowMinRow(newArray);