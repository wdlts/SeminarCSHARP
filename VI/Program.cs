/*
int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length-1, i = 0;
    
    while (i<j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;
    }
    */
    /*
    for (int i=0; i < array.Length / 2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    */
    /*
    return array;
}   
int[] myArray = {2, 4, 6, 8};

myArray = ReverseArray(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i]+ " ");
}
*/

// 1. Напишите программу, которая принимает на вход три числа и проверяет, может ли 
//существовать треугольник с сторонами такой длины.
/*
bool Triangle(int sideA, int sideB, int sideC)
{
    if (sideA+sideB > sideC && sideA+sideC > sideB && sideB+sideC > sideA)
    return true;
    else return false;
}
    


Console.WriteLine("Введите sideA ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите sideB ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите sideC ");
int sideC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triangle(sideA, sideB, sideC));
*/


// 2. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


// Fn = Fn-1 + Fn-2

/*
void Fibonacci (int N)
{
    int[] array = new int [N]; 
    
    array[0] = 0;
    array[1] = 1;
    Console.WriteLine(array[0]);
    Console.WriteLine(array[1]);
    for (int i = 2; i < N; i++)
    {
        
        array[i] = array[i-1] + array[i-2];
        Console.WriteLine(array[i]);
    }
    
}

Console.WriteLine("Введите N ");
int N = Convert.ToInt32(Console.ReadLine());

Fibonacci(N);
*/

// 3. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
string DecToBin (int dec)
{
    string result = string.Empty;
    while (dec > 0)
    {
        result  = dec % 2 + result;
        dec /= 2;
    }
    return result;

}

Console.WriteLine(DecToBin(0));
*/
/*
void Twenty()
{   
    Console.WriteLine("Input num: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input size: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];
            
    for (int i = 0; i < size; i++)
    {
        array[i] = num;
    }

    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
}


Twenty();
*/
/*
void TwentyThirtFive()
{   
    Console.WriteLine("Input size :");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    int N = 10;         
        
    for(int i = 10; i < size; i++)
    {
       array[i] = N;
       Console.Write(array[i] + " "); 
       Console.WriteLine((array[i]*array[i]) + " ");
       N = N+1;
    }
}
TwentyThirtFive();
*/
/*void TwentyThirtFive()
{   
    
    Console.WriteLine("Input size :");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    Console.WriteLine("Input N :");
    int N = Convert.ToInt32(Console.ReadLine());
             
        
    for(int i = N; i < size; i++)
    {
       array[i] = N;
       Console.Write(array[i] + " "); 
       Console.WriteLine((array[i]*array[i]*array[i]) + " ");
       N = N+1;
    }
}
TwentyThirtFive();
*/
/*
void GoodsTable()
{
    Console.WriteLine("How many goods? ");
    int goodsnumber = Convert.ToInt32(Console.ReadLine());
    int good = 1;
    double price = 55.99;
    Console.Write("NUMBER ");
    Console.Write("PRICE ");
    Console.WriteLine();
   
        while (good <= goodsnumber)
        {   
            
            Console.Write(good + "     | ");
            Console.WriteLine((price*good) + " ");
            good = good+1;
            
        }
        
}

GoodsTable();*/


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

int[] myArray = NewArrayInput(10);

Console.WriteLine("Total numbers greater than zero " + GreaterZero(myArray));
*/


//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


/*
int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length-1, i = 0;
    
    while (i<j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;
    }
       
    for (i=0; i < array.Length / 2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}   

int[] myArray = {2, 4, 6, 8};

myArray = ReverseArray(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i]+ " ");
}
*/
/*
int[] CopyRandomArray()
{

    int[] CreateRandomArray(int size)
    {
        int[] newArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            newArray[i] = new Random().Next(8, 10);
            Console.Write (newArray[i] + " ");
        }
        Console.WriteLine();
        
        return newArray;


    }

    int[] newArray2 = CreateRandomArray(4);

    for (int i = 0; i < newArray2.Length; i++)
    {
        Console.Write(newArray2[i]+ " ");
    }

    Console.WriteLine(newArray2);
    return newArray2;
    
}

CopyRandomArray();
*/
/*
int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length-1, i = 0;
    
    while (i<j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;
    }
    */
    /*
    for (int i=0; i < array.Length / 2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    
    
    return array;
}   

*/
/*
int[] CreateRandomArray(int size)
    {
        int[] newArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            newArray[i] = new Random().Next(8, 10);
            Console.Write (newArray[i] + " ");
        }
        Console.WriteLine();
        
        return newArray;


    }
*/



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
        Console.Write(newArray2[j]+ " ");
    }
    return newArray2;
    
}
int[] newArray = new int[] {1, 27, 3, 7};

CopyArray(newArray);
*/

/*
int[] MethodNewArray()
    

{
    int size = 700;
    int number = 1;
    int[] newarray = new int[size];
    for (int i = 0; i<size; i++)
    {
        newarray[i] = number++;
        Console.Write(newarray[i]+" ");
    }
    return newarray;
    
}
int MethodSum(int[] newarray2)
{
    int min = newarray2[100];
    int sum = min;
    
    for (int i = 100; i<500; i++)
        {
            sum = min++;
        }
        return sum;
        
}
Console.WriteLine(MethodSum(MethodNewArray()));

*/

