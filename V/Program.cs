//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max+1);
        Console.Write (newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i]; // sum = sum +array[i];
    }
    return sum;
}

int[] myArray = CreateRandomArray(12,-9,9);
Console.WriteLine("Sum of positive numbers is " + FindPositiveSum(myArray));
Console.WriteLine("Sum of negative numbers is " + FindNegativeSum(myArray));
*/

//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max+1);
        Console.Write (newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}



int[] ReverseArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *=(-1);
    }
    return array;
}

int[] array1 = CreateRandomArray(12, -9, 9);

int[] array2 = ReverseArray(array1);

for (int i = 0; i < array2.Length; i++)
{
    Console.Write(array2[i]+" ");
}
*/







//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max+1);
        Console.Write (newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}
*/
/*
bool IfDigitExists(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
            return true;
    }
    return false;
}
int[] array1 = CreateRandomArray(12, -9, 9);



Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (IfDigitExists (array1, a))
{
    Console.WriteLine($"Number {a} exists in array");
}
else
{
    Console.WriteLine($"Number {a} does not exist in array");
}

*/
//Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
/*
int Quantity (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <=99 ) sum++;
    }
    return sum;
}

int[] array1 = CreateRandomArray(12, 10, 100);
int result = Quantity(array1);
Console.WriteLine(result);
*/






