//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    if(n != 1)
    
        ShowNums(n-1);
    Console.Write(n+ " ");
    
    
}
Console.Write("Input n ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/

//1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/*
void ShowNums(int m, int n)

{
    if(m != n)
    
        ShowNums(m, n-1);
        
    
    Console.Write(n+ " ");
}

Console.Write("Input m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n ");
int n = Convert.ToInt32(Console.ReadLine());


ShowNums(m, n);
*/

//2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumNum (int n)
{
    if (n/10 != 0)
        return SumNum (n/10) + n % 10;
    else
        return n;
   
    
}

Console.Write("Input n ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(n));
*/



//3. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
/*
int SumNum (int n)
{
    int sum = 0;
    if (n/10 != 0)
    
        sum = SumNum (n/10) + n % 10;
    
    return sum;
}

Console.Write("Input n ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(n));
*/