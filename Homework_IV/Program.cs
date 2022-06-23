//ZADACHA 1 VARIANT 1
//  Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
void MethodRaising()
{
    Console.WriteLine("Input number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine(Math.Pow(num1, num2));
}
MethodRaising();
*/
//ZADACHA 1 VARIANT 2

/*
int MethodRaising()
{
    Console.WriteLine("Input number");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number");
    int B = Convert.ToInt32(Console.ReadLine());
    
    int degree = 0;
    int mltpl = 0;
    mltpl = A;
    int result = 0;
    while (degree < B-1)
    {
        degree ++;
        A = mltpl*A;
    }
        result = A;
        return result;
        
}
Console.WriteLine(MethodRaising());


//ZADACHA 2
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]
*/
/*
void MethodArrayEight()
{
    int size = 8;
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,100);
    }

    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
}
MethodArrayEight();
*/