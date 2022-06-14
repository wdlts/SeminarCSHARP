//ZADACHA 1 VARIANT 1

/*
Console.WriteLine("Input 5-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

void PalindromeFunc(int num)
{
    if (num<0)
    {
        num = num*-1;
    }
    if (num < 10000 || num > 99999)
    {
        Console.WriteLine("Given number is not 5-digit");
    }
    else
    {
        int[] array = num.ToString().ToCharArray().Select(x => x - '0').ToArray();
        int num1 = array[0];
        int num2 = array[1];
        int num4 = array[3];
        int num5 = array[4];

        if (num1 != num5 && num2 != num4)
        {
            Console.WriteLine("Given number is not a palindrome");
        }
            
        if (((num > 9999 && num < 100000) && (num1 == num5 && num2 == num4)))
        {
            Console.WriteLine("Given number is a palindrome");
        }
    }
}

PalindromeFunc(num);
*/


//ZADACHA 1 VARIANT 2
/*
Console.WriteLine("Input 5-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());


void PalindromeFunc(int num)
{
    if (num<0)
    {
        num = num*-1;
    }
    if (num < 10000 || num > 99999)
    {
        Console.WriteLine("Number is not 5-digit");
    }
    else
    {
        int num1 = num / 10000;
        int num2 = (num % 10000)/1000;
        int num3 = (num / 10) % 10;
        int num4 = num % 10;

        if (num1 == num4 && num2 == num3)
        {
            Console.WriteLine("Given number is a palindrome");
        }
        else
        {
            Console.WriteLine("Given number is not a palindrome");
        }
    }
}
PalindromeFunc(num);

*/


//ZADACHA 2
/*
Console.WriteLine("Input xA");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yA");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input zA");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xB");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yB");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input zB");
double zB = Convert.ToDouble(Console.ReadLine());


double FindLength(double xA, double yA, double zA, double xB, double yB, double zB)

    {
       return Math.Round(Math.Sqrt((xB-xA)*(xB-xA) + Math.Pow((yB-yA),2) + Math.Pow((zB-zA),2)), 2);
       
    }
  
FindLength(xA, yA, zA, xB, yB, zB);

Console.WriteLine(FindLength(xA, yA, zA, xB, yB, zB));
*/

//ZADACHA 3
/*
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());

void CubeTable(int num)
    {   
        if (num < 0)
        {
            Console.Write("Number < 0, input positive number");    
        }
        else
        {
            int current = 1;
            int cube = 1;
            Console.Write(current);

            while (current < num)
            {   
                current = current+1;
                cube = current*current*current;
                Console.Write($" {cube}");
            }
        }
    }
CubeTable(num);
*/
