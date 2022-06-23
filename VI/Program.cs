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
void TwentyThirtFive()
{   
    
    int size = 51;

    int[] array = new int[size];

    int N = 50;         
    Console.WriteLine("Input i :");
    int i = Convert.ToInt32(Console.ReadLine());    
    for( i =0; i < size; i++)
    
    {
       array[i] = N;
       Console.Write(array[i] + " "); 
       Console.WriteLine((array[i]*array[i]*array[i]) + " ");
       N = N+1;
    }
}
TwentyThirtFive();