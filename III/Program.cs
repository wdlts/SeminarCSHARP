/*void FindQuart(int x, int y)

{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;

    return -1;
}

int result = FindQuart(-2,4);

if (result == -1)
{
    Console.WriteLine("Given point is set on axis");

}
else Console.WriteLine($"Point is in {result} quorter");
*/


/*
void FindDiapason(int q)
{
    if (q >=1 && q<=4)
    {
        if (q == 1 ) Console.WriteLine("x and y are positive");
        if (q == 2 ) Console.WriteLine("x negative and y positive");
        if (q == 3 ) Console.WriteLine("x negative and y negative");
        if (q == 4 ) Console.WriteLine("x positive and y negative");
    }
    else
    Console.WriteLine("q is not a quarter number");
}

Console.WriteLine("Input quarter");
int q = Convert.ToInt32(Console.ReadLine());
FindDiapason(q);
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());

void QuadTable(int num)
    {   
        
        int current = 1;
        int quad = 1;
        Console.Write(current);
        while (current < num)
        {   
            
            current = current+1;
            quad = current*current;
            Console.Write($" {quad}");
        }
        
    }
QuadTable(num);
*/

/*
double FindLength(double xA, double yA, double xB, double yB);
{
    Math.Sqrt((xB-xA)*(xB-xA)+ Math.Pow((yB-yA),2));
}
*/