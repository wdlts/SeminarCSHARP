/*Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
*/
/*
string[] CreateStringArray(int size )
{
    string[] words = new string [size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words [i] = Console.ReadLine();
    }
    return words;
}

int VowelWords(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
         if (array[i][0] == 'a' || array[i][0] == 'e' || array[i][0] == 'i' || 
            array[i][0] == 'o' || array[i][0] == 'u' || array[i][0] == 'y')
            count ++;
    return count;        
}
Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] names = CreateStringArray(size);
Console.WriteLine("Number of words starting with vowel is " + VowelWords(names));
*/


/*
Задача 2: Задайте массив строк. Напишите программу, которая генерирует 
новый массив, объединяя элементы исходного массива попарно.

Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
*/
/*
string[] CreateStringArray(int size)
{
    string[] words = new string [size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words [i] = Console.ReadLine();
    }
    return words;
}

string[] MatchArrayWords(int size, string[] array1)
{
    string[] words = new string [size];
    for(int i = 0; i < size; i=i+2)
    {
        words [i]= array1[i] + "" + array1[i+1];
    }
    return words;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
   
    Console.WriteLine();
}

Console.Write("Input array size. Size should be even: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size % 2 !=0)
{
    Console.WriteLine("Arrays size should be even.");
    
}
else
{
    string[] myarray1 = CreateStringArray(size);
    ShowArray(MatchArrayWords(size, myarray1));
}

*/