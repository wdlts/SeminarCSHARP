/*Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
*/

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

int SymbolsOfWords(string[] array, char a)
{
    int count = 0;
    char[] vowel = new char[] {"a", "e", "i", "o", "u", "y"};
     for(int i = 0; i < array.Length; i++)
         if (array[i][0] = vowel[0])
            count ++;
            vowel ++;

    return count;        
}
Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());


string[] names = CreateStringArray(size);
char a = 'a'; 
Console.WriteLine(" " + SymbolsOfWords(names, a));



/*
Задача 2: Задайте массив строк. Напишите программу, которая генерирует 
новый массив, объединяя элементы исходного массива попарно.

Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
*/