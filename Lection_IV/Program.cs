//string[,] table = new string[2, 5];

//int[,] matrix = new int[5, 8];
//table[1,2] = "word";
/*
for (int rows = 0; rows  < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/


/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();    
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int [,] matrix = new int[5, 5];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(); 
PrintArray(matrix);
*/
/*
int [,] pic = new int [,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, },
    {0, 0, 1, 1, 1, 1, 0, 0, },
    {0, 0, 1, 0, 0, 1, 0, 0, },
    {0, 1, 1, 0, 0, 1, 1, 0, },
    {0, 1, 0, 0, 0, 0, 1, 0, },
    {0, 1, 1, 1, 1, 1, 1, 0, },
    {0, 0, 0, 0, 0, 0, 0, 0, }
};

void PrintImage(int[,] image)
{
    for (int i = 0; i  < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if (image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
            
        }
    Console.WriteLine();    
    }
}
void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}


PrintImage(pic);
FillImage(3, 4);
PrintImage(pic);
*/
/*
double Factorial(int n)
{
    if (n == 1) return 1;
    else return n*Factorial(n-1);
}
for (int i = 1; i < 40; i++)


Console.WriteLine($"{i}! = {Factorial(i)}");
*/
/*
double Fib(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fib(n-1) + Fib(n-2);
}

for (int i = 1; i < 100; i++)
{
    Console.WriteLine($"f({i}) = {Fib(i)}");
}
*/