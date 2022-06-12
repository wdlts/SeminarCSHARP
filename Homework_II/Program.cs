 //ZADACHA 1
/*
Console.Write("Input integer number: ");
int numsecond = Convert.ToInt32(Console.ReadLine());


string MiddleShow(int numsecond)
    {
        if (numsecond > 999 || numsecond < 100 && numsecond >= 0 || numsecond < -999 || numsecond > -100 && numsecond <0)
        {
            return ("Number is not 3-digit");
        }
        if (numsecond < 0)
        {
            numsecond = numsecond*(-1);
        }
        
        numsecond = numsecond % 100 / 10;
        return ($"{numsecond}");
    }
Console.WriteLine(MiddleShow(numsecond));

*/

//ZADACHA 2
/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
    string ThirdShow(int num)
    {
        if (num <100 && num >-100)
        {
            return ("No third number.");
        }
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
        return ($"{num}");
    }
Console.WriteLine(ThirdShow(num));

*/

//ZADACHA 2 VARIANT 2
/*

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());




string ThirdShow(int num)
    {
        if (num <100 && num >-100)
        {
            return ("No third number.");
        }
        if (num <0)
        {
            num = num * (-1);
        }
        while (num > 999)
        {
            num = num / 10;
        }
        if (num > 99 && num <=999)
        {
            num = num % 10;
        }
        return ($"{num}");
    }
Console.WriteLine(ThirdShow(num));

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
