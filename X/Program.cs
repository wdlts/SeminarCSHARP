

//Console.WriteLine(names[0]);

//Console.WriteLine(names[0][0]);

/*
string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i<size; i++)
    {
        Console.Write($"Input {i+1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}

void ShowArray(string[] array)
{
    for (int i = 0; i<array.Length; i++)
        Console.Write (array[i] + " ");
    Console.WriteLine();
}

int NumberOfLongWords(string[] array)
{
    int count = 0;

    for (int i = 0; i<array.Length; i++)
        if (array[i].Length>=5)
            count++;
    return count;
}

Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] names = CreateStringArray(size);

Console.Write("Number of words is: " + NumberOfLongWords(names));

*/
//1. Написать программу, которая принимает на вход два массива строк и 
//возвращает массив из попарно объединенных исходных элементов.






//2. Написать программу, которая считает кол-во слов, начинающихся на букву Y или W.
/*
string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i<size; i++)
    {
        Console.Write($"Input {i+1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}

void ShowArray(string[] array)
{
    for (int i = 0; i<array.Length; i++)
        Console.Write (array[i] + " ");
    Console.WriteLine();
}

int NumberOfLongWords(string[] array)
{
    int count = 0;

    for (int i = 0; i<array.Length; i++)
        if (array[i][0] == "Y" || array[i][0] == "M")
            count++;
    return count;
}

Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] names = CreateStringArray(size);

Console.Write("Number of words is: " + NumberOfLongWords(names));
*/
/*
string[] CreateStringArray(int size )
{
    string[] words = new string [size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words [i]= Console.ReadLine();
    }

    return words;
}
void ShowArray(string[] array)
{
   for(int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int SymbolsOfWords(string[] array, char a, char b)
{
    int count = 0;

     for(int i = 0; i < array.Length; i++)
         if (array[i][0] == a|| array[i][0] ==b)
            count ++;

    return count;        
}
Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input First Symbol: ");
char a = Convert.ToChar(Console.ReadLine());
Console.Write("Input Second Symbol: ");
char b = Convert.ToChar(Console.ReadLine());
string[] names = CreateStringArray(size);
Console.WriteLine(" " + SymbolsOfWords(names, a,b));



*/

/*

string[] CreateStringArray(int size)
{
    string[] words = new string [size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words [i]= Console.ReadLine();
    }

    return words;
}

string[] MatchTwoArrays(int size, string[] array1, string[] array2)
{
    string[] words = new string [size];

    for(int i = 0; i < size; i++)
    {
        words [i]= array1[i] + " " + array2[i];
    }

    return words;
}

void ShowArray(string[] array)
{
   for(int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myarray1 = CreateStringArray(size);
string[] myarray2 = CreateStringArray(size);
ShowArray(MatchTwoArrays(size, myarray1,myarray2));
*/