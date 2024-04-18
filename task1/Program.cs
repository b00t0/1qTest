// Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


Console.Clear();

string[] LimitCharsOfArray(string[] array, int limit)
{
    string[] newArray = new string[array.Length];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < limit)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    bool firstElement = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null && array[i] != "")
        {
            if (!firstElement)
            {
                Console.Write(", ");
            }
            Console.Write($"{array[i]}");
            firstElement = false;
        }
    }
}
