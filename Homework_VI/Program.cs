//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
//0, 7, 8, -2, -2 -> 2
//
//1, -7, 567, 89, 223-> 3




/*
int[] NewArrayInput()
{
    Console.WriteLine("How many M elements would you like to input? ");
    int numM = Convert.ToInt32(Console.ReadLine());
    int size = numM;
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Input M :");
        int M = Convert.ToInt32(Console.ReadLine());
        newArray[i] = M;
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int GreaterZero(int[] array)
{
    int gzero = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) gzero++;
    }
    return gzero;
}

int[] myArray = NewArrayInput();

Console.WriteLine("Total numbers greater than zero " + GreaterZero(myArray));


//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

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

int[] newArr = NewRandomArray(7);


int[] CopyArray(int[] array)
{
    array = newArr;

    for (int i = 0; i<array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    return array;
    
}

CopyArray(newArr);
*/

