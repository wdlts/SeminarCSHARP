/*int FindMax(int num)
{
    int dec, ed;
    
    if(num >= 10 && num <= 99)
    {
        dec = num / 10;
        ed = num % 10;

        if (dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }
    }
    else
    {
        return-1;
    }
}

Console.Write("Input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());




int result = FindMax(a);

if(result == -1)
{
    Console.WriteLine("Your number is not two-digit");
}


Console.WriteLine($"Bigger number of {a} is {result}");


//c = a%b
//5%2 -> 1
//5/2 -> 2

//1234

//1234 / 10 -> 123%10 -> 3
//1234 % 10 -> 4
//12 / 10 = 1
//35/10 = 3

//12%10 = 2
//35%10 = 5
//123%10 = 3
*/

/*int MiddleDelete()

{
    int num = new Random().Next(100, 999);
    Console.WriteLine("number is " + num);
    int sot = num / 100;
    int ed = num % 10;

    int result = sot * 10 + ed;
    return result;

}

Console.WriteLine(MiddleDelete());
*/

/*
Random rnd = new Random();
int number = rnd.Next(100, 999);
Console.WriteLine(number);

int num1, num2;

Console.WriteLine(num1 = number / 100);
Console.WriteLine(num2 = number % 10);
Console.WriteLine($"{num1}{num2}");

*/
/*int num1, num2;

Console.Write("Input integer number: ");

num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer number: ");

num2 = Convert.ToInt32(Console.ReadLine());

int result;

if (num2 % num1 == 0)
{
    Console.Write("Chislo kratnoe");
}
else
{
    result = num2 % num1;
    Console.Write(result);
}*/
/*
string IsKratnoe(int num1, int num2)
{
    if(num1 % num2 == 0)
    {
        return "True";
    }
    else
    {
        return ("False, rest num is" + num2 % num1);
    }
}

*/

/*int MethodKratnost(int num)
{

    if (num % 7 == 0 && num % 23 == 0)
    {
        return 1;
    }
    else
    {
        return -1;
    }
}

Console.Write("Input integer number: ");

int num = Convert.ToInt32(Console.ReadLine());

int result = MethodKratnost(num);

if(result == 1)
{
    Console.WriteLine("Chislo kratnoe");
}
else
{
    Console.WriteLine("Chislo ne kratnoe");
}
*/

/*bool IsAliquot237(int num)
{
    if(num % 23*7 == 0) return true;
    else return false;
}
*/





    
    



    

        


