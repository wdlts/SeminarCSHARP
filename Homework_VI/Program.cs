//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
//0, 7, 8, -2, -2 -> 2
//
//1, -7, 567, 89, 223-> 3


/*
int[] NewArrayInput(int size)
{
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

int[] myArray = NewArrayInput(3);

Console.WriteLine("Total numbers greater than zero " + GreaterZero(myArray));
*/

//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


/*
int[] CopyArray(int[] newArray2)
{
    int i=0;
    int j=0;
    int temp;
    temp = newArray2[i];
    newArray2[i] = newArray2[j];
    newArray2[j] = temp;

    for (j = 0; j < newArray2.Length; j++)
    {
        Console.Write(newArray2[j]+ "copy");
    }
    return newArray2;
    
}
int[] newArray = new int[] {1, 27, 3, 7};

CopyArray(newArray);
*/
