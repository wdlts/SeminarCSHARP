
//ZADACHA 1
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
        Console.Write (newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int FindEvenSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) sum++;
    }
    return sum;
}

int[] myArray = CreateRandomArray(10);
Console.WriteLine("Total even numbers " + FindEvenSum(myArray));
*/


//ZADACHA 2
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

/*
int[] NewRandomArray(int size)
{
    
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(-99, 100);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int SumOfOddPositions(int[] newArray2)
{
    int sum = 0;
    for (int i = 0; i < newArray2.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += newArray2[i];
        }
    }
    return sum;
}
int[] newArray3 = NewRandomArray(5);
Console.WriteLine("Sum of digits on odd positions = " + SumOfOddPositions(newArray3));
*/



//ZADACHA 3
//Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
/*
double[] ArrayDouble(int size)
{
    double[] newArray = new double[size];
    for (int i = 0; i<size; i++)
    {
        newArray[i] = Math.Round(new Random().NextDouble()/0.01);
        Console.Write(newArray[i] + " ");
    }
    return newArray;
}

double Max(double[] array)       
{
    double max = array[0];        
    for (int i = 0; i < array.Count(); i++) 
    {
        if (max < array[i])   
        {
            max = array[i];  
        }
    }
    return max;  
}

double Min(double[] array)       
{
    double min = array[0];        
    for (int i = 0; i < array.Count(); i++) 
    {
        if (min > array[i])   
        {
            min = array[i];  
        }
    }
    return min;  
}

double[] array3 = ArrayDouble(5);
Console.WriteLine();
Console.WriteLine($"Max number is: {Max(array3)}");
Console.WriteLine($"Min number is: {Min(array3)}");
double result = (Max(array3)) - (Min(array3));
Console.WriteLine($"Max - Min = {result}");

*/
