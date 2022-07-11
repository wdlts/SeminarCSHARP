/**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк,
 длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

*/

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
*/
/*
void ShowArray(string[] array)
{
    for (int i = 0; i<array.Length; i++)
        Console.Write (array[i] + " ");
    Console.WriteLine();
}
*/
/*
void NewStringArray(string[] array)
{
    for (int i = 0; i<array.Length; i++)
        if (array[i].Length<=3)
        {
            Console.Write (array[i] + " ");
        }
    
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStringArray(size);
NewStringArray(array);
*/