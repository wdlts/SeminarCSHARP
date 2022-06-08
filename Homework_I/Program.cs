/*ЗАДАЧА 1

int a, b;

Console.Write("Input integer a: ");

a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer b: ");

b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("No MAX or MIN, numbers are equal");
}
else if (a > b)
{
    Console.WriteLine($"Max = {a}");
    Console.WriteLine($"Min = {b}");
}
else
{
    Console.WriteLine($"Max = {b}");
    Console.WriteLine($"Min = {a}");
}
*/

/*ЗАДАЧА 2

int a, b, c, max;

Console.Write("Input integer a: ");

a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer b: ");

b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer c: ");

c = Convert.ToInt32(Console.ReadLine());


max = a;
if (b > a)
{
    max = b;
    
}
if (c > max)
{
    max = c;
}

if (max == a && max == b && max == c)
{
        Console.WriteLine("No MAX, numbers are equal");
}
else
{
    Console.WriteLine($"MAX is {max}");
}

*/


/*ЗАДАЧА 3

int number;

Console.Write("Input integer : ");
number = Convert.ToInt32(Console.ReadLine());

if ((number % 2) == 0)
{
    Console.WriteLine($"{number} is even");
}
else
    Console.WriteLine($"{number} is odd");

*/

/*ЗАДАЧА 4

int N;

Console.Write("Input integer number: ");
N = Convert.ToInt32(Console.ReadLine());


int current = 2;

while (N < current)
{
    Console.WriteLine($"{N} is too small, try again");
    Console.Write("Input integer number: ");
    N = Convert.ToInt32(Console.ReadLine());
}

while(current < N-1)
{
    Console.Write(current + ", ");
    current +=2;
}
Console.Write(current);
*/





    