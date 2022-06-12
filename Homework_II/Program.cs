/* ZADACHA 1

int MiddleShow()
{
    Console.Write("Input integer number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int numsecond = num % 100 / 10;
    
    if (num < 0)
    {
        numsecond = numsecond*(-1);
    }
    return numsecond;
}

Console.WriteLine(MiddleShow());

*/

//ZADACHA 2
/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num <100 && num >-100)
{
    Console.Write("No third number.");
}
else
{
    int ThirdShow()
    {
            if (num > 99)
            {
                num = int.Parse(Convert.ToString(num)[2].ToString());
            }
            if (num < -99)
            {
                num = num*(-1);
                num = int.Parse(Convert.ToString(num)[2].ToString());
            }
            num = Convert.ToInt32(num);
            return num;
    }
Console.WriteLine(ThirdShow());
}
*/

//ZADACHA 2 VARIANT 2

/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <100 && num >-100)
{
    Console.Write("No third number.");
}

else
{
    int ThirdShow()
    {
            if (num <0)
            num = num * (-1);
            while (num > 999)
            {
                num = num / 10;
            }
            if (num > 99 && num <=999)
            {
                num = num % 10;
            }
        return num;
    }
Console.WriteLine(ThirdShow());
}
*/



// ZADACHA 3
/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

string IsWeekDay(int num)
    {
        if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5 )
        {
        return (num + " is a working day");
        }
    else if (num == 6 || num == 7)
        {
        return(num + " is a holiday");
        }
    else
        {
        return(num + " is not a day of week");
        }
    }


Console.Write(IsWeekDay(num));
*/
