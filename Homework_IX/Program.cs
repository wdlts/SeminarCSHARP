/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
Console.Write("Input m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n ");
int n = Convert.ToInt32(Console.ReadLine());


int SumNum (int n)
{
    if (m < n)   
        return n+SumNum(n-1);
    else if (m == n)
        return m;
    else return 0;
}  
Console.WriteLine(SumNum(n));
*/





/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.

453 -> 3

45 -> 2
*/
/*
Console.Write("Input m ");
int m = Convert.ToInt32(Console.ReadLine());

int ElemNum (int m)
{
    {
        if (m/10 != 0)
            return ElemNum (m/10)+1;
        else if (m == 0)
            return 0;
        else
            return m/m;
    }
}
Console.WriteLine(ElemNum(m));
*/